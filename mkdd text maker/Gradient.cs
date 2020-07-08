using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mkdd_text_maker
{
    public class Gradient
    {
        public List<List<Color>> Colors { get; set; }
        public List<List<int>> Positions { get; set; }
        public List<int> Angles { get; set; }
        public int BySetting { get; set; }

        public Gradient(List<List<Color>> colors, List<List<int>> positions, List<int> angles, int setting)
        {
            Colors = colors;
            Positions = positions;
            Angles = angles;
            BySetting = setting;
        }

        public Gradient(bool asdf)
        {
            //create one gradient that is white
            Colors = new List<List<Color>>();
            Positions = new List<List<int>>();
            Angles = new List<int>();

            List<Color> temp = new List<Color>();
            temp.Add(Color.White); temp.Add(Color.White);
            Colors.Add(temp);

            List<int> tempin = new List<int>();
            tempin.Add(0); tempin.Add(100);
            Positions.Add(tempin);
            Angles.Add(90);

            BySetting = 0;
        }

        public Gradient()
        {
        }

        public static Bitmap getGradientBox(int width, int height, List<Color> Colors, List<float> Positions, int angle)
        {
            //make the stops
            ColorBlend cb = new ColorBlend(Colors.Count);
            cb.Colors = Colors.ToArray();
            cb.Positions = Positions.ToArray();
            cb.Positions = Positions.ToArray();
            
            Bitmap baseGrad = new Bitmap(width, height);
            LinearGradientBrush linGrBrush = new LinearGradientBrush(new Rectangle(0, 0, width, height), Color.Black, Color.Black, angle);
            linGrBrush.InterpolationColors = cb;
            
            Graphics graphics = Graphics.FromImage(baseGrad);
            
            graphics.FillRectangle(linGrBrush, new Rectangle(0, 0, width, height));
           
          
            return baseGrad;
        }
    }
}
