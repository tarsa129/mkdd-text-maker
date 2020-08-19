namespace mkdd_text_maker
{
    partial class Color_Editor
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
            this.txt1r = new System.Windows.Forms.TextBox();
            this.txt1g = new System.Windows.Forms.TextBox();
            this.txt1b = new System.Windows.Forms.TextBox();
            this.btnCone = new System.Windows.Forms.Button();
            this.cmbGrads = new System.Windows.Forms.ComboBox();
            this.btnAddGrad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelGrad = new System.Windows.Forms.Button();
            this.picGrad = new System.Windows.Forms.PictureBox();
            this.tckAngle = new System.Windows.Forms.TrackBar();
            this.btnClearGrad = new System.Windows.Forms.Button();
            this.cmbColors = new System.Windows.Forms.ComboBox();
            this.lblColors = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.tckPos = new System.Windows.Forms.TrackBar();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnDelColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radByImage = new System.Windows.Forms.RadioButton();
            this.radByLetter = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picGrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckPos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1r
            // 
            this.txt1r.Location = new System.Drawing.Point(27, 111);
            this.txt1r.Name = "txt1r";
            this.txt1r.Size = new System.Drawing.Size(100, 38);
            this.txt1r.TabIndex = 2;
            this.txt1r.Text = "255";
            this.txt1r.Leave += new System.EventHandler(this.txt1r_TextChanged);
            // 
            // txt1g
            // 
            this.txt1g.Location = new System.Drawing.Point(140, 111);
            this.txt1g.Name = "txt1g";
            this.txt1g.Size = new System.Drawing.Size(100, 38);
            this.txt1g.TabIndex = 3;
            this.txt1g.Text = "255";
            this.txt1g.Leave += new System.EventHandler(this.txt1r_TextChanged);
            // 
            // txt1b
            // 
            this.txt1b.Location = new System.Drawing.Point(251, 111);
            this.txt1b.Name = "txt1b";
            this.txt1b.Size = new System.Drawing.Size(100, 38);
            this.txt1b.TabIndex = 4;
            this.txt1b.Text = "255";
            this.txt1b.Leave += new System.EventHandler(this.txt1r_TextChanged);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(384, 107);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(314, 47);
            this.btnCone.TabIndex = 8;
            this.btnCone.Text = "Open Color Picker";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnColorDialog);
            // 
            // cmbGrads
            // 
            this.cmbGrads.FormattingEnabled = true;
            this.cmbGrads.Items.AddRange(new object[] {
            "Gradient 0"});
            this.cmbGrads.Location = new System.Drawing.Point(749, 54);
            this.cmbGrads.Name = "cmbGrads";
            this.cmbGrads.Size = new System.Drawing.Size(626, 39);
            this.cmbGrads.TabIndex = 10;
            this.cmbGrads.SelectedIndexChanged += new System.EventHandler(this.cmbGrads_SelectedIndexChanged);
            // 
            // btnAddGrad
            // 
            this.btnAddGrad.Location = new System.Drawing.Point(707, 313);
            this.btnAddGrad.Name = "btnAddGrad";
            this.btnAddGrad.Size = new System.Drawing.Size(325, 74);
            this.btnAddGrad.TabIndex = 11;
            this.btnAddGrad.Text = "Add New Gradient";
            this.btnAddGrad.UseVisualStyleBackColor = true;
            this.btnAddGrad.Click += new System.EventHandler(this.btnAddGrad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gradients:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(1050, 509);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(325, 74);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelGrad
            // 
            this.btnDelGrad.Location = new System.Drawing.Point(707, 509);
            this.btnDelGrad.Name = "btnDelGrad";
            this.btnDelGrad.Size = new System.Drawing.Size(325, 74);
            this.btnDelGrad.TabIndex = 14;
            this.btnDelGrad.Text = "Delete Gradient";
            this.btnDelGrad.UseVisualStyleBackColor = true;
            this.btnDelGrad.Click += new System.EventHandler(this.btnDeleteGrad_Click);
            // 
            // picGrad
            // 
            this.picGrad.Location = new System.Drawing.Point(26, 313);
            this.picGrad.Name = "picGrad";
            this.picGrad.Size = new System.Drawing.Size(276, 275);
            this.picGrad.TabIndex = 15;
            this.picGrad.TabStop = false;
            // 
            // tckAngle
            // 
            this.tckAngle.Location = new System.Drawing.Point(861, 171);
            this.tckAngle.Maximum = 450;
            this.tckAngle.Minimum = 90;
            this.tckAngle.Name = "tckAngle";
            this.tckAngle.Size = new System.Drawing.Size(396, 114);
            this.tckAngle.TabIndex = 17;
            this.tckAngle.TabStop = false;
            this.tckAngle.Value = 90;
            this.tckAngle.ValueChanged += new System.EventHandler(this.tckAngle_ValueChanged);
            // 
            // btnClearGrad
            // 
            this.btnClearGrad.Location = new System.Drawing.Point(707, 410);
            this.btnClearGrad.Name = "btnClearGrad";
            this.btnClearGrad.Size = new System.Drawing.Size(325, 74);
            this.btnClearGrad.TabIndex = 18;
            this.btnClearGrad.Text = "Clear Gradient";
            this.btnClearGrad.UseVisualStyleBackColor = true;
            this.btnClearGrad.Click += new System.EventHandler(this.btnClearGrad_Click);
            // 
            // cmbColors
            // 
            this.cmbColors.FormattingEnabled = true;
            this.cmbColors.Items.AddRange(new object[] {
            "Color 0",
            "Color 1"});
            this.cmbColors.Location = new System.Drawing.Point(26, 54);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Size = new System.Drawing.Size(672, 39);
            this.cmbColors.TabIndex = 19;
            this.cmbColors.SelectedIndexChanged += new System.EventHandler(this.cmbColorChange);
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Location = new System.Drawing.Point(21, 19);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(105, 32);
            this.lblColors.TabIndex = 20;
            this.lblColors.Text = "Colors:";
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(1050, 410);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(325, 74);
            this.btnFill.TabIndex = 21;
            this.btnFill.Text = "Fill with Current Color";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(1050, 313);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(325, 74);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.Text = "Clear All Gradients";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // tckPos
            // 
            this.tckPos.Location = new System.Drawing.Point(153, 171);
            this.tckPos.Maximum = 100;
            this.tckPos.Name = "tckPos";
            this.tckPos.Size = new System.Drawing.Size(405, 114);
            this.tckPos.TabIndex = 23;
            this.tckPos.ValueChanged += new System.EventHandler(this.tckPos_ValueChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(743, 181);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(97, 32);
            this.lblAngle.TabIndex = 24;
            this.lblAngle.Text = "Angle:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(21, 184);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(126, 32);
            this.lblPos.TabIndex = 25;
            this.lblPos.Text = "Position:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(598, 181);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(100, 38);
            this.txtPos.TabIndex = 26;
            this.txtPos.TextChanged += new System.EventHandler(this.txtPos_TextChanged);
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(1263, 178);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(112, 38);
            this.txtAngle.TabIndex = 27;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(351, 313);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(325, 74);
            this.btnAddColor.TabIndex = 28;
            this.btnAddColor.Text = "Add New Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // btnDelColor
            // 
            this.btnDelColor.Location = new System.Drawing.Point(351, 410);
            this.btnDelColor.Name = "btnDelColor";
            this.btnDelColor.Size = new System.Drawing.Size(325, 74);
            this.btnDelColor.TabIndex = 31;
            this.btnDelColor.Text = "Delete Color";
            this.btnDelColor.UseVisualStyleBackColor = true;
            this.btnDelColor.Click += new System.EventHandler(this.btnDelColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radByImage);
            this.groupBox1.Controls.Add(this.radByLetter);
            this.groupBox1.Location = new System.Drawing.Point(749, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 46);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply By:";
            // 
            // radByImage
            // 
            this.radByImage.AutoSize = true;
            this.radByImage.Location = new System.Drawing.Point(401, 4);
            this.radByImage.Name = "radByImage";
            this.radByImage.Size = new System.Drawing.Size(130, 36);
            this.radByImage.TabIndex = 2;
            this.radByImage.TabStop = true;
            this.radByImage.Text = "image";
            this.radByImage.UseVisualStyleBackColor = true;
            this.radByImage.CheckedChanged += new System.EventHandler(this.radByImage_CheckedChanged);
            // 
            // radByLetter
            // 
            this.radByLetter.AutoSize = true;
            this.radByLetter.Location = new System.Drawing.Point(225, 4);
            this.radByLetter.Name = "radByLetter";
            this.radByLetter.Size = new System.Drawing.Size(116, 36);
            this.radByLetter.TabIndex = 0;
            this.radByLetter.TabStop = true;
            this.radByLetter.Text = "letter";
            this.radByLetter.UseVisualStyleBackColor = true;
            this.radByLetter.CheckedChanged += new System.EventHandler(this.radByLetter_CheckedChanged);
            // 
            // Color_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelColor);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.tckPos);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.cmbColors);
            this.Controls.Add(this.btnClearGrad);
            this.Controls.Add(this.tckAngle);
            this.Controls.Add(this.picGrad);
            this.Controls.Add(this.btnDelGrad);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddGrad);
            this.Controls.Add(this.cmbGrads);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.txt1b);
            this.Controls.Add(this.txt1g);
            this.Controls.Add(this.txt1r);
            this.Name = "Color_Editor";
            this.Text = "Color_Editor";
            this.Load += new System.EventHandler(this.Color_Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckPos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt1r;
        private System.Windows.Forms.TextBox txt1g;
        private System.Windows.Forms.TextBox txt1b;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.ComboBox cmbGrads;
        private System.Windows.Forms.Button btnAddGrad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelGrad;
        private System.Windows.Forms.PictureBox picGrad;
        private System.Windows.Forms.TrackBar tckAngle;
        private System.Windows.Forms.Button btnClearGrad;
        private System.Windows.Forms.ComboBox cmbColors;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TrackBar tckPos;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnDelColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radByImage;
        private System.Windows.Forms.RadioButton radByLetter;
    }
}