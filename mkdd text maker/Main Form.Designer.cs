namespace mkdd_text_maker
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
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
            this.autoSizesomethingX32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTextColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mniiTextSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.mniiTextGrad = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOutlineColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mniiOutLSingle = new System.Windows.Forms.ToolStripMenuItem();
            this.mniiOutLGrad = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblVertiVal = new System.Windows.Forms.Label();
            this.tckVertical = new System.Windows.Forms.TrackBar();
            this.lblVerticalScaling = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckLetter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSqueeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.imageSizeToolStripMenuItem,
            this.alignmentToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(674, 26);
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
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // loadAndConverttxtFileToolStripMenuItem
            // 
            this.loadAndConverttxtFileToolStripMenuItem.Name = "loadAndConverttxtFileToolStripMenuItem";
            this.loadAndConverttxtFileToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.loadAndConverttxtFileToolStripMenuItem.Text = "Load and Convert .txt file";
            this.loadAndConverttxtFileToolStripMenuItem.Click += new System.EventHandler(this.loadText_Click);
            // 
            // loadSettingsToolStripMenuItem
            // 
            this.loadSettingsToolStripMenuItem.Enabled = false;
            this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
            this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.loadSettingsToolStripMenuItem.Text = "Load settings";
            this.loadSettingsToolStripMenuItem.Visible = false;
            this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.LoadSettings);
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Enabled = false;
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.saveSettingsToolStripMenuItem.Text = "Save settings";
            this.saveSettingsToolStripMenuItem.Visible = false;
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.fileToolStripMenuItem.Text = "Save Image";
            // 
            // SavePNG
            // 
            this.SavePNG.Enabled = false;
            this.SavePNG.Name = "SavePNG";
            this.SavePNG.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SavePNG.Size = new System.Drawing.Size(264, 26);
            this.SavePNG.Text = "Save .png";
            this.SavePNG.Click += new System.EventHandler(this.SavepngToolStripMenuItem_Click);
            // 
            // SaveAsPNG
            // 
            this.SaveAsPNG.Enabled = false;
            this.SaveAsPNG.Name = "SaveAsPNG";
            this.SaveAsPNG.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsPNG.Size = new System.Drawing.Size(264, 26);
            this.SaveAsPNG.Text = "Save as .png";
            this.SaveAsPNG.Click += new System.EventHandler(this.SaveAspngToolStripMenuItem_Click);
            // 
            // SaveBTI
            // 
            this.SaveBTI.Enabled = false;
            this.SaveBTI.Name = "SaveBTI";
            this.SaveBTI.Size = new System.Drawing.Size(264, 26);
            this.SaveBTI.Text = "Save .bti";
            this.SaveBTI.Click += new System.EventHandler(this.saveAsbtiToolStripMenuItem_Click);
            // 
            // SaveAsBTI
            // 
            this.SaveAsBTI.Enabled = false;
            this.SaveAsBTI.Name = "SaveAsBTI";
            this.SaveAsBTI.Size = new System.Drawing.Size(264, 26);
            this.SaveAsBTI.Text = "Save as. bti";
            this.SaveAsBTI.Click += new System.EventHandler(this.SaveAsBTI_Click);
            // 
            // imageSizeToolStripMenuItem
            // 
            this.imageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseName256X32ToolStripMenuItem,
            this.characterName152X32ToolStripMenuItem,
            this.autoSizesomethingX32ToolStripMenuItem});
            this.imageSizeToolStripMenuItem.Name = "imageSizeToolStripMenuItem";
            this.imageSizeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.imageSizeToolStripMenuItem.Text = "Image Size";
            // 
            // courseName256X32ToolStripMenuItem
            // 
            this.courseName256X32ToolStripMenuItem.Name = "courseName256X32ToolStripMenuItem";
            this.courseName256X32ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.courseName256X32ToolStripMenuItem.Text = "Course Name (256 x 32)";
            this.courseName256X32ToolStripMenuItem.Click += new System.EventHandler(this.courseName256X32ToolStripMenuItem_Click);
            // 
            // characterName152X32ToolStripMenuItem
            // 
            this.characterName152X32ToolStripMenuItem.Name = "characterName152X32ToolStripMenuItem";
            this.characterName152X32ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.characterName152X32ToolStripMenuItem.Text = "Character Name (152 x 32)";
            this.characterName152X32ToolStripMenuItem.Click += new System.EventHandler(this.characterName152X32ToolStripMenuItem_Click);
            // 
            // autoSizesomethingX32ToolStripMenuItem
            // 
            this.autoSizesomethingX32ToolStripMenuItem.Name = "autoSizesomethingX32ToolStripMenuItem";
            this.autoSizesomethingX32ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
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
            this.alignmentToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.alignmentToolStripMenuItem.Text = "Alignment";
            this.alignmentToolStripMenuItem.Visible = false;
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // centerToolStripMenuItem
            // 
            this.centerToolStripMenuItem.Name = "centerToolStripMenuItem";
            this.centerToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.centerToolStripMenuItem.Text = "Center";
            this.centerToolStripMenuItem.Click += new System.EventHandler(this.centerToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTextColor,
            this.mniOutlineColor,
            this.loadGradientToolStripMenuItem,
            this.saveGradientToolStripMenuItem,
            this.backgroundImageToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Visible = false;
            // 
            // mniTextColor
            // 
            this.mniTextColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniiTextSingle,
            this.mniiTextGrad});
            this.mniTextColor.Name = "mniTextColor";
            this.mniTextColor.Size = new System.Drawing.Size(256, 26);
            this.mniTextColor.Text = "Text Color";
            // 
            // mniiTextSingle
            // 
            this.mniiTextSingle.Name = "mniiTextSingle";
            this.mniiTextSingle.Size = new System.Drawing.Size(193, 26);
            this.mniiTextSingle.Text = "Single Color";
            this.mniiTextSingle.Click += new System.EventHandler(this.mniiTextSingle_Click);
            // 
            // mniiTextGrad
            // 
            this.mniiTextGrad.Name = "mniiTextGrad";
            this.mniiTextGrad.Size = new System.Drawing.Size(193, 26);
            this.mniiTextGrad.Text = "Gradient Editor";
            this.mniiTextGrad.Click += new System.EventHandler(this.GradientText_Click);
            // 
            // mniOutlineColor
            // 
            this.mniOutlineColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniiOutLSingle,
            this.mniiOutLGrad});
            this.mniOutlineColor.Name = "mniOutlineColor";
            this.mniOutlineColor.Size = new System.Drawing.Size(256, 26);
            this.mniOutlineColor.Text = "Outline Color";
            // 
            // mniiOutLSingle
            // 
            this.mniiOutLSingle.Name = "mniiOutLSingle";
            this.mniiOutLSingle.Size = new System.Drawing.Size(193, 26);
            this.mniiOutLSingle.Text = "Single Color";
            this.mniiOutLSingle.Click += new System.EventHandler(this.OutlineSingle_Clicked);
            // 
            // mniiOutLGrad
            // 
            this.mniiOutLGrad.Name = "mniiOutLGrad";
            this.mniiOutLGrad.Size = new System.Drawing.Size(193, 26);
            this.mniiOutLGrad.Text = "Gradient Editor";
            this.mniiOutLGrad.Click += new System.EventHandler(this.OutlineGradient_Clicked);
            // 
            // loadGradientToolStripMenuItem
            // 
            this.loadGradientToolStripMenuItem.Name = "loadGradientToolStripMenuItem";
            this.loadGradientToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.loadGradientToolStripMenuItem.Text = "Load Gradient (text)";
            this.loadGradientToolStripMenuItem.Click += new System.EventHandler(this.loadGradientToolStripMenuItem_Click);
            // 
            // saveGradientToolStripMenuItem
            // 
            this.saveGradientToolStripMenuItem.Name = "saveGradientToolStripMenuItem";
            this.saveGradientToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.saveGradientToolStripMenuItem.Text = "Save Gradient (text)";
            this.saveGradientToolStripMenuItem.Click += new System.EventHandler(this.saveGradientToolStripMenuItem_Click);
            // 
            // backgroundImageToolStripMenuItem
            // 
            this.backgroundImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearImageToolStripMenuItem});
            this.backgroundImageToolStripMenuItem.Name = "backgroundImageToolStripMenuItem";
            this.backgroundImageToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.backgroundImageToolStripMenuItem.Text = "Background Image (text)";
            this.backgroundImageToolStripMenuItem.Click += new System.EventHandler(this.backgroundImageToolStripMenuItem_Click);
            // 
            // clearImageToolStripMenuItem
            // 
            this.clearImageToolStripMenuItem.Name = "clearImageToolStripMenuItem";
            this.clearImageToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.clearImageToolStripMenuItem.Text = "Clear Image";
            this.clearImageToolStripMenuItem.Click += new System.EventHandler(this.clearImageToolStripMenuItem_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(262, 35);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(230, 22);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.UpdateText);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(148, 38);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(112, 17);
            this.lblInput.TabIndex = 3;
            this.lblInput.Text = "Enter Text Here:";
            // 
            // tckLetter
            // 
            this.tckLetter.LargeChange = 3;
            this.tckLetter.Location = new System.Drawing.Point(181, 85);
            this.tckLetter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tckLetter.Maximum = 15;
            this.tckLetter.Name = "tckLetter";
            this.tckLetter.Size = new System.Drawing.Size(274, 56);
            this.tckLetter.TabIndex = 4;
            this.tckLetter.Value = 5;
            this.tckLetter.Scroll += new System.EventHandler(this.TckLetter_Scroll);
            this.tckLetter.ValueChanged += new System.EventHandler(this.UpdateText);
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Location = new System.Drawing.Point(20, 85);
            this.lblLetters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(162, 17);
            this.lblLetters.TabIndex = 5;
            this.lblLetters.Text = "Overlap between letters:";
            // 
            // picText
            // 
            this.picText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picText.BackgroundImage")));
            this.picText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picText.Location = new System.Drawing.Point(14, 271);
            this.picText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picText.Name = "picText";
            this.picText.Size = new System.Drawing.Size(641, 84);
            this.picText.TabIndex = 6;
            this.picText.TabStop = false;
            this.picText.DoubleClick += new System.EventHandler(this.picText_DoubleClick);
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(20, 129);
            this.lblWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(150, 17);
            this.lblWords.TabIndex = 8;
            this.lblWords.Text = "Space between words:";
            // 
            // tckWords
            // 
            this.tckWords.LargeChange = 1;
            this.tckWords.Location = new System.Drawing.Point(181, 129);
            this.tckWords.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tckWords.Maximum = 20;
            this.tckWords.Minimum = 1;
            this.tckWords.Name = "tckWords";
            this.tckWords.Size = new System.Drawing.Size(274, 56);
            this.tckWords.TabIndex = 7;
            this.tckWords.Value = 10;
            this.tckWords.Scroll += new System.EventHandler(this.TckWords_Scroll);
            this.tckWords.ValueChanged += new System.EventHandler(this.UpdateText);
            // 
            // lblLetterVal
            // 
            this.lblLetterVal.AutoSize = true;
            this.lblLetterVal.Location = new System.Drawing.Point(474, 85);
            this.lblLetterVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLetterVal.Name = "lblLetterVal";
            this.lblLetterVal.Size = new System.Drawing.Size(16, 17);
            this.lblLetterVal.TabIndex = 9;
            this.lblLetterVal.Text = "5";
            // 
            // lblWordValue
            // 
            this.lblWordValue.AutoSize = true;
            this.lblWordValue.Location = new System.Drawing.Point(474, 129);
            this.lblWordValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWordValue.Name = "lblWordValue";
            this.lblWordValue.Size = new System.Drawing.Size(24, 17);
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
            this.cmbPrefix.Location = new System.Drawing.Point(69, 34);
            this.cmbPrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPrefix.Name = "cmbPrefix";
            this.cmbPrefix.Size = new System.Drawing.Size(69, 24);
            this.cmbPrefix.TabIndex = 11;
            this.cmbPrefix.Text = "None";
            this.cmbPrefix.SelectedIndexChanged += new System.EventHandler(this.cmbPrefix_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
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
            this.chkboxPrefix.Location = new System.Drawing.Point(21, 61);
            this.chkboxPrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkboxPrefix.Name = "chkboxPrefix";
            this.chkboxPrefix.Size = new System.Drawing.Size(116, 21);
            this.chkboxPrefix.TabIndex = 14;
            this.chkboxPrefix.Text = "Smaller Prefix";
            this.chkboxPrefix.UseVisualStyleBackColor = true;
            this.chkboxPrefix.CheckedChanged += new System.EventHandler(this.chkboxPrefix_CheckedChanged);
            this.chkboxPrefix.Click += new System.EventHandler(this.UpdateText);
            // 
            // lblSqueeze
            // 
            this.lblSqueeze.AutoSize = true;
            this.lblSqueeze.Location = new System.Drawing.Point(20, 169);
            this.lblSqueeze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSqueeze.Name = "lblSqueeze";
            this.lblSqueeze.Size = new System.Drawing.Size(126, 17);
            this.lblSqueeze.TabIndex = 15;
            this.lblSqueeze.Text = "Horizontal Scaling:";
            // 
            // tckSqueeze
            // 
            this.tckSqueeze.Location = new System.Drawing.Point(181, 161);
            this.tckSqueeze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tckSqueeze.Maximum = 100;
            this.tckSqueeze.Minimum = 50;
            this.tckSqueeze.Name = "tckSqueeze";
            this.tckSqueeze.Size = new System.Drawing.Size(274, 56);
            this.tckSqueeze.SmallChange = 5;
            this.tckSqueeze.TabIndex = 16;
            this.tckSqueeze.TickFrequency = 5;
            this.tckSqueeze.Value = 100;
            this.tckSqueeze.Scroll += new System.EventHandler(this.tckSqueeze_Scroll);
            this.tckSqueeze.ValueChanged += new System.EventHandler(this.UpdateText);
            // 
            // lblShowSqueeze
            // 
            this.lblShowSqueeze.AutoSize = true;
            this.lblShowSqueeze.Location = new System.Drawing.Point(474, 171);
            this.lblShowSqueeze.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowSqueeze.Name = "lblShowSqueeze";
            this.lblShowSqueeze.Size = new System.Drawing.Size(32, 17);
            this.lblShowSqueeze.TabIndex = 17;
            this.lblShowSqueeze.Text = "100";
            // 
            // lblVertiVal
            // 
            this.lblVertiVal.AutoSize = true;
            this.lblVertiVal.Location = new System.Drawing.Point(474, 210);
            this.lblVertiVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVertiVal.Name = "lblVertiVal";
            this.lblVertiVal.Size = new System.Drawing.Size(32, 17);
            this.lblVertiVal.TabIndex = 21;
            this.lblVertiVal.Text = "100";
            // 
            // tckVertical
            // 
            this.tckVertical.Location = new System.Drawing.Point(181, 203);
            this.tckVertical.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tckVertical.Maximum = 100;
            this.tckVertical.Minimum = 75;
            this.tckVertical.Name = "tckVertical";
            this.tckVertical.Size = new System.Drawing.Size(274, 56);
            this.tckVertical.SmallChange = 5;
            this.tckVertical.TabIndex = 20;
            this.tckVertical.TickFrequency = 5;
            this.tckVertical.Value = 100;
            this.tckVertical.Scroll += new System.EventHandler(this.tckVertical_Scroll);
            this.tckVertical.ValueChanged += new System.EventHandler(this.UpdateText);
            // 
            // lblVerticalScaling
            // 
            this.lblVerticalScaling.AutoSize = true;
            this.lblVerticalScaling.Location = new System.Drawing.Point(20, 210);
            this.lblVerticalScaling.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerticalScaling.Name = "lblVerticalScaling";
            this.lblVerticalScaling.Size = new System.Drawing.Size(109, 17);
            this.lblVerticalScaling.TabIndex = 19;
            this.lblVerticalScaling.Text = "Vertical Scaling:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 373);
            this.Controls.Add(this.lblVertiVal);
            this.Controls.Add(this.tckVertical);
            this.Controls.Add(this.lblVerticalScaling);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Form";
            this.Text = "MKDD Text Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tckLetter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckSqueeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePNG;
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
        private System.Windows.Forms.ToolStripMenuItem alignmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizesomethingX32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniTextColor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadAndConverttxtFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGradientToolStripMenuItem;
        private System.Windows.Forms.Label lblVertiVal;
        private System.Windows.Forms.TrackBar tckVertical;
        private System.Windows.Forms.Label lblVerticalScaling;
        private System.Windows.Forms.ToolStripMenuItem mniOutlineColor;
        private System.Windows.Forms.ToolStripMenuItem backgroundImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniiOutLSingle;
        private System.Windows.Forms.ToolStripMenuItem mniiOutLGrad;
        private System.Windows.Forms.ToolStripMenuItem mniiTextSingle;
        private System.Windows.Forms.ToolStripMenuItem mniiTextGrad;
        private System.Windows.Forms.ToolStripMenuItem clearImageToolStripMenuItem;
    }
}

