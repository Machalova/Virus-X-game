namespace HraRaketa
{
    partial class Okno
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Okno));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txt_skore = new System.Windows.Forms.Label();
            this.txt_zivoty = new System.Windows.Forms.Label();
            this.txt_palivo = new System.Windows.Forms.Label();
            this.vystup_skore = new System.Windows.Forms.ProgressBar();
            this.vystup_palivo = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(318, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = " Virus X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Location = new System.Drawing.Point(19, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 412);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HraciPole";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(411, 233);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 61);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(179, 51);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(331, 321);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(96, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txt_skore
            // 
            this.txt_skore.AutoSize = true;
            this.txt_skore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_skore.Font = new System.Drawing.Font("Century", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_skore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_skore.Location = new System.Drawing.Point(35, 519);
            this.txt_skore.Name = "txt_skore";
            this.txt_skore.Size = new System.Drawing.Size(54, 18);
            this.txt_skore.TabIndex = 6;
            this.txt_skore.Text = "Skore";
            this.txt_skore.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_zivoty
            // 
            this.txt_zivoty.AutoSize = true;
            this.txt_zivoty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_zivoty.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_zivoty.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_zivoty.Location = new System.Drawing.Point(286, 520);
            this.txt_zivoty.Name = "txt_zivoty";
            this.txt_zivoty.Size = new System.Drawing.Size(58, 18);
            this.txt_zivoty.TabIndex = 7;
            this.txt_zivoty.Text = "Životy";
            this.txt_zivoty.Click += new System.EventHandler(this.txt_zivoty_Click);
            // 
            // txt_palivo
            // 
            this.txt_palivo.AutoSize = true;
            this.txt_palivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_palivo.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_palivo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_palivo.Location = new System.Drawing.Point(625, 520);
            this.txt_palivo.Name = "txt_palivo";
            this.txt_palivo.Size = new System.Drawing.Size(71, 18);
            this.txt_palivo.TabIndex = 8;
            this.txt_palivo.Text = "Energie";
            this.txt_palivo.Click += new System.EventHandler(this.txt_palivo_Click);
            // 
            // vystup_skore
            // 
            this.vystup_skore.Location = new System.Drawing.Point(95, 519);
            this.vystup_skore.Name = "vystup_skore";
            this.vystup_skore.Size = new System.Drawing.Size(67, 21);
            this.vystup_skore.TabIndex = 9;
            // 
            // vystup_palivo
            // 
            this.vystup_palivo.Location = new System.Drawing.Point(702, 519);
            this.vystup_palivo.Name = "vystup_palivo";
            this.vystup_palivo.Size = new System.Drawing.Size(60, 21);
            this.vystup_palivo.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 508);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(402, 508);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(454, 508);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.InitialImage")));
            this.pictureBox7.Location = new System.Drawing.Point(489, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(63, 51);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.InitialImage")));
            this.pictureBox8.Location = new System.Drawing.Point(249, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(63, 51);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vystup_palivo);
            this.Controls.Add(this.vystup_skore);
            this.Controls.Add(this.txt_palivo);
            this.Controls.Add(this.txt_zivoty);
            this.Controls.Add(this.txt_skore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Okno";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_skore;
        private System.Windows.Forms.Label txt_zivoty;
        private System.Windows.Forms.Label txt_palivo;
        private System.Windows.Forms.ProgressBar vystup_skore;
        private System.Windows.Forms.ProgressBar vystup_palivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}

