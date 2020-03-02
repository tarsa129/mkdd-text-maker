using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace mkdd_text_maker
{
    class myImage
    {
        public static Image writeLetters(String text, Image thisImage, int btletters, int btwords, String prefix, double ScaleFactor, bool smalpre)
        {
            //trim text and get the characters
            text.Trim();
            char[] characters = text.ToCharArray();

            String[] chars;

            //if there is a prefix, make the array of strings to write accomdate it
            
            bool withPre = prefix.Equals("none");
            //Console.WriteLine(withPre);
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

            

            int[] xposes = spacing(chars, btletters, btwords, ScaleFactor, smalpre, thisImage.Width);

            for(int i = xposes.Length - 1; i > -1; i --)
            {
                String letter = chars[i];
                String chara = letter.ToString().ToLower();

                if (!String.IsNullOrWhiteSpace(letter))
                {
                    String name = "mariofont_" + chara + ".png";
                    String fileToRead = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\btis\" + name;
                    Bitmap asdf = new Bitmap(fileToRead);

                    Bitmap bmp = new Bitmap(asdf.Width, asdf.Height, PixelFormat.Format32bppPArgb);

                    Bitmap picture = new Bitmap(thisImage);
                    Graphics mainImage = Graphics.FromImage(picture);

                    double heightAdjustment = thisImage.Height / 32;

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
            //writePrefix(prefix, thisImage);
            thisImage = makeOutline(thisImage);
            return thisImage;
        }

        //process shit IN ORDER
        public static int[] spacing(String[] text, int btletters, int btwords, double ScaleFactor, bool smalPre, int width)
        {
            //make the positions array
            int[] positions = new int[text.Length];
            positions[0] = 0;
            int totalLength = 0;

            

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
                        int magicNumbber = imageLetter.Width;

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
                                totalLength += ((int)(magicNumbber * prefixScale) - btletters);
                            } else
                            {
                                positions[i + 1] = positions[i] + ((int)(magicNumbber * ScaleFactor) - btletters);
                                totalLength += ((int)(magicNumbber * ScaleFactor) - btletters);
                            }
                            
                        } else
                        {
                            totalLength += (int)(magicNumbber * ScaleFactor);
                        }
                        
                       
                        imageLetter.Dispose();
                    }
                    catch {  }
                    

                }
                else
                {
                    positions[i+ 1] = positions[i] + (btwords);
                    totalLength += (btwords);
                }
            }
            //Console.WriteLine("");
            //Console.WriteLine(totalLength);

          
            int shiftFactor = (width - totalLength) / 2;

            //Console.WriteLine(shiftFactor);

            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = shiftFactor + positions[i];
            }


            return positions;
        }

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

    }
}
