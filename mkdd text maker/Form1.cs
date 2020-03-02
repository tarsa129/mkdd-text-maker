using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace mkdd_text_maker
{
    public partial class Form1 : Form
    {
        static int width;
        static int height;
        static double scale;

        static int alignment = 2;
        public Form1()
        {
            InitializeComponent();
            width = 256;
            height = 32;

           

            Console.WriteLine("Load Width:" + picText.Size.Width.ToString());

            int DispWidth = picText.Size.Width;
            scale = (double)DispWidth / (double)width;
            
            //Console.WriteLine("Load Height:" + picText.Size.Height.ToString());
            Console.WriteLine(scale.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLetterVal.Text = tckLetter.Value.ToString();
            lblWordValue.Text = tckWords.Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
       
            picText.BackgroundImage = new Bitmap(width, height);

            String text = txtInput.Text;
            text.Trim();

            if (!String.IsNullOrWhiteSpace(text) && !String.IsNullOrEmpty(text))
            {
                SavePNG.Enabled = true;
                SaveBTI.Enabled = true;
                SaveAsPNG.Enabled = true;
                SaveAsBTI.Enabled = true;

                Image thisImage = picText.BackgroundImage;
                WriteInfo Info = new WriteInfo(text, thisImage, tckLetter.Value, tckWords.Value, comboBox1.Text.ToLower(), (double)tckSqueeze.Value / 100, chkboxPrefix.Checked, alignment);
                thisImage = myImage.writeLetters(Info);
                picText.BackgroundImage = thisImage;
            } else
            {
                SavePNG.Enabled = false;
                SaveBTI.Enabled = false;
                SaveAsPNG.Enabled = false;
                SaveAsBTI.Enabled = false;
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TckLetter_Scroll(object sender, EventArgs e)
        {
            lblLetterVal.Text = tckLetter.Value.ToString();
        }

        private void TckWords_Scroll(object sender, EventArgs e)
        {
            lblWordValue.Text = tckWords.Value.ToString();
        }

        private void SavepngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image toSave = picText.BackgroundImage;
            toSave.Save(txtInput.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void SaveAspngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            saveFileDialogPNG.FileName = txtInput.Text + ".png";
            saveFileDialogPNG.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialogPNG.OpenFile();
            Image toSave = picText.BackgroundImage;
            toSave.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Close();

        }

        private void Wimgt(String text)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "wimgt.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "convert " + text + ".png -d " + text + ".bti";
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }

        private void saveAsbtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image toSave = picText.BackgroundImage;

            bool ToDelete = File.Exists(txtInput.Text + ".png");

            toSave.Save(txtInput.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

            Wimgt(txtInput.Text);

            if (!ToDelete)
            {
                File.Delete(txtInput.Text + ".png");
            }

        }

        private void SaveAsBTI_Click(object sender, EventArgs e)
        {
            saveFileDialogBTI.FileName = txtInput.Text + ".bti";
            saveFileDialogBTI.ShowDialog();
            FileStream fs = (FileStream)saveFileDialogBTI.OpenFile();

            Image toSave = picText.BackgroundImage;
            toSave.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            
            bool ToDelete = File.Exists(saveFileDialogBTI.FileName);

            Wimgt(saveFileDialogBTI.FileName);

            if (!ToDelete)
            {
                File.Delete(txtInput.Text + ".png");
            }

            fs.Close();
        }

        private void tckSqueeze_Scroll(object sender, EventArgs e)
        {
            lblShowSqueeze.Text = tckSqueeze.Value.ToString();
        }

        private void updateImageBox()
        {
            picText.BackgroundImage = new Bitmap(width, height);
            picText.Size = new Size((int)(width * scale), (int)(height * scale));
            //Console.WriteLine("Height: " + height.ToString());
           // Console.WriteLine("Width: " + width.ToString());
        }

        private void courseName256X32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 256;
            height = 32;
            updateImageBox();  
        }

        private void characterName152X32ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            width = 152;
            height = 32;

            updateImageBox();
     
        }

        private void customSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form size = new Form();

            size.Text = "Change Image Size";

            Label lblWidth = new Label();
            lblWidth.Text = "New Width:";
            lblWidth.Location = new Point(0, 0);

            
            Label lblHeight = new Label();
            lblHeight.Text = "New Height:";
            lblHeight.Location = new Point(0, 25);
            

            TextBox txtWidth = new TextBox();
            txtWidth.Text = width.ToString();
            txtWidth.Location = new Point(100, 0);
            TextBox txtHeight = new TextBox();
            txtHeight.Text = height.ToString();
            txtHeight.Location = new Point(100, 25);
            
            size.Controls.Add(lblWidth);
            size.Controls.Add(lblHeight);
            size.Controls.Add(txtWidth);
            size.Controls.Add(txtHeight);

            size.ShowDialog();

            Int32.TryParse(txtWidth.Text, out width);
            Int32.TryParse(txtHeight.Text, out height);

            updateImageBox(); 

            //Console.WriteLine(width.ToString());
            

        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alignment = 0;
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alignment = 2;
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alignment = 1;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Button1_Click(btnConvert, EventArgs.Empty);
            }
        }
    }
}
