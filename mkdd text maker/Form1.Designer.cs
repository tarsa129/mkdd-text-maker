namespace mkdd_text_maker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePNG = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsPNG = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBTI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsBTI = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.tckLetter = new System.Windows.Forms.TrackBar();
            this.lblLetters = new System.Windows.Forms.Label();
            this.picText = new System.Windows.Forms.PictureBox();
            this.lblWords = new System.Windows.Forms.Label();
            this.tckWords = new System.Windows.Forms.TrackBar();
            this.lblLetterVal = new System.Windows.Forms.Label();
            this.lblWordValue = new System.Windows.Forms.Label();
            this.saveFileDialogPNG = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialogBTI = new System.Windows.Forms.SaveFileDialog();
            this.chkboxSqueeze = new System.Windows.Forms.CheckBox();
            this.chkboxPrefix = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckWords)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePNG,
            this.SaveAsPNG,
            this.SaveBTI,
            this.SaveAsBTI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SavePNG
            // 
            this.SavePNG.Enabled = false;
            this.SavePNG.Name = "SavePNG";
            this.SavePNG.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SavePNG.Size = new System.Drawing.Size(530, 54);
            this.SavePNG.Text = "Save .png";
            this.SavePNG.Click += new System.EventHandler(this.SavepngToolStripMenuItem_Click);
            // 
            // SaveAsPNG
            // 
            this.SaveAsPNG.Enabled = false;
            this.SaveAsPNG.Name = "SaveAsPNG";
            this.SaveAsPNG.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsPNG.Size = new System.Drawing.Size(530, 54);
            this.SaveAsPNG.Text = "Save as .png";
            this.SaveAsPNG.Click += new System.EventHandler(this.SaveAspngToolStripMenuItem_Click);
            // 
            // SaveBTI
            // 
            this.SaveBTI.Enabled = false;
            this.SaveBTI.Name = "SaveBTI";
            this.SaveBTI.Size = new System.Drawing.Size(530, 54);
            this.SaveBTI.Text = "Save .bti";
            this.SaveBTI.Click += new System.EventHandler(this.saveAsbtiToolStripMenuItem_Click);
            // 
            // SaveAsBTI
            // 
            this.SaveAsBTI.Enabled = false;
            this.SaveAsBTI.Name = "SaveAsBTI";
            this.SaveAsBTI.Size = new System.Drawing.Size(530, 54);
            this.SaveAsBTI.Text = "Save as. bti";
            this.SaveAsBTI.Click += new System.EventHandler(this.SaveAsBTI_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(1011, 344);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(311, 114);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Make Text";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(524, 67);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(397, 38);
            this.txtInput.TabIndex = 2;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(297, 73);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(221, 32);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Enter Text Here:";
            // 
            // tckLetter
            // 
            this.tckLetter.LargeChange = 3;
            this.tckLetter.Location = new System.Drawing.Point(346, 341);
            this.tckLetter.Maximum = 15;
            this.tckLetter.Name = "tckLetter";
            this.tckLetter.Size = new System.Drawing.Size(548, 114);
            this.tckLetter.TabIndex = 4;
            this.tckLetter.Value = 5;
            this.tckLetter.Scroll += new System.EventHandler(this.TckLetter_Scroll);
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(36, 341);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(323, 32);
            this.lblLetters.TabIndex = 5;
            this.lblLetters.Text = "Overlap between letters:";
            this.lblLetters.Click += new System.EventHandler(this.Label1_Click);
            // 
            // picText
            // 
            this.picText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picText.BackgroundImage")));
            this.picText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picText.Location = new System.Drawing.Point(42, 147);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(1280, 160);
            this.picText.TabIndex = 6;
            this.picText.TabStop = false;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(36, 426);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(301, 32);
            this.lblWords.TabIndex = 8;
            this.lblWords.Text = "Space between words:";
            // 
            // tckWords
            // 
            this.tckWords.LargeChange = 1;
            this.tckWords.Location = new System.Drawing.Point(346, 426);
            this.tckWords.Maximum = 20;
            this.tckWords.Minimum = 1;
            this.tckWords.Name = "tckWords";
            this.tckWords.Size = new System.Drawing.Size(548, 114);
            this.tckWords.TabIndex = 7;
            this.tckWords.Value = 10;
            this.tckWords.Scroll += new System.EventHandler(this.TckWords_Scroll);
            // 
            // lblLetterVal
            // 
            this.lblLetterVal.AutoSize = true;
            this.lblLetterVal.Location = new System.Drawing.Point(932, 341);
            this.lblLetterVal.Name = "lblLetterVal";
            this.lblLetterVal.Size = new System.Drawing.Size(31, 32);
            this.lblLetterVal.TabIndex = 9;
            this.lblLetterVal.Text = "5";
            // 
            // lblWordValue
            // 
            this.lblWordValue.AutoSize = true;
            this.lblWordValue.Location = new System.Drawing.Point(932, 449);
            this.lblWordValue.Name = "lblWordValue";
            this.lblWordValue.Size = new System.Drawing.Size(47, 32);
            this.lblWordValue.TabIndex = 10;
            this.lblWordValue.Text = "10";
            // 
            // saveFileDialogPNG
            // 
            this.saveFileDialogPNG.Filter = "\".png file\"|*.png";
            this.saveFileDialogPNG.Title = "Save image as";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "GBA",
            "3DS",
            "ACD",
            "DS",
            "MBL",
            "Tour",
            "N64",
            "64",
            "PSX",
            "PS1",
            "PS",
            "PS4",
            "SNES",
            "SFC",
            "Wii",
            "WiiU",
            "XBX"});
            this.comboBox1.Location = new System.Drawing.Point(138, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 39);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "None";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Prefix:";
            // 
            // saveFileDialogBTI
            // 
            this.saveFileDialogBTI.Filter = "\".bti file\"|*.bti";
            this.saveFileDialogBTI.Title = "Save image as";
            // 
            // chkboxSqueeze
            // 
            this.chkboxSqueeze.AutoSize = true;
            this.chkboxSqueeze.Location = new System.Drawing.Point(42, 503);
            this.chkboxSqueeze.Name = "chkboxSqueeze";
            this.chkboxSqueeze.Size = new System.Drawing.Size(417, 36);
            this.chkboxSqueeze.TabIndex = 13;
            this.chkboxSqueeze.Text = "Squeeze Letters Horizontally";
            this.chkboxSqueeze.UseVisualStyleBackColor = true;
            // 
            // chkboxPrefix
            // 
            this.chkboxPrefix.AutoSize = true;
            this.chkboxPrefix.Location = new System.Drawing.Point(484, 503);
            this.chkboxPrefix.Name = "chkboxPrefix";
            this.chkboxPrefix.Size = new System.Drawing.Size(230, 36);
            this.chkboxPrefix.TabIndex = 14;
            this.chkboxPrefix.Text = "Smaller Prefix";
            this.chkboxPrefix.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 567);
            this.Controls.Add(this.chkboxPrefix);
            this.Controls.Add(this.chkboxSqueeze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblWordValue);
            this.Controls.Add(this.lblLetterVal);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.tckWords);
            this.Controls.Add(this.picText);
            this.Controls.Add(this.lblLetters);
            this.Controls.Add(this.tckLetter);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MKDD Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePNG;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TrackBar tckLetter;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.PictureBox picText;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.TrackBar tckWords;
        private System.Windows.Forms.Label lblLetterVal;
        private System.Windows.Forms.Label lblWordValue;
        private System.Windows.Forms.ToolStripMenuItem SaveAsPNG;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPNG;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem SaveBTI;
        private System.Windows.Forms.ToolStripMenuItem SaveAsBTI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBTI;
        private System.Windows.Forms.CheckBox chkboxSqueeze;
        private System.Windows.Forms.CheckBox chkboxPrefix;
    }
}

