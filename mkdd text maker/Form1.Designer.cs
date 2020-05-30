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
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndConverttxtFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePNG = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsPNG = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBTI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsBTI = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseName256X32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterName152X32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizesomethingX32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cmbPrefix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialogBTI = new System.Windows.Forms.SaveFileDialog();
            this.chkboxPrefix = new System.Windows.Forms.CheckBox();
            this.lblSqueeze = new System.Windows.Forms.Label();
            this.tckSqueeze = new System.Windows.Forms.TrackBar();
            this.lblShowSqueeze = new System.Windows.Forms.Label();
            this.chkColor = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSqueeze)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.imageSizeToolStripMenuItem,
            this.alignmentToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAndConverttxtFileToolStripMenuItem,
            this.loadSettingsToolStripMenuItem,
            this.saveSettingsToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(87, 48);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // loadAndConverttxtFileToolStripMenuItem
            // 
            this.loadAndConverttxtFileToolStripMenuItem.Name = "loadAndConverttxtFileToolStripMenuItem";
            this.loadAndConverttxtFileToolStripMenuItem.Size = new System.Drawing.Size(515, 54);
            this.loadAndConverttxtFileToolStripMenuItem.Text = "Load and Convert .txt file";
            this.loadAndConverttxtFileToolStripMenuItem.Click += new System.EventHandler(this.loadText_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(515, 54);
            this.loadSettingsToolStripMenuItem.Text = "Load settings";
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.LoadSettings);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(515, 54);
            this.saveSettingsToolStripMenuItem.Text = "Save settings";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.SaveSettingsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePNG,
            this.SaveAsPNG,
            this.SaveBTI,
            this.SaveAsBTI});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(194, 48);
            this.fileToolStripMenuItem.Text = "Save Image";
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
            // imageSizeToolStripMenuItem
            // 
            this.imageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseName256X32ToolStripMenuItem,
            this.characterName152X32ToolStripMenuItem,
            this.customSizeToolStripMenuItem,
            this.autoSizesomethingX32ToolStripMenuItem});
            this.imageSizeToolStripMenuItem.Name = "imageSizeToolStripMenuItem";
            this.imageSizeToolStripMenuItem.Size = new System.Drawing.Size(186, 48);
            this.imageSizeToolStripMenuItem.Text = "Image Size";
            // 
            // courseName256X32ToolStripMenuItem
            // 
            this.courseName256X32ToolStripMenuItem.Name = "courseName256X32ToolStripMenuItem";
            this.courseName256X32ToolStripMenuItem.Size = new System.Drawing.Size(539, 54);
            this.courseName256X32ToolStripMenuItem.Text = "Course Name (256 x 32)";
            this.courseName256X32ToolStripMenuItem.Click += new System.EventHandler(this.courseName256X32ToolStripMenuItem_Click);
            // 
            // characterName152X32ToolStripMenuItem
            // 
            this.characterName152X32ToolStripMenuItem.Name = "characterName152X32ToolStripMenuItem";
            this.characterName152X32ToolStripMenuItem.Size = new System.Drawing.Size(539, 54);
            this.characterName152X32ToolStripMenuItem.Text = "Character Name (152 x 32)";
            this.characterName152X32ToolStripMenuItem.Click += new System.EventHandler(this.characterName152X32ToolStripMenuItem_Click);
            // 
            // customSizeToolStripMenuItem
            // 
            this.customSizeToolStripMenuItem.Name = "customSizeToolStripMenuItem";
            this.customSizeToolStripMenuItem.Size = new System.Drawing.Size(539, 54);
            this.customSizeToolStripMenuItem.Text = "Custom Size";
            this.customSizeToolStripMenuItem.Click += new System.EventHandler(this.customSizeToolStripMenuItem_Click);
            // 
            // autoSizesomethingX32ToolStripMenuItem
            // 
            this.autoSizesomethingX32ToolStripMenuItem.Name = "autoSizesomethingX32ToolStripMenuItem";
            this.autoSizesomethingX32ToolStripMenuItem.Size = new System.Drawing.Size(539, 54);
            this.autoSizesomethingX32ToolStripMenuItem.Text = "Auto Size (something x 32)";
            this.autoSizesomethingX32ToolStripMenuItem.Click += new System.EventHandler(this.autoSize);
            // 
            // alignmentToolStripMenuItem
            // 
            this.alignmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.centerToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.alignmentToolStripMenuItem.Name = "alignmentToolStripMenuItem";
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(179, 48);
            this.alignmentToolStripMenuItem.Text = "Alignment";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(272, 54);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(272, 54);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(272, 54);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleColorToolStripMenuItem,
            this.graidToolStripMenuItem,
            this.loadGradientToolStripMenuItem,
            this.saveGradientToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(114, 48);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // singleColorToolStripMenuItem
            // 
            this.singleColorToolStripMenuItem.Name = "singleColorToolStripMenuItem";
            this.singleColorToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.singleColorToolStripMenuItem.Text = "Single Color";
            this.singleColorToolStripMenuItem.Click += new System.EventHandler(this.colordia);
            // 
            // graidToolStripMenuItem
            // 
            this.graidToolStripMenuItem.Name = "graidToolStripMenuItem";
            this.graidToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.graidToolStripMenuItem.Text = "Gradient Editor";
            this.graidToolStripMenuItem.Click += new System.EventHandler(this.graidToolStripMenuItem_Click);
            // 
            // loadGradientToolStripMenuItem
            // 
            this.loadGradientToolStripMenuItem.Name = "loadGradientToolStripMenuItem";
            this.loadGradientToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.loadGradientToolStripMenuItem.Text = "Load Gradient";
            this.loadGradientToolStripMenuItem.Click += new System.EventHandler(this.loadGradientToolStripMenuItem_Click);
            // 
            // saveGradientToolStripMenuItem
            // 
            this.saveGradientToolStripMenuItem.Name = "saveGradientToolStripMenuItem";
            this.saveGradientToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveGradientToolStripMenuItem.Text = "Save Gradient";
            this.saveGradientToolStripMenuItem.Click += new System.EventHandler(this.saveGradientToolStripMenuItem_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(1024, 222);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(285, 114);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Make Text";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.UpdateText);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(524, 67);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(455, 38);
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
            this.tckLetter.Location = new System.Drawing.Point(346, 141);
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
            this.lblLetters.Location = new System.Drawing.Point(23, 141);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(323, 32);
            this.lblLetters.TabIndex = 5;
            this.lblLetters.Text = "Overlap between letters:";
            // 
            // picText
            // 
            this.picText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picText.BackgroundImage")));
            this.picText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picText.Location = new System.Drawing.Point(29, 408);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(1280, 160);
            this.picText.TabIndex = 6;
            this.picText.TabStop = false;
            this.picText.DoubleClick += new System.EventHandler(this.picText_DoubleClick);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(23, 226);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(301, 32);
            this.lblWords.TabIndex = 8;
            this.lblWords.Text = "Space between words:";
            // 
            // tckWords
            // 
            this.tckWords.LargeChange = 1;
            this.tckWords.Location = new System.Drawing.Point(346, 226);
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
            this.lblLetterVal.Location = new System.Drawing.Point(932, 141);
            this.lblLetterVal.Name = "lblLetterVal";
            this.lblLetterVal.Size = new System.Drawing.Size(31, 32);
            this.lblLetterVal.TabIndex = 9;
            this.lblLetterVal.Text = "5";
            // 
            // lblWordValue
            // 
            this.lblWordValue.AutoSize = true;
            this.lblWordValue.Location = new System.Drawing.Point(932, 226);
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
            // cmbPrefix
            // 
            this.cmbPrefix.FormattingEnabled = true;
            this.cmbPrefix.Items.AddRange(new object[] {
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
            this.cmbPrefix.Location = new System.Drawing.Point(138, 66);
            this.cmbPrefix.Name = "cmbPrefix";
            this.cmbPrefix.Size = new System.Drawing.Size(134, 39);
            this.cmbPrefix.TabIndex = 11;
            this.cmbPrefix.Text = "None";
            this.cmbPrefix.SelectedIndexChanged += new System.EventHandler(this.cmbPrefix_SelectedIndexChanged);
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
            // chkboxPrefix
            // 
            this.chkboxPrefix.AutoSize = true;
            this.chkboxPrefix.Location = new System.Drawing.Point(1024, 160);
            this.chkboxPrefix.Name = "chkboxPrefix";
            this.chkboxPrefix.Size = new System.Drawing.Size(230, 36);
            this.chkboxPrefix.TabIndex = 14;
            this.chkboxPrefix.Text = "Smaller Prefix";
            this.chkboxPrefix.UseVisualStyleBackColor = true;
            this.chkboxPrefix.CheckedChanged += new System.EventHandler(this.chkboxPrefix_CheckedChanged);
            // 
            // lblSqueeze
            // 
            this.lblSqueeze.AutoSize = true;
            this.lblSqueeze.Location = new System.Drawing.Point(23, 304);
            this.lblSqueeze.Name = "lblSqueeze";
            this.lblSqueeze.Size = new System.Drawing.Size(334, 32);
            this.lblSqueeze.TabIndex = 15;
            this.lblSqueeze.Text = "Letter Horizontal Scaling:";
            // 
            // tckSqueeze
            // 
            this.tckSqueeze.Location = new System.Drawing.Point(363, 288);
            this.tckSqueeze.Maximum = 100;
            this.tckSqueeze.Minimum = 75;
            this.tckSqueeze.Name = "tckSqueeze";
            this.tckSqueeze.Size = new System.Drawing.Size(531, 114);
            this.tckSqueeze.SmallChange = 5;
            this.tckSqueeze.TabIndex = 16;
            this.tckSqueeze.TickFrequency = 5;
            this.tckSqueeze.Value = 100;
            this.tckSqueeze.Scroll += new System.EventHandler(this.tckSqueeze_Scroll);
            // 
            // lblShowSqueeze
            // 
            this.lblShowSqueeze.AutoSize = true;
            this.lblShowSqueeze.Location = new System.Drawing.Point(932, 308);
            this.lblShowSqueeze.Name = "lblShowSqueeze";
            this.lblShowSqueeze.Size = new System.Drawing.Size(63, 32);
            this.lblShowSqueeze.TabIndex = 17;
            this.lblShowSqueeze.Text = "100";
            // 
            // chkColor
            // 
            this.chkColor.AutoSize = true;
            this.chkColor.Location = new System.Drawing.Point(1024, 118);
            this.chkColor.Name = "chkColor";
            this.chkColor.Size = new System.Drawing.Size(121, 36);
            this.chkColor.TabIndex = 18;
            this.chkColor.Text = "Color";
            this.chkColor.UseVisualStyleBackColor = true;
            this.chkColor.CheckedChanged += new System.EventHandler(this.chkColor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 637);
            this.Controls.Add(this.chkColor);
            this.Controls.Add(this.lblShowSqueeze);
            this.Controls.Add(this.tckSqueeze);
            this.Controls.Add(this.lblSqueeze);
            this.Controls.Add(this.chkboxPrefix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPrefix);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "MKDD Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSqueeze)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem SaveBTI;
        private System.Windows.Forms.ToolStripMenuItem SaveAsBTI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBTI;
        private System.Windows.Forms.CheckBox chkboxPrefix;
        private System.Windows.Forms.Label lblSqueeze;
        private System.Windows.Forms.TrackBar tckSqueeze;
        private System.Windows.Forms.Label lblShowSqueeze;
        private System.Windows.Forms.ToolStripMenuItem imageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseName256X32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterName152X32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizesomethingX32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkColor;
        private System.Windows.Forms.ToolStripMenuItem singleColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadAndConverttxtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGradientToolStripMenuItem;
    }
}

