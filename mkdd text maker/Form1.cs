using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace mkdd_text_maker
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLetterVal.Text = tckLetter.Value.ToString();
            lblWordValue.Text = tckWords.Value.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String name = "blank.png";
            String fileToRead = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\" + name;

            picText.BackgroundImage = new Bitmap(fileToRead);
            String text = txtInput.Text;
            text.Trim();

            if (!String.IsNullOrWhiteSpace(text) && !String.IsNullOrEmpty(text))
            {
                SavePNG.Enabled = true;
                SaveBTI.Enabled = true;
                SaveAsPNG.Enabled = true;
                SaveAsBTI.Enabled = true;

                Image thisImage = picText.BackgroundImage;
                thisImage = myImage.writeLetters(text, thisImage, tckLetter.Value, tckWords.Value, comboBox1.Text.ToLower());
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
    }
}
