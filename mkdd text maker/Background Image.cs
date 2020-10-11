using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkdd_text_maker
{
    public partial class Background_Image : Form
    {
        public String Filepath;
        public Image SelectedImage { get; set; }
        public Image FinalImage { get; set; }
        public int OtherAlpha;


        public Background_Image()
        {
            InitializeComponent();
        }

        public Background_Image(int width, int height, double scale)
        {
            

            InitializeComponent();

            FinalImage = new Bitmap(width, height);

            picPreview.Width = (int)(width * scale);
            picPreview.Height = (int)(height * scale);
            OtherAlpha = 0;
        }

        private void loadNewImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenImage.ShowDialog() == DialogResult.OK)
            {
                SelectedImage = new Bitmap(OpenImage.FileName);
                FinalImage = new Bitmap(OpenImage.FileName);
                picPreview.Image = SelectedImage;

                menuReload.Enabled = true;
            }
            
        }

        private void menuReload_Click(object sender, EventArgs e)
        {
            picPreview.Image = new Bitmap(OpenImage.FileName);
            FinalImage = new Bitmap(OpenImage.FileName);
        }

        private void tckHScale_Scroll(object sender, EventArgs e)
        {
            lblHScaleVal.Text = tckHScale.Value.ToString();
        }

        private void tckVScale_Scroll(object sender, EventArgs e)
        {
            lblVScaleVal.Text = tckVScale.Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
