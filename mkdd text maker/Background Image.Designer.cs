namespace mkdd_text_maker
{
    partial class Background_Image
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.OpenImage = new System.Windows.Forms.OpenFileDialog();
            this.lblHScale = new System.Windows.Forms.Label();
            this.tckHScale = new System.Windows.Forms.TrackBar();
            this.tckVScale = new System.Windows.Forms.TrackBar();
            this.lblVScale = new System.Windows.Forms.Label();
            this.lblHScaleVal = new System.Windows.Forms.Label();
            this.lblVScaleVal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckHScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVScale)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNewImageToolStripMenuItem,
            this.menuReload});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(87, 56);
            this.File.Text = "File";
            // 
            // loadNewImageToolStripMenuItem
            // 
            this.loadNewImageToolStripMenuItem.Name = "loadNewImageToolStripMenuItem";
            this.loadNewImageToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.loadNewImageToolStripMenuItem.Text = "Load New Image";
            this.loadNewImageToolStripMenuItem.Click += new System.EventHandler(this.loadNewImageToolStripMenuItem_Click);
            // 
            // menuReload
            // 
            this.menuReload.Enabled = false;
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(448, 54);
            this.menuReload.Text = "Reload Image";
            this.menuReload.Click += new System.EventHandler(this.menuReload_Click);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(68, 332);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(1280, 160);
            this.picPreview.TabIndex = 1;
            this.picPreview.TabStop = false;
            // 
            // OpenImage
            // 
            this.OpenImage.FileName = "Image";
            this.OpenImage.Filter = "\"Image Files(*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.b" +
    "mp\"";
            this.OpenImage.Title = "\"Load Image\"";
            // 
            // lblHScale
            // 
            this.lblHScale.AutoSize = true;
            this.lblHScale.Location = new System.Drawing.Point(27, 71);
            this.lblHScale.Name = "lblHScale";
            this.lblHScale.Size = new System.Drawing.Size(231, 32);
            this.lblHScale.TabIndex = 2;
            this.lblHScale.Text = "Horizontal Scale:";
            // 
            // tckHScale
            // 
            this.tckHScale.Location = new System.Drawing.Point(264, 71);
            this.tckHScale.Name = "tckHScale";
            this.tckHScale.Size = new System.Drawing.Size(560, 114);
            this.tckHScale.TabIndex = 3;
            this.tckHScale.Scroll += new System.EventHandler(this.tckHScale_Scroll);
            // 
            // tckVScale
            // 
            this.tckVScale.Location = new System.Drawing.Point(264, 194);
            this.tckVScale.Name = "tckVScale";
            this.tckVScale.Size = new System.Drawing.Size(560, 114);
            this.tckVScale.TabIndex = 4;
            this.tckVScale.Scroll += new System.EventHandler(this.tckVScale_Scroll);
            // 
            // lblVScale
            // 
            this.lblVScale.AutoSize = true;
            this.lblVScale.Location = new System.Drawing.Point(27, 194);
            this.lblVScale.Name = "lblVScale";
            this.lblVScale.Size = new System.Drawing.Size(198, 32);
            this.lblVScale.TabIndex = 5;
            this.lblVScale.Text = "Vertical Scale:";
            // 
            // lblHScaleVal
            // 
            this.lblHScaleVal.AutoSize = true;
            this.lblHScaleVal.Location = new System.Drawing.Point(875, 71);
            this.lblHScaleVal.Name = "lblHScaleVal";
            this.lblHScaleVal.Size = new System.Drawing.Size(63, 32);
            this.lblHScaleVal.TabIndex = 6;
            this.lblHScaleVal.Text = "100";
            // 
            // lblVScaleVal
            // 
            this.lblVScaleVal.AutoSize = true;
            this.lblVScaleVal.Location = new System.Drawing.Point(875, 194);
            this.lblVScaleVal.Name = "lblVScaleVal";
            this.lblVScaleVal.Size = new System.Drawing.Size(63, 32);
            this.lblVScaleVal.TabIndex = 7;
            this.lblVScaleVal.Text = "100";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(995, 132);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(303, 130);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Use Image";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Location = new System.Drawing.Point(995, 71);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(230, 36);
            this.chkRepeat.TabIndex = 9;
            this.chkRepeat.Text = "Repeat Image";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // Background_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 933);
            this.Controls.Add(this.chkRepeat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblVScaleVal);
            this.Controls.Add(this.lblHScaleVal);
            this.Controls.Add(this.lblVScale);
            this.Controls.Add(this.tckVScale);
            this.Controls.Add(this.tckHScale);
            this.Controls.Add(this.lblHScale);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Background_Image";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckHScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckVScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.OpenFileDialog OpenImage;
        private System.Windows.Forms.ToolStripMenuItem loadNewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.Label lblHScale;
        private System.Windows.Forms.TrackBar tckHScale;
        private System.Windows.Forms.TrackBar tckVScale;
        private System.Windows.Forms.Label lblVScale;
        private System.Windows.Forms.Label lblHScaleVal;
        private System.Windows.Forms.Label lblVScaleVal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkRepeat;
    }
}