using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mkdd_text_maker
{
    public partial class Main_Form : Form
    {
        static public int width;
        static public int height;
        static public double scale;
        static public WriteInfo Information;
 
        static Color_Editor Gradients;
        static Color_Editor Outline;
        static Image BaseImage;
        public Main_Form()
        {

            Gradients = new Color_Editor(true);
            Outline = new Color_Editor(false);
 
            width = 256;
            height = 32;

            InitializeComponent();
            Information = new WriteInfo(null, null, tckLetter.Value, tckWords.Value, cmbPrefix.Text.ToLower(), (double)tckSqueeze.Value / 100, chkboxPrefix.Checked, 2, false, chkColor.Checked, (double)tckVertical.Value / 100);


            //get scale factor for display
            int DispWidth = picText.Size.Width;
            scale = (double)DispWidth / (double)width;

            BaseImage = new Bitmap(width, height);
            for ( int i = 0; i < width; i ++)
            {
                for( int j = 0; j < height; j ++)
                {
                    ((Bitmap)BaseImage).SetPixel(i, j, Color.FromArgb(0, 255, 255, 255) );
                }
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLetterVal.Text = tckLetter.Value.ToString();
            lblWordValue.Text = tckWords.Value.ToString();
        }

        private void UpdateText(object sender, EventArgs e)
        {
       
            picText.BackgroundImage = new Bitmap(width, height);

            String text = txtInput.Text;
            text = text.Trim();
            //txtInput.Text = text;

            if (!String.IsNullOrWhiteSpace(text) && !String.IsNullOrEmpty(text))
            {
                //if there is valid text, allow saving
                SavePNG.Enabled = true;
                SaveBTI.Enabled = true;
                SaveAsPNG.Enabled = true;
                SaveAsBTI.Enabled = true;

                //call the writing method
                Image thisImage = picText.BackgroundImage;
                
                Information.text = text;
                Information.image = thisImage;
                thisImage = myImage.writeLetters(Information, Gradients, Outline, BaseImage);
                picText.BackgroundImage = thisImage;
                if (Information.auto)
                {
                    width = thisImage.Width;
                    picText.Size = new Size((int)(width * scale), (int)(height * scale));
                }
            } else
            {
                //if the text is not valid, don't allow saving
                SavePNG.Enabled = false;
                SaveBTI.Enabled = false;
                SaveAsPNG.Enabled = false;
                SaveAsBTI.Enabled = false;
            }
    
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //options stuff

        private void TckLetter_Scroll(object sender, EventArgs e)
        {
            lblLetterVal.Text = tckLetter.Value.ToString();
            Information.LetterSpacing = tckLetter.Value;
        }

        private void TckWords_Scroll(object sender, EventArgs e)
        {
            lblWordValue.Text = tckWords.Value.ToString();
            Information.WordSpacing = tckWords.Value;
        }

        private void tckSqueeze_Scroll(object sender, EventArgs e)
        {
            lblShowSqueeze.Text = tckSqueeze.Value.ToString();
            Information.SqueezeFactor = tckSqueeze.Value / 100.00;
        }

        private void tckVertical_Scroll(object sender, EventArgs e)
        {
            lblVertiVal.Text = tckVertical.Value.ToString();
            Information.VertiFactor = tckVertical.Value / 100.00;
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //saving stuff

        private void SavepngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] name = txtInput.Text.ToCharArray().Select(c => c.ToString()).ToArray();
            name = specialCharacters(name);
            String savename = String.Join("", name);


            Image toSave = picText.BackgroundImage;
            toSave.Save(savename + ".png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void SaveAspngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] name = txtInput.Text.ToCharArray().Select(c => c.ToString()).ToArray();
            name = specialCharacters(name);
            String savename = String.Join("", name);

            saveFileDialogPNG.FileName = savename + ".png";
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

            if (chkColor.Checked)
            {
                startInfo.Arguments = "convert \"" + text + ".png\" -d \"" + text + ".bti\" -x BTI.CMPR --n-mm=0";
            }
            else
            {
                startInfo.Arguments = "convert \"" + text + ".png\" -d \"" + text + ".bti\" -x BTI.IA4 --n-mm=0";
            }

            
           
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();

                }
                using (Stream stream = File.Open(text + ".bti", FileMode.Open))
                {
                    stream.Position = 6;
                    byte[] data = { 0, 0, 0, 0 };
                    stream.Write(data, 0, data.Length);
                }
            }
            catch
            {
                // Log error.
            }
        }

        private void saveAsbtiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String[] name = txtInput.Text.ToCharArray().Select(c => c.ToString()).ToArray();
            name = specialCharacters(name);
            String savename = String.Join("", name);

            Image toSave = picText.BackgroundImage;

            //if there is a .png file already, don't delete it
            bool ToDelete = File.Exists(savename + ".png");

            //don't wanna overwrite an existing .png file
            toSave.Save(savename+ ".png", System.Drawing.Imaging.ImageFormat.Png);

            Wimgt(savename);

            if (!ToDelete)
            {
                File.Delete(savename + ".png");
            }

        }

        private void SaveAsBTI_Click(object sender, EventArgs e)
        {

            String[] name = txtInput.Text.ToCharArray().Select(c => c.ToString()).ToArray();
            name = specialCharacters(name);
            String savename = String.Join("", name);

            saveFileDialogBTI.FileName = savename + ".bti";
            saveFileDialogBTI.ShowDialog();

            String rando = "42t98ga";
            String intendedName = saveFileDialogBTI.FileName.Substring(0, saveFileDialogBTI.FileName.Length - 4);
            saveFileDialogBTI.FileName = intendedName + rando + ".png";
           

            Console.WriteLine(saveFileDialogBTI.FileName);


            FileStream fs = (FileStream)saveFileDialogBTI.OpenFile();

            Image toSave = picText.BackgroundImage;
            toSave.Save(fs, System.Drawing.Imaging.ImageFormat.Png);

            fs.Close();

            File.Delete(intendedName + rando + ".bti");
            File.Delete(intendedName + ".bti");

            Console.WriteLine(intendedName + rando);


            Wimgt(intendedName + rando);

            System.IO.File.Move(intendedName + rando + ".bti", intendedName + ".bti");


            File.Delete(intendedName + rando + ".png");     
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //image size

        public void updateImageBox()
        {
            Information.auto = false;
            picText.BackgroundImage = new Bitmap(width, height);
            picText.Size = new Size((int)(width * scale), (int)(height * scale));
            UpdateText(null, null);
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
            //create form with text boxes.
            Form size = new Form();

            size.Size = new Size(250, 100);

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

        private void autoSize(object sender, EventArgs e)
        {
            Information.auto = true;
            UpdateText(null, null);
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //alignment shit
        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information.align = 0;
            UpdateText(sender, e);
        }

        private void centerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information.align = 2;
            UpdateText(sender, e);
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information.align = 1;
            UpdateText(sender, e);
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //extra stuff

        private void picText_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetImage(picText.BackgroundImage);
        }

        public static String[] specialCharacters(String[] letters)
        {
            for(int i = 0; i < letters.Length; i++)
            {
                switch (letters[i])
                {   
                    case ":":
                        letters[i] = "colon";
                        break;
                    case ".":
                        letters[i] = "period";
                        break;
                    case "?":
                        letters[i] = "ques";
                        break;
                    case "/":
                        letters[i] = "slash";
                        break;
                    case "\"":
                        letters[i] = "''";
                        break;
                    case "<":
                        letters[i] = "lessthan";
                        break;

                }
                
            }
            return letters;
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //color
        private void mniiTextSingle_Click(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                Color PickedColor = picker.Color;

                List<List<Color>> Colors = new List<List<Color>>();
                List<List<int>> Positions = new List<List<int>>();
                List<int> Angles = new List<int>();

                List<Color> temp = new List<Color>();
                temp.Add(PickedColor); temp.Add(PickedColor);
                Colors.Add(temp);

                List<int> tempin = new List<int>();
                tempin.Add(0); tempin.Add(100);
                Positions.Add(tempin);
                Angles.Add(90);

                Gradients = new Color_Editor(Colors, Positions, Angles, 0);

                chkColor.Checked = true;
            }
        }
        private void GradientText_Click(object sender, EventArgs e)
        {
            Gradients.ShowDialog();
            chkColor.Checked = true;
        }
        private void OutlineSingle_Clicked(object sender, EventArgs e)
        {
            ColorDialog picker = new ColorDialog();
            if (picker.ShowDialog() == DialogResult.OK)
            {
                Color PickedColor = picker.Color;

                List<List<Color>> Colors = new List<List<Color>>();
                List<List<int>> Positions = new List<List<int>>();
                List<int> Angles = new List<int>();

                List<Color> temp = new List<Color>();
                temp.Add(PickedColor); temp.Add(PickedColor);
                Colors.Add(temp);

                List<int> tempin = new List<int>();
                tempin.Add(0); tempin.Add(100);
                Positions.Add(tempin);
                Angles.Add(90);

                Outline = new Color_Editor(Colors, Positions, Angles, 0);

                chkColor.Checked = true;
            }
        }
        private void OutlineGradient_Clicked(object sender, EventArgs e)
        {
            Outline.ShowDialog();
            chkColor.Checked = true;
        }
        private void loadGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentxt = new OpenFileDialog();
            opentxt.Filter = "json files(*.json)| *.json";
            opentxt.RestoreDirectory = true;
            if (opentxt.ShowDialog() == DialogResult.OK)
            {
                JsonInfo jsoninfo = new JsonInfo();


                jsoninfo = JsonConvert.DeserializeObject<JsonInfo>(File.ReadAllText(opentxt.FileName));
                Console.WriteLine("at lest you got here");

                Gradients.Colors = jsoninfo.Colors;
                Gradients.Positions = jsoninfo.Positions;
                Gradients.Angles = jsoninfo.Angles;
                Gradients.Setting = jsoninfo.Setting;

                chkColor.Checked = true;
            }
        }
        private void saveGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveSetting = new SaveFileDialog();
            SaveSetting.Filter = "json files(*.json)| *.json";
            SaveSetting.RestoreDirectory = true;
            SaveSetting.FileName = @"\settings\gradient.json";
            if (SaveSetting.ShowDialog() == DialogResult.OK)
            {
                JsonInfo jsoninfo = new JsonInfo(Gradients.Colors, Gradients.Positions, Gradients.Angles, Gradients.Setting);
                String json = JsonConvert.SerializeObject(jsoninfo, Formatting.Indented);

                //Console.WriteLine(json);

                using (StreamWriter file = File.CreateText(SaveSetting.FileName))
                {
                    file.Write(json );
                    file.Close();
                }

            }
        }

        private class JsonInfo
        {
            public List<List<Color>> Colors { get; set; }
            public List<List<int>> Positions { get; set; }
            public List<int> Angles { get; set; }
            public int Setting { get; set; }

            public JsonInfo(List<List<Color>> colors, List<List<int>> positions, List<int> angles, int setting)
            {
                Colors = colors;
                Positions = positions;
                Angles = angles;
                Setting = setting;
            }

            public JsonInfo()
            {

            }

        }

        private void backgroundImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Background_Image bgImage = new Background_Image( width, height, scale );
            bgImage.ShowDialog();
            BaseImage = bgImage.FinalImage;
        }
        private void clearImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    ((Bitmap)BaseImage).SetPixel(i, j, Color.FromArgb(0, 255, 255, 255));
                }
            }
        }


        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //loading stuff

        private void loadText_Click(object sender, EventArgs e)
        {
            OpenFileDialog opentxt = new OpenFileDialog();
            opentxt.Filter = "txt files(*.txt)| *.txt";
            opentxt.RestoreDirectory = true;
            if(opentxt.ShowDialog() == DialogResult.OK)
            {
                String filePath = opentxt.FileName;

                String[] lines = System.IO.File.ReadAllLines(filePath);

                Console.WriteLine(filePath);
                String path = filePath.Substring(0, filePath.LastIndexOf("\\"));

                foreach (String line in lines)
                {
                    Console.WriteLine(line);
                    
                    //making the image
                    Image thisImage = new Bitmap(256, 32);
                    //WriteInfo Info = new WriteInfo(line, thisImage, tckLetter.Value, tckWords.Value, cmbPrefix.Text.ToLower(), (double)tckSqueeze.Value / 100, chkboxPrefix.Checked, alignment, autosize, chkColor.Checked);
                    Information.text = line;
                    Information.image = thisImage;
                    Image currentImage = myImage.writeLetters(Information, Gradients, Outline, BaseImage);


                    String[] name = line.ToCharArray().Select(c => c.ToString()).ToArray();
                    name = specialCharacters(name);
                    String savename = String.Join("", name);


                    Image toSave = currentImage;
                    toSave.Save(path +  "\\" +  savename + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }

            }
        }

        private void SaveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveSetting = new SaveFileDialog();
            SaveSetting.Filter = "json files(*.json)| *.json";
            SaveSetting.RestoreDirectory = true;
            SaveSetting.FileName = @"\settings\settings.json";
            if( SaveSetting.ShowDialog() == DialogResult.OK)
            {
                //Console.WriteLine(SaveSetting.FileName);

              // WriteInfo info = new WriteInfo(null, null, tckLetter.Value, tckWords.Value, cmbPrefix.Text.ToLower(),
                    //(double)tckSqueeze.Value / 100, chkboxPrefix.Checked, alignment, autosize, chkColor.Checked);
                String json = JsonConvert.SerializeObject(Information, Formatting.Indented);
                //Console.WriteLine(json);

                
                using (StreamWriter file = File.CreateText(SaveSetting.FileName))
                {
                    file.Write(json);
                    file.Close();
                }
                
               
            }
     
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            OpenFileDialog opentxt = new OpenFileDialog();
            opentxt.Filter = "json files(*.json)| *.json";
            opentxt.RestoreDirectory = true;
            if (opentxt.ShowDialog() == DialogResult.OK)
            {
                WriteInfo info = JsonConvert.DeserializeObject<WriteInfo>(File.ReadAllText(opentxt.FileName));
                Information = info;

                //update the gui
                cmbPrefix.SelectedItem = Information.Prefix;
                chkColor.Checked = Information.HasColor;
                chkboxPrefix.Checked = Information.PrefixSmall;
                tckLetter.Value = Information.LetterSpacing;
                tckSqueeze.Value = (int)(Information.SqueezeFactor * 100);
                tckWords.Value = Information.WordSpacing;

            }
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        //information stuff

        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            Information.HasColor = chkColor.Checked;
        }

        private void chkboxPrefix_CheckedChanged(object sender, EventArgs e)
        {
            Information.PrefixSmall = chkboxPrefix.Checked;
        }

        private void cmbPrefix_SelectedIndexChanged(object sender, EventArgs e)
        {
            Information.Prefix = cmbPrefix.SelectedItem.ToString();
            Debug.WriteLine(Information.Prefix);
            UpdateText(sender, e);
            
        }
    }
}
