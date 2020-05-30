using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections.Generic;


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
            bool smalpre = Info.PrefixSmall;
            double ScaleFactor = Info.SqueezeFactor;

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

            int[] xposes = spacing(chars, Info) ;

            if (Info.auto)
            {
                thisImage = new Bitmap(totalLength + 2, 32);
            }

            //if left align or auto size, do not shift. if center or right, shift
            if (!(Info.align == 0) && !Info.auto)
            {
                int shiftFactor = (thisImage.Width - totalLength) / Info.align;
                for (int i = 0; i < xposes.Length; i++)
                {
                    xposes[i] = shiftFactor + xposes[i];
                }
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

                        double heightAdjustment = (double)thisImage.Height / 32;

                        if (chara.Length > 1 && withPre)
                        {
                            double preScale = 1;
                            if (smalpre)
                            {
                                preScale = .9;
                            }
                            mainImage.DrawImage(LetterImage, new Rectangle(xposes[i], 0, (int)(bmp.Width * preScale * heightAdjustment), (int)(bmp.Height * preScale)));
                        }
                        else
                        {
                            mainImage.DrawImage(LetterImage, new Rectangle(xposes[i], 0, (int)(bmp.Width * ScaleFactor * heightAdjustment), thisImage.Height));
                        }

                        bmp.Dispose();
                        LetterImage.Dispose();

                        thisImage = picture;
                    }
       
                }
              
            }
            if(Info.HasColor && Gradients.BySetting ==2)
            {
                thisImage = editColor(thisImage, Gradients.Colors[0], Gradients.Positions[0],
                          Gradients.Angles[0]);
            }
            
            thisImage = makeOutline(thisImage);
            return thisImage;
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
            bool smalPre = Info.PrefixSmall;
            double ScaleFactor = Info.SqueezeFactor;

            //Console.WriteLine("Image height: " + image.Height);
            
            //iterate through the whole array to get the position of each character
            for (int i = 0; i < text.Length; i++)
            {
                String letter = text[i];

                if (!String.IsNullOrWhiteSpace(letter))
                {
                    //Console.Write(letter);
                    String name = "mariofont_" + letter + ".png";
                    String fileToRead = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\btis\" + name;
                    try
                    {
                        Bitmap imageLetter = new Bitmap(fileToRead);
                        int magicNumbber = (int)( imageLetter.Width * ((double)image.Height / 32));


                        if (i + 1 < text.Length)
                        {
                            if(letter.Length > 1)
                            {
                                double prefixScale = 1;
                                if (smalPre)
                                {
                                    prefixScale = .8;
                                }
                                positions[i + 1] = positions[i] + ((int)(magicNumbber * prefixScale) - btletters);
                                TotLength += ((int)(magicNumbber * prefixScale) - btletters);
                            } else
                            {
                                positions[i + 1] = positions[i] + ((int)(magicNumbber * ScaleFactor) - btletters);
                                TotLength += ((int)(magicNumbber * ScaleFactor) - btletters);
                            }
                            
                        } else
                        {
                            TotLength += (int)(magicNumbber * ScaleFactor);
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
