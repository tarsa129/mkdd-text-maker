using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Diagnostics;

namespace mkdd_text_maker
{
    class myImage
    {
        static int totalLength;
        
        public static Image writeLetters(WriteInfo Info, Gradient Gradients)
        {
            //trim text and get the characters
            String text = Info.text;
            text.Trim();
            char[] characters = text.ToCharArray();

            String[] chars;

            //if there is a prefix, make the array of strings to write accomdate it

            String prefix = Info.Prefix;
            bool withPre = prefix.Equals("none");
            
            int index;


            if (!withPre)
            {
                chars = new String[characters.Length + 2];
                chars[0] = prefix;
                chars[1] = " ";
                index = 2;
            } else
            {
                chars = new String[characters.Length];
                index = 0;
            }

            int cindex = -1;

            //write the char array to the string array
            for (int i = 0; i < characters.Length; i++)
            {
                chars[i + index] = characters[i].ToString();
                if(!String.IsNullOrWhiteSpace(chars[i + index]))
                {
                    cindex++;
                }
            }

            //thing for special characters here
            chars = Form1.specialCharacters(chars);

            Image thisImage = Info.image;

            //call the spacing function
            int[] xposes = spacing(chars, Info);

            thisImage = new Bitmap(totalLength + 3, 32);

            for (int i = 0; i < xposes.Length; i++)
            {
                xposes[i] = 1 + xposes[i];
            }

            if (Info.auto)
            {
               // thisImage = new Bitmap(totalLength + 3, 32);
            }

            //actually writing the letters
            for (int i = xposes.Length - 1; i > -1; i --)
            {
                String letter = chars[i];
                String chara = letter.ToString().ToLower();

                if (!String.IsNullOrWhiteSpace(letter))
                {
                    //get the letter image files 

                    String name = "mariofont_" + chara + ".png";
                    String fileToRead = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\btis\" + name;
                    
                    if (File.Exists(fileToRead))
                    {
                        Bitmap LetterImage = new Bitmap(fileToRead);

                        //if the color is on, edit the letter image
                        if (Info.HasColor && Gradients.BySetting == 0)
                        {

                            int colorindex = cindex % Gradients.Colors.Count;

                            LetterImage = editColor(LetterImage, Gradients.Colors[colorindex], Gradients.Positions[colorindex],
                                Gradients.Angles[colorindex]);
                            cindex--;

                        }

                        Bitmap bmp = new Bitmap(LetterImage.Width, LetterImage.Height,System.Drawing.Imaging.PixelFormat.Format32bppPArgb);

                        Bitmap picture = new Bitmap(thisImage);
                        Graphics mainImage = Graphics.FromImage(picture);

                        //drawing the actual image
                        if (chara.Length > 1 && withPre)
                        {
                            double preScale = 1;
                            if (Info.PrefixSmall)
                            {
                                preScale = .9;
                            }
                            mainImage.DrawImage(LetterImage, new Rectangle(xposes[i], 0, (int)(bmp.Width * preScale), (int)(bmp.Height * preScale)));
                        }
                        else
                        {
                            mainImage.DrawImage(LetterImage, new Rectangle(xposes[i], 0, bmp.Width, 32));
                        }

                        bmp.Dispose();
                        LetterImage.Dispose();

                        thisImage = picture;
                    }
       
                }
              
            }

            //color the image if by image
            if(Info.HasColor && Gradients.BySetting ==2)
            {
                thisImage = editColor(thisImage, Gradients.Colors[0], Gradients.Positions[0],
                          Gradients.Angles[0]);
            }

            //scale the image
            thisImage = makeOutline(thisImage);

            Image newImage = new Bitmap(Info.image.Width, Info.image.Height);
            Graphics newgraph = Graphics.FromImage(newImage);

            int NewWidth = (int)(thisImage.Width * Info.SqueezeFactor);
            int NewHeight = (int)(thisImage.Height * Info.VertiFactor);

            Rectangle DrawRectangle = new Rectangle(0, (Info.image.Height - NewHeight) /2, NewWidth, NewHeight);
   
            if (!Info.auto)
            {
                if (Info.align == 1)
                {
                    int HoriShift = Info.image.Width - (int)(thisImage.Width* Info.SqueezeFactor);
                    DrawRectangle.Offset(HoriShift, 0);

                } else if (Info.align == 2)
                {
                    int HoriShift = Info.image.Width - (int)(thisImage.Width * Info.SqueezeFactor);
                    DrawRectangle.Offset(HoriShift / 2, 0);

                }
            } else
            {
                newImage = new Bitmap(NewWidth, NewHeight);
                newgraph = Graphics.FromImage(newImage);
                DrawRectangle = new Rectangle(0, 0, NewWidth, NewHeight);
            }

            newgraph.DrawImage(thisImage, DrawRectangle);

            return newImage;
        }

