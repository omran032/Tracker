namespace tracker.واجهات
{
    partial class FrmPublisher
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPublisher));
            this.ElipsePnl = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Pnl = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTelegram = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLinkedin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ElipseForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLinkedin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipsePnl
            // 
            this.ElipsePnl.BorderRadius = 100;
            this.ElipsePnl.TargetControl = this.Pnl;
            // 
            // Pnl
            // 
            this.Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Pnl.Controls.Add(this.btnTelegram);
            this.Pnl.Controls.Add(this.btnLinkedin);
            this.Pnl.Controls.Add(this.label3);
            this.Pnl.Controls.Add(this.label2);
            this.Pnl.Controls.Add(this.label1);
            this.Pnl.Controls.Add(this.PicClose);
            this.Pnl.Location = new System.Drawing.Point(2, 2);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(458, 348);
            this.Pnl.TabIndex = 0;
            // 
            // btnTelegram
            // 
            this.btnTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelegram.FillColor = System.Drawing.Color.Transparent;
            this.btnTelegram.Image = ((System.Drawing.Image)(resources.GetObject("btnTelegram.Image")));
            this.btnTelegram.ImageRotate = 0F;
            this.btnTelegram.Location = new System.Drawing.Point(237, 231);
            this.btnTelegram.Name = "btnTelegram";
            this.btnTelegram.Size = new System.Drawing.Size(40, 40);
            this.btnTelegram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTelegram.TabIndex = 7;
            this.btnTelegram.TabStop = false;
            this.btnTelegram.Click += new System.EventHandler(this.btnTelegram_Click);
            // 
            // btnLinkedin
            // 
            this.btnLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinkedin.FillColor = System.Drawing.Color.Transparent;
            this.btnLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkedin.Image")));
            this.btnLinkedin.ImageRotate = 0F;
            this.btnLinkedin.Location = new System.Drawing.Point(161, 231);
            this.btnLinkedin.Name = "btnLinkedin";
            this.btnLinkedin.Size = new System.Drawing.Size(40, 40);
            this.btnLinkedin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLinkedin.TabIndex = 6;
            this.btnLinkedin.TabStop = false;
            this.btnLinkedin.Click += new System.EventHandler(this.btnLinkedin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "لأي إقتراح أو للتواصل  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(112, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Omran Alashef";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "تم إعداد و تصميم البرنامج من قِبل المطوّر";
            // 
            // PicClose
            // 
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.FillColor = System.Drawing.Color.Transparent;
            this.PicClose.Image = ((System.Drawing.Image)(resources.GetObject("PicClose.Image")));
            this.PicClose.ImageRotate = 0F;
            this.PicClose.Location = new System.Drawing.Point(409, 19);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(24, 24);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 2;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // ElipseForm
            // 
            this.ElipseForm.BorderRadius = 100;
            this.ElipseForm.TargetControl = this;
            // 
            // FrmPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(463, 353);
            this.Controls.Add(this.Pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPublisher";
            this.TopMost = true;
            this.Pnl.ResumeLayout(false);
            this.Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLinkedin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipsePnl;
        private Guna.UI2.WinForms.Guna2Panel Pnl;
        private Guna.UI2.WinForms.Guna2Elipse ElipseForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox PicClose;
        private Guna.UI2.WinForms.Guna2PictureBox btnTelegram;
        private Guna.UI2.WinForms.Guna2PictureBox btnLinkedin;
        private System.Windows.Forms.Label label3;
    }
}