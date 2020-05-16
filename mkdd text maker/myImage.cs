using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;

namespace mkdd_text_maker
{
    class myImage
    {
        static int totalLength;
        
        public static Image writeLetters(WriteInfo Info)
        {
            //trim text and get the characters
            String text = Info.getText();
            text.Trim();
            char[] characters = text.ToCharArray();

            String[] chars;

            //if there is a prefix, make the array of strings to write accomdate it

            String prefix = Info.getpre();
            bool smalpre = Info.getsmall();
            double ScaleFactor = Info.getsqueeze();

            bool withPre = prefix.Equals("none");
            
            int index;


            if (!withPre)
            {
                chars = new string[characters.Length + 2];
                chars[0] = prefix;
                chars[1] = " ";
                index = 2;
            } else
            {
                chars = new string[characters.Length];
                index = 0;
            }

            //write the char array to the string array
            for(int i = 0; i < characters.Length; i++)
            {
                chars[i + index] = characters[i].ToString();
            }

            Image thisImage = Info.getImage();

           

            int[] xposes = spacing(chars, Info) ;

            if (Info.getauto())
            {
                thisImage = new Bitmap(totalLength, 32);
            }

            //if left align or auto size, do not shift. if center or right, shift
            if (!(Info.getalign() == 0) && !Info.getauto())
            {
                int shiftFactor = (thisImage.Width - totalLength) / Info.getalign();
                for (int i = 0; i < xposes.Length; i++)
                {
                    xposes[i] = shiftFactor + xposes[i];
                }
            }
            int cindex = xposes.Length;
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
                    Bitmap asdf = new Bitmap(fileToRead);


                    //if the color is on, edit the letter image
                    if (Info.getcol())
                    {
                        
                        int colorindex = cindex % Info.getcolor().Count;
                       
                        asdf = editColor(asdf, Info.getcolor()[colorindex]);
                        cindex--;

                    }

                    Bitmap bmp = new Bitmap(asdf.Width, asdf.Height, PixelFormat.Format32bppPArgb);

                    

                    Bitmap picture = new Bitmap(thisImage);
                    Graphics mainImage = Graphics.FromImage(picture);

                    double heightAdjustment = (double)thisImage.Height / 32;

                    if(chara.Length > 1)
                    {
                        double preScale = 1;
                        if (smalpre)
                        {
                            preScale = .9;
                        }
                        mainImage.DrawImage(asdf, new Rectangle(xposes[i], 0, (int)(bmp.Width * preScale * heightAdjustment), (int)(bmp.Height * preScale)));
                    } else
                    {
                        mainImage.DrawImage(asdf, new Rectangle(xposes[i], 0, (int)(bmp.Width * ScaleFactor * heightAdjustment), thisImage.Height));
                    }
 
                    thisImage = picture;
                }
              
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
            Image image = Info.getImage();
            int btletters = Info.getletter();
            int btwords = Info.getword();
            bool smalPre = Info.getsmall();
            double ScaleFactor = Info.getsqueeze();

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
                    Color pixel = ((Bitmap)image).GetPixel(i, j);
                    int alpha = pixel.A;
                    if(alpha == 255)
                    {
                        newImage.SetPixel(i,j, pixel);
                    } else
                    {
                        if(CheckAdjacent(i, j, (Bitmap)image))
                        {
                            newImage.SetPixel(i, j, Color.Black);
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

        private static Bitmap editColor(Image image, Color[] color)
        {
            //Console.WriteLine(color.R);
            
            

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color pixel = ((Bitmap)image).GetPixel(i, j);
                    if(pixel.A == 255)
                    {
                        double x = pixel.R / 255.00;
                        double y = 1 - ((double) j / (double)image.Height);
                        //System.Diagnostics.Debug.Write(" " + x);
                        if (color[0].Equals(color[1]))
                        {
                            pixel = Color.FromArgb(255, (int)(x * color[0].R), (int)(x * color[0].G), (int)(x * color[0].B));
                        } else
                        {
                            pixel = Color_Editor.gradCalc(color[0], color[1], x, y);
                        }
                   
                        ((Bitmap)image).SetPixel(i, j, pixel);
                    }
                    
                    
                }
            }

            return (Bitmap)image;
        }

    }
}
