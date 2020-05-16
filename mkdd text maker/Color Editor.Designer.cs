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
            this.txtCone = new System.Windows.Forms.Label();
            this.txtCtwo = new System.Windows.Forms.Label();
            this.txt1r = new System.Windows.Forms.TextBox();
            this.txt1g = new System.Windows.Forms.TextBox();
            this.txt1b = new System.Windows.Forms.TextBox();
            this.txt2r = new System.Windows.Forms.TextBox();
            this.txt2g = new System.Windows.Forms.TextBox();
            this.txt2b = new System.Windows.Forms.TextBox();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCtwo = new System.Windows.Forms.Button();
            this.cmbGrads = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picGrad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGrad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCone
            // 
            this.txtCone.AutoSize = true;
            this.txtCone.Location = new System.Drawing.Point(30, 24);
            this.txtCone.Name = "txtCone";
            this.txtCone.Size = new System.Drawing.Size(114, 32);
            this.txtCone.TabIndex = 0;
            this.txtCone.Text = "Color 1:";
            // 
            // txtCtwo
            // 
            this.txtCtwo.AutoSize = true;
            this.txtCtwo.Location = new System.Drawing.Point(30, 98);
            this.txtCtwo.Name = "txtCtwo";
            this.txtCtwo.Size = new System.Drawing.Size(114, 32);
            this.txtCtwo.TabIndex = 1;
            this.txtCtwo.Text = "Color 2:";
            // 
            // txt1r
            // 
            this.txt1r.Location = new System.Drawing.Point(151, 21);
            this.txt1r.Name = "txt1r";
            this.txt1r.Size = new System.Drawing.Size(100, 38);
            this.txt1r.TabIndex = 2;
            this.txt1r.Text = "255";
            this.txt1r.Leave += new System.EventHandler(this.txt1r_TextChanged);
            // 
            // txt1g
            // 
            this.txt1g.Location = new System.Drawing.Point(283, 21);
            this.txt1g.Name = "txt1g";
            this.txt1g.Size = new System.Drawing.Size(100, 38);
            this.txt1g.TabIndex = 3;
            this.txt1g.Text = "255";
            this.txt1g.Leave += new System.EventHandler(this.txt1r_TextChanged);
            // 
            // txt1b
            // 
            this.txt1b.Location = new System.Drawing.Point(415, 21);
            this.txt1b.Name = "txt1b";
            this.txt1b.Size = new System.Drawing.Size(100, 38);
            this.txt1b.TabIndex = 4;
            this.txt1b.Text = "255";
            this.txt1b.Leave += new System.EventHandler(this.txt1r_TextChanged);
            // 
            // txt2r
            // 
            this.txt2r.Location = new System.Drawing.Point(151, 95);
            this.txt2r.Name = "txt2r";
            this.txt2r.Size = new System.Drawing.Size(100, 38);
            this.txt2r.TabIndex = 5;
            this.txt2r.Text = "255";
            this.txt2r.Leave += new System.EventHandler(this.txt2b_TextChanged);
            // 
            // txt2g
            // 
            this.txt2g.Location = new System.Drawing.Point(283, 95);
            this.txt2g.Name = "txt2g";
            this.txt2g.Size = new System.Drawing.Size(100, 38);
            this.txt2g.TabIndex = 6;
            this.txt2g.Text = "255";
            this.txt2g.Leave += new System.EventHandler(this.txt2b_TextChanged);
            // 
            // txt2b
            // 
            this.txt2b.Location = new System.Drawing.Point(415, 95);
            this.txt2b.Name = "txt2b";
            this.txt2b.Size = new System.Drawing.Size(100, 38);
            this.txt2b.TabIndex = 7;
            this.txt2b.Text = "255";
            this.txt2b.Leave += new System.EventHandler(this.txt2b_TextChanged);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(548, 17);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(314, 47);
            this.btnCone.TabIndex = 8;
            this.btnCone.Text = "Open Color Picker";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // btnCtwo
            // 
            this.btnCtwo.Location = new System.Drawing.Point(548, 91);
            this.btnCtwo.Name = "btnCtwo";
            this.btnCtwo.Size = new System.Drawing.Size(314, 47);
            this.btnCtwo.TabIndex = 9;
            this.btnCtwo.Text = "Open Color Picker";
            this.btnCtwo.UseVisualStyleBackColor = true;
            this.btnCtwo.Click += new System.EventHandler(this.btnCtwo_Click);
            // 
            // cmbGrads
            // 
            this.cmbGrads.FormattingEnabled = true;
            this.cmbGrads.Items.AddRange(new object[] {
            "Gradient 0"});
            this.cmbGrads.Location = new System.Drawing.Point(36, 196);
            this.cmbGrads.Name = "cmbGrads";
            this.cmbGrads.Size = new System.Drawing.Size(638, 39);
            this.cmbGrads.TabIndex = 10;
            this.cmbGrads.SelectedIndexChanged += new System.EventHandler(this.cmbGrads_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(888, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(325, 125);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add New Gradient";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gradients:";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(888, 332);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(325, 125);
            this.btnDone.TabIndex = 13;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(888, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(325, 125);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Gradient";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picGrad
            // 
            this.picGrad.Location = new System.Drawing.Point(687, 175);
            this.picGrad.Name = "picGrad";
            this.picGrad.Size = new System.Drawing.Size(175, 275);
            this.picGrad.TabIndex = 15;
            this.picGrad.TabStop = false;
            // 
            // Color_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 479);
            this.Controls.Add(this.picGrad);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGrads);
            this.Controls.Add(this.btnCtwo);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.txt2b);
            this.Controls.Add(this.txt2g);
            this.Controls.Add(this.txt2r);
            this.Controls.Add(this.txt1b);
            this.Controls.Add(this.txt1g);
            this.Controls.Add(this.txt1r);
            this.Controls.Add(this.txtCtwo);
            this.Controls.Add(this.txtCone);
            this.Name = "Color_Editor";
            this.Text = "Color_Editor";
            ((System.ComponentModel.ISupportInitialize)(this.picGrad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCone;
        private System.Windows.Forms.Label txtCtwo;
        private System.Windows.Forms.TextBox txt1r;
        private System.Windows.Forms.TextBox txt1g;
        private System.Windows.Forms.TextBox txt1b;
        private System.Windows.Forms.TextBox txt2r;
        private System.Windows.Forms.TextBox txt2g;
        private System.Windows.Forms.TextBox txt2b;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Button btnCtwo;
        private System.Windows.Forms.ComboBox cmbGrads;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picGrad;
    }
}