using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkdd_text_maker
{
    public partial class Color_Editor : Form
    {
        int index = 0;
        List<Color[]> colors;
        public Color_Editor()
        {
            colors = new List<Color[]>();
            Color[] temp = { Color.White, Color.White };
            colors.Add(temp);

            InitializeComponent();
            cmbGrads.SelectedIndex = 0;
            picGrad.Image = new Bitmap(175, 275);
        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                txt1r.Text = "" + picker.Color.R;
                txt1g.Text = "" + picker.Color.G;
                txt1b.Text = "" + picker.Color.B;
                Color[] gradient = colors[index];
                gradient[0] = picker.Color;
                //Console.WriteLine(color.R + " " + color.B);
                updateBox(index);
            }

        }

        private void btnCtwo_Click(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                txt2r.Text = "" + picker.Color.R;
                txt2g.Text = "" + picker.Color.G;
                txt2b.Text = "" + picker.Color.B;
                Color[] gradient = colors[index];
                gradient[1] = picker.Color;
                //Console.WriteLine(color.R + " " + color.B);
                updateBox(index);
            }
        }

        public List<Color[]> GetColors()
        {
            return colors;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        public static Color gradCalc(Color c1, Color c2, double x, double y)
        {
            int r = (int)(y * c1.R + (1 - y) * c2.R);
            int g = (int)(y * c1.G + (1 - y) * c2.G);
            int b = (int)(y * c1.B + (1 - y) * c2.B);

            
            r = (int)(r *x);
            g = (int)(g * x);
            b = (int)(b* x);
            

            return Color.FromArgb(255, r, g, b);
        }

        private void txt1r_TextChanged(object sender, EventArgs e)
        {
            Color[] gradient = colors[index];
            Console.Write(index);
            int r = Int32.Parse(txt1r.Text);
            int g = Int32.Parse(txt1g.Text);
            int b = Int32.Parse(txt1b.Text);
            
            if (r >= 0 && r <= 255 && b >= 0 && b <= 255 && g >= 0 && g <= 255)
            {
                gradient[0] = Color.FromArgb(255, r, g, b);
                updateBox(index);
            }
        }

        private void txt2b_TextChanged(object sender, EventArgs e)
        {
            Color[] gradient = colors[index];
            int r = Int32.Parse(txt2r.Text);
            int g = Int32.Parse(txt2g.Text);
            int b = Int32.Parse(txt2b.Text);
            if (r >= 0 && r <= 255 && b >= 0 && b <= 255 && g >= 0 && g <= 255)
            {
                gradient[1] = Color.FromArgb(255, r, g, b);
                updateBox(index);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Color[] temp = { Color.White, Color.White };
            colors.Add(temp);
            cmbGrads.Items.Add("Gradient " + (cmbGrads.Items.Count));
            cmbGrads.SelectedIndex = cmbGrads.Items.Count - 1;
            
            index = cmbGrads.Items.Count - 1;

        }

        private void cmbGrads_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cmbGrads.SelectedIndex;

            Color[] gradient = colors[index];
            txt1r.Text = "" + gradient[0].R;
            txt1g.Text = "" + gradient[0].G;
            txt1b.Text = "" + gradient[0].B;

            txt2r.Text = "" + gradient[1].R;
            txt2g.Text = "" + gradient[1].G;
            txt2b.Text = "" + gradient[1].B;

            updateBox(index);

        }

        private void updateBox(int index)
        {
            Color[] gradient = colors[index];
            Image preview = new Bitmap(175, 275);

            for(int i = 0; i < 175; i++)
            {
                for(int j = 0; j < 275; j++)
                {
                    Color pixel = Color_Editor.gradCalc(gradient[0], gradient[1], 1, 1- j/275.00);
                    ((Bitmap)preview).SetPixel(i, j, pixel);
                }
            }
            picGrad.Image = preview;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(cmbGrads.Items.Count > 0)
            {
                colors.RemoveAt(index);
                cmbGrads.Items.RemoveAt(index);

                if(index > 0)
                {
                    index = index - 1;
                }
                
                cmbGrads.SelectedIndex = index;

                for(int i = index; i < cmbGrads.Items.Count; i++)
                {
                    cmbGrads.Items[i] = "Gradient " + i;
                }
            }
            
        }
    }

   
}
