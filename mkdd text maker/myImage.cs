using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Media.TextFormatting;

namespace mkdd_text_maker
{
    class myImage
    {
        static int totalLength;
        
        public static Image writeLetters(WriteInfo Info, Color_Editor Gradients, Color_Editor Outline, Image BaseImage)    
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
            chars = Main_Form.specialCharacters(chars);

            //call the spacing function
            int[] xposes = spacing(chars, Info);

            Image thisImage = new Bitmap(totalLength + 3, 32);

            for (int i = 0; i < xposes.Length; i++)
            {
                xposes[i] = 1 + xposes[i];
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
                        if (Info.HasColor && Gradients.Setting == 0)
                        {

                            int colorindex = cindex % Gradients.Colors.Count;
                            Debug.WriteLine(colorindex);
                            LetterImage = editColor(LetterImage, Gradients, Outline, colorindex, BaseImage);
                            LetterImage = (Bitmap)why(LetterImage);
                            //LetterImage = (Bitmap)makeOutline(LetterImage, Outline.Colors[0][0]);
                            cindex--;

                        }

                        Graphics mainImage = Graphics.FromImage(thisImage);

                        //drawing the actual image
                        if (chara.Length > 1 && withPre)
                        {
                            double preScale = 1;
                            if (Info.PrefixSmall)
                            {
                                preScale = .9;
                            }
                            mainImage.DrawImage(LetterImage, new Rectangle(xposes[i], 0, (int)(LetterImage.Width * preScale), (int)(LetterImage.Height * preScale)));
                        }
                        else
                        {                       
                            mainImage.DrawImage(LetterImage, new Rectangle(xposes[i], 0, LetterImage.Width, 32));
                        }

                        LetterImage.Dispose();
                    }
       
                }
              
            }

            //color the image if by image
            if(Info.HasColor && Gradients.Setting == 2)
            {
                thisImage = editColor(thisImage, Gradients, Outline, index, BaseImage);
                
            }

            //thisImage = makeOutline(thisImage, Outline.Colors[0][0]);
            thisImage = makeOutline(thisImage, Outline);
            //scale the image



            Image newImage = new Bitmap(Info.image.Width, Info.image.Height);
            Graphics newgraph = Graphics.FromImage(newImage);

            int NewWidth = (int)(thisImage.Width * Info.SqueezeFactor);
            int NewHeight = (int)(thisImage.Height * Info.VertiFactor);

            Rectangle DrawRectangle = new Rectangle(0, (Info.image.Height - NewHeight) /2, NewWidth, NewHeight);
   

            //deal with alignment
            if (!Info.auto)
            {
                if (Info.align == 1)
                {
                    int HoriShift = Info.image.Width - (int)(thisImage.Width * Info.SqueezeFactor);
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

        private static Image makeOutline(Image image, Color_Editor Outline)
        {

            Bitmap newImage = new Bitmap(image.Width, image.Height);

            List<float> OLConvertedPositions = new List<float>();
            foreach (int position in Outline.Positions[0])
            {
                OLConvertedPositions.Add((float)(position / 100.00));
            }

            
            Bitmap OutlineGrad = Color_Editor.getGradientBox(image.Width, image.Height, Outline.Colors[0], OLConvertedPositions, Outline.Angles[0]);

            for (int i = 0; i <image.Width; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    Color pixel = ((Bitmap)image).GetPixel(i, j);
                    if(pixel.A == 255)
                    {
                        newImage.SetPixel(i,j, pixel);
                    } else
                    {
                        if(CheckAdjacent(i, j, (Bitmap)image))
                        {
                            newImage.SetPixel(i, j, OutlineGrad.GetPixel(i,j));
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

        private static Bitmap editColor(Image image, Color_Editor Text, Color_Editor Outline, int index, Image BaseImage)
        {
            
            List<float> ConvertedPositions = new List<float>();
            foreach (int position in Text.Positions[index])
            {
                ConvertedPositions.Add((float)(position / 100.00));
            }

            List<float> OLConvertedPositions = new List<float>();
            foreach (int position in Outline.Positions[0])
            {
                OLConvertedPositions.Add((float)(position / 100.00));
            }

            Bitmap baseGrad = Color_Editor.getGradientBox(image.Width, image.Height, Text.Colors[index], ConvertedPositions, Text.Angles[index]);
            Bitmap OutlineGrad = Color_Editor.getGradientBox(image.Width, image.Height, Outline.Colors[0], OLConvertedPositions, Outline.Angles[0]);


            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i < image.Width; i++)
                {
                   
                    Color pixel = ((Bitmap)image).GetPixel(i, j);

                    if(pixel.A == 255)
                    {
                        double x = pixel.R / 255.00;

                        Color ImageColor = ((Bitmap)BaseImage).GetPixel(i, j);
                        Color baseColor = baseGrad.GetPixel(i, j);
                        Color OutlineColor = OutlineGrad.GetPixel(i, j);

                        pixel = BlendColors(x, ImageColor, baseColor, OutlineColor);
                        ((Bitmap)image).SetPixel(i, j, pixel);
                    }
                    

                }
            }

            return (Bitmap)image;
        }

        private static Image why(Image image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int j = 0; j < image.Height; j++)
            {
                for (int i = 0; i < image.Width; i++)
                {
                    Color pixel = ((Bitmap)image).GetPixel(i, j);

                    if (pixel.A == 255)
                    {      
                        ((Bitmap)newImage).SetPixel(i, j, pixel);
                    }

                }
            }
            return newImage;
        }

        private static Color BlendColors(double alpha, Color ImageColor, Color BaseColor, Color OutlineColor)
        {
            
            int Red =   (int)(alpha * BaseColor.R + (1 - alpha) * OutlineColor.R);
            int Green = (int)(alpha * BaseColor.G + (1 - alpha) * OutlineColor.G);
            int Blue =  (int)(alpha * BaseColor.B + (1 - alpha) * OutlineColor.B);

            if (ImageColor.A == 0)
            {
                return Color.FromArgb(255, Red, Green, Blue);
            }
            

            Red =   (int)((1 - alpha) * Red) + (int)( (ImageColor.A / 255.0) * ImageColor.R);
            Green = (int)((1 - alpha) * Green) + (int)((ImageColor.A / 255.0) * ImageColor.G);
            Blue =  (int)((1 - alpha) * Blue) + (int)((ImageColor.A / 255.0) * ImageColor.B);
            

            return Color.FromArgb(255, Math.Min(Red, 255), Math.Min(Green, 255), Math.Min(Blue,255));
        }
    }
}