        //process shit IN ORDER
        public static int[] spacing(String[] text, WriteInfo Info)
        {
            //make the positions array
            int[] positions = new int[text.Length];
            positions[0] = 0;
            int TotLength = 0;

            //get the information
            Image image = Info.image;
            int btletters = Info.LetterSpacing;
            int btwords = Info.WordSpacing;

            //Console.WriteLine("Image height: " + image.Height);
            
            //iterate through the whole array to get the position of each character
            for (int i = 0; i < text.Length; i++)
            {
                String letter = text[i];

                if (!String.IsNullOrWhiteSpace(letter))
                {
                    String name = "mariofont_" + letter + ".png";
                    String fileToRead = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\btis\" + name;
                    try
                    {
                        Bitmap imageLetter = new Bitmap(fileToRead);

                        if (i + 1 < text.Length)
                        {
                            if(letter.Length > 1)
                            {
                                double prefixScale = 1;
                                if (Info.PrefixSmall)
                                {
                                    prefixScale = .8;
                                }
                                positions[i + 1] = positions[i] + ((int)(imageLetter.Width * prefixScale) - btletters);
                                TotLength += ((int)(imageLetter.Width * prefixScale) - btletters);
                            } else
                            {
                                positions[i + 1] = positions[i] + ((int)(imageLetter.Width) - btletters);
                                TotLength += imageLetter.Width - btletters;
                            }
                            
                        } else
                        {
                            TotLength += imageLetter.Width;
                        }
                        
                       
                        imageLetter.Dispose();
                    }
                    catch {  }
                    

                }
                else
                {
                    positions[i+ 1] = positions[i] + (btwords);
                    TotLength += (btwords);
                }
            }
            //Console.WriteLine("");
            //Console.WriteLine(totalLength);

            totalLength = TotLength;
    
            return positions;
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //outline shit

        private static Image makeOutline(Image image)
        {

            Bitmap newImage = new Bitmap(image.Width, image.Height);


            for(int i = 0; i <image.Width; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    System.Drawing.Color pixel = ((Bitmap)image).GetPixel(i, j);
                    int alpha = pixel.A;
                    if(alpha == 255)
                    {
                        newImage.SetPixel(i,j, pixel);
                    } else
                    {
                        if(CheckAdjacent(i, j, (Bitmap)image))
                        {
                            newImage.SetPixel(i, j, System.Drawing.Color.Black);
                        }
                    }
                }
            }

            return newImage;
        }

        private static bool CheckAdjacent(int x, int y, Bitmap image)
        {
            for(int i = -1; i <= 1; i++)
            {
                for(int j = -1; j <= 1; j++)
                {
                    if(x + i > 0 && x + 1 < image.Width && y + j > 0 && y + j < image.Height)
                    {
                        if(image.GetPixel(x + i, y + j).A == 255)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static Bitmap editColor(Image image, List<Color> Colors, List<int> Positions, int angle)
        {
            List<float> ConvertedPositions = new List<float>();
            foreach (int position in Positions)
            {
                ConvertedPositions.Add((float)(position / 100.00));
            }

            Bitmap baseGrad = Gradient.getGradientBox(image.Width, image.Height, Colors, ConvertedPositions, angle);

            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i < image.Width; i++)
                {
                   
                    Color pixel = ((Bitmap)image).GetPixel(i, j);

                    if(pixel.A == 255)
                    {
                        double x = pixel.R / 255.00;

                        Color baseColor = baseGrad.GetPixel(i, j);

                        pixel = Color.FromArgb(255, (int)(x * baseColor.R), (int)(x * baseColor.G), (int)(x * baseColor.B));
                        ((Bitmap)image).SetPixel(i, j, pixel);
                    }
                    

                }
            }

                return (Bitmap)image;
        }

    }
}
