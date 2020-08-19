using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace mkdd_text_maker
{
    public partial class Color_Editor : Form
    {
        int gradindex = 0;
        int colindex = 0;
        public List<List<Color>> Colors { get; set; }
        public List<List<int>> Positions { get; set; }
        public List<int> Angles { get; set; }
        public int Setting { get; set; } 
        
        public Color_Editor()
        {
           
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

            Setting = 0;

            InitializeComponent();
         
            cmbGrads.SelectedIndex = 0;
            cmbColors.SelectedIndex = 0;         

            picGrad.BackgroundImage = new Bitmap(175, 275);

            txtAngle.Text = tckAngle.Value.ToString();
            txtPos.Text = tckPos.Value.ToString();
        }

        private void Color_Editor_Load(object sender, EventArgs e)
        {
            
            cmbGrads.Items.Clear();
            for(int j = 0; j < Colors.Count; j++)
            {
                cmbGrads.Items.Add("Gradient " + j);
            }
            gradindex = 0;
            cmbGrads.SelectedIndex = 0;
            
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //button stuff

        private void btnColorDialog(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                //get gradient stop collection
                //GradientStopCollection current = Colors[gradindex].colors;

                txt1r.Text = "" + picker.Color.R;
                txt1g.Text = "" + picker.Color.G;
                txt1b.Text = "" + picker.Color.B;

                //get the current color
                //System.Windows.Media.Color newCol = System.Windows.Media.Color.FromArgb(picker.Color.A, picker.Color.R, picker.Color.G, picker.Color.B);

                Color newcol = Color.FromArgb(picker.Color.A, picker.Color.R, picker.Color.G, picker.Color.B);

                Colors[gradindex][colindex] = newcol;

                ///current[colindex].Color = newCol;
           
                //Console.WriteLine(color.R + " " + color.B);
                updateBox();
            }

        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAddGrad_Click(object sender, EventArgs e)
        {
           
            //make a new gradient and make it completely whit
            List<Color> temp = new List<Color>();
            temp.Add(Color.White); temp.Add(Color.White);

            List<int> tempin = new List<int>();
            tempin.Add(0); tempin.Add(100);
            Positions.Add(tempin);

            Colors.Add(temp);
            Angles.Add(90);
            cmbGrads.Items.Add("Gradient " + (cmbGrads.Items.Count));
            cmbGrads.SelectedIndex = cmbGrads.Items.Count - 1;
            gradindex = cmbGrads.Items.Count - 1;

            if(colindex > 1)
            {
                colindex = 0;
                cmbGrads.SelectedIndex = 0;
            }
  
        }
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            Colors[gradindex].Add(Color.White);
            Positions[gradindex].Add(100);
            cmbColors.Items.Add("Color " + (cmbColors.Items.Count));
            cmbColors.SelectedIndex = cmbColors.Items.Count - 1;

            colindex = cmbColors.Items.Count - 1;
        }
        private void btnDeleteGrad_Click(object sender, EventArgs e)
        {
            if (cmbGrads.Items.Count > 1)
            {
                Colors.RemoveAt(gradindex);
                Angles.RemoveAt(gradindex);
                Positions.RemoveAt(gradindex);
                cmbGrads.Items.RemoveAt(gradindex);

                if (gradindex > 0)
                {
                    gradindex = gradindex - 1;
                }

                cmbGrads.SelectedIndex = gradindex;

                for (int i = gradindex; i < cmbGrads.Items.Count; i++)
                {
                    cmbGrads.Items[i] = "Gradient " + i;
                }
            }

        }
        private void btnDelColor_Click(object sender, EventArgs e)
        {
            if (cmbColors.Items.Count > 1)
            {

                Debug.WriteLine("delete button called");
                Debug.WriteLine(colindex);
                if (colindex == Colors[gradindex].Count - 1) {
                    Debug.Write("last one");
                    Positions[gradindex][colindex - 1] = 1;
                    Debug.WriteLine(Positions[gradindex][colindex - 1]);
                }

                if (colindex == 0)
                {
                    Positions[gradindex][0] = 0;
                }
                    

                Colors[gradindex].RemoveAt(colindex);
                Positions[gradindex].RemoveAt(colindex);
                cmbColors.Items.RemoveAt(colindex);

                if (cmbColors.SelectedIndex > 0)
                {
                    cmbColors.SelectedIndex = cmbColors.SelectedIndex - 1;
                }
           

                for (int i = colindex; i < cmbColors.Items.Count; i++)
                {
                    cmbColors.Items[i] = "Color " + i;
                }
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
           for(int j = 0; j < Colors.Count -1; j++)
            {
                List<Color> gradient = Colors[j];
                for (int i = 0; i < gradient.Count - 1; i++)
                {
                    gradient[i] = Color.White;
                }
            }
            updateTextBoxes(sender, e);

        }
        private void btnClearGrad_Click(object sender, EventArgs e)
        {
            /*
            GradientStopCollection collection = Colors[gradindex].colors;
            System.Windows.Media.Color newCol = System.Windows.Media.Color.FromArgb(255, 255, 255, 255);
            for (int i = 0; i < collection.Count - 1; i++)
            {
                collection[i].Color = newCol;
            }
            */

            for(int i = 0; i< Colors[gradindex].Count- 1; i ++)
            {
                Colors[gradindex][i] = Color.White;
            }

            updateTextBoxes(sender, e);

        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(.ToString());
            Color CurrentColor = Colors[gradindex][colindex];
            //Debug.WriteLine(Colors[gradindex].Count);
            for (int i = 0; i< cmbColors.Items.Count- 1; i++)
            {
                Debug.WriteLine(gradindex.ToString() + " " + i.ToString());
                Colors[gradindex][i] = CurrentColor;
            }

            updateTextBoxes(sender, e);
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //text box / ticker stuff

        private void txt1r_TextChanged(object sender, EventArgs e)
        {
            //GradientStop stop = Colors[gradindex].colors[colindex];
            //Console.Write(index);
            if ( int.TryParse(txt1r.Text, out _) && int.TryParse(txt1g.Text, out _) && int.TryParse(txt1b.Text, out _))
            {
                int r = Int32.Parse(txt1r.Text);
                int g = Int32.Parse(txt1g.Text);
                int b = Int32.Parse(txt1b.Text);

                if (r >= 0 && r <= 255 && b >= 0 && b <= 255 && g >= 0 && g <= 255)
                {
                    Colors[gradindex][colindex] = Color.FromArgb(255, (byte)r, (byte)g, (byte)b);
                    updateBox();
                }
            }
           
        }

        private void updateTextBoxes(object sender, EventArgs e)
        {
            Color newColor = Colors[gradindex][colindex];
            txt1r.Text = newColor.R.ToString();
            txt1b.Text = newColor.B.ToString();
            txt1g.Text = newColor.G.ToString();
            updateBox();
        }

        private void tckPos_ValueChanged(object sender, EventArgs e)
        {
            if(colindex == 0)
            {
                txtPos.Text = "0";
            }
            if(colindex == Colors[gradindex].Count - 1)
            {
                txtPos.Text = "100";
            }
  
            Positions[gradindex][colindex] = tckPos.Value;
            txtPos.Text = tckPos.Value.ToString();
            updateBox();
        }

        private void tckAngle_ValueChanged(object sender, EventArgs e)
        {
            Angles[gradindex] = tckAngle.Value;
            txtAngle.Text = tckAngle.Value.ToString();
            updateBox();
        }

        private void txtPos_TextChanged(object sender, EventArgs e)
        {
            if(colindex == 0)
            {
                tckPos.Value = 0;
            }
            if (colindex == Colors[gradindex].Count - 1)
            {
                tckPos.Value = 100;
            }
            if (int.TryParse(txtPos.Text, out _))
            {
                int pos = Int32.Parse(txtPos.Text);
                if (pos >= 0 && pos <= 100)
                {
                    Positions[gradindex][colindex] = pos;
                    tckPos.Value = pos;
                    updateBox();
                }   
            }
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAngle.Text, out _))
            {
                int pos = Int32.Parse(txtAngle.Text);
                if(pos >= tckAngle.Minimum && pos <= tckAngle.Maximum)
                {
                    Angles[gradindex] = tckAngle.Value;
                    tckAngle.Value = pos;
                    updateBox();
                }
            }
                 
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~`
        //other stuff stuff

        private void cmbGrads_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            gradindex = cmbGrads.SelectedIndex;
            colindex = 0;
            //Console.WriteLine("" + cmbColors.SelectedIndex + " " + colindex);
           

            cmbColors.Items.Clear();
            for(int i = 0; i < Colors[gradindex].Count; i++)
            {
                cmbColors.Items.Add("Color " + i);
            }
            
            
            if(cmbColors.SelectedIndex > Colors[gradindex].Count - 1)
            {
                colindex = 0;
                cmbColors.SelectedIndex = 0;
                
            }

            tckAngle.Value = Angles[gradindex];
            tckPos.Value = Positions[gradindex][colindex];

            updateTextBoxes(sender, e);

            
       
        }

        private void cmbColorChange(object sender, EventArgs e)
        {
            colindex = cmbColors.SelectedIndex;
            tckAngle.Value = Angles[gradindex];
            tckPos.Value = Positions[gradindex][colindex];
            updateTextBoxes(sender, e);

            
        }

        private void updateBox()
        {
            List<float> ConvertedPositions = new List<float>();
            foreach(int position in Positions[gradindex]){
                ConvertedPositions.Add((float)(position / 100.00));
            }
            picGrad.Image = Gradient.getGradientBox(picGrad.Width, picGrad.Height, Colors[gradindex], ConvertedPositions, Angles[gradindex]);
            
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //"by" stuff
        private void radByLetter_CheckedChanged(object sender, EventArgs e)
        {
            Setting = 0;
        }

        private void radByImage_CheckedChanged(object sender, EventArgs e)
        {
            Setting = 2;
        }

        
    }

}
