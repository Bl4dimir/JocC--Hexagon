namespace ProiectJoc
{
    partial class dimensiune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dimensiune));
            this.dimensiunemenu = new System.Windows.Forms.Panel();
            this.btn_timp = new System.Windows.Forms.PictureBox();
            this.btn_mare = new System.Windows.Forms.PictureBox();
            this.btn_mediu = new System.Windows.Forms.PictureBox();
            this.btn_mic = new System.Windows.Forms.PictureBox();
            this.inapoi = new System.Windows.Forms.PictureBox();
            this.trove = new System.Windows.Forms.PictureBox();
            this.dimensiunemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_timp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mediu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inapoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trove)).BeginInit();
            this.SuspendLayout();
            // 
            // dimensiunemenu
            // 
            this.dimensiunemenu.BackColor = System.Drawing.Color.Transparent;
            this.dimensiunemenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dimensiunemenu.BackgroundImage")));
            this.dimensiunemenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dimensiunemenu.Controls.Add(this.trove);
            this.dimensiunemenu.Controls.Add(this.btn_timp);
            this.dimensiunemenu.Controls.Add(this.btn_mare);
            this.dimensiunemenu.Controls.Add(this.btn_mediu);
            this.dimensiunemenu.Controls.Add(this.btn_mic);
            this.dimensiunemenu.Location = new System.Drawing.Point(67, 12);
            this.dimensiunemenu.Name = "dimensiunemenu";
            this.dimensiunemenu.Size = new System.Drawing.Size(238, 341);
            this.dimensiunemenu.TabIndex = 0;
            // 
            // btn_timp
            // 
            this.btn_timp.Image = global::ProiectJoc.Properties.Resources.timp_off;
            this.btn_timp.Location = new System.Drawing.Point(69, 275);
            this.btn_timp.Name = "btn_timp";
            this.btn_timp.Size = new System.Drawing.Size(100, 43);
            this.btn_timp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_timp.TabIndex = 4;
            this.btn_timp.TabStop = false;
            this.btn_timp.Click += new System.EventHandler(this.btn_timp_Click);
            this.btn_timp.MouseLeave += new System.EventHandler(this.btn_timp_MouseLeave);
            this.btn_timp.MouseHover += new System.EventHandler(this.btn_timp_MouseHover);
            // 
            // btn_mare
            // 
            this.btn_mare.Image = global::ProiectJoc.Properties.Resources.mare;
            this.btn_mare.Location = new System.Drawing.Point(69, 226);
            this.btn_mare.Name = "btn_mare";
            this.btn_mare.Size = new System.Drawing.Size(100, 43);
            this.btn_mare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_mare.TabIndex = 3;
            this.btn_mare.TabStop = false;
            this.btn_mare.Click += new System.EventHandler(this.btn_mare_Click);
            // 
            // btn_mediu
            // 
            this.btn_mediu.Image = global::ProiectJoc.Properties.Resources.mediu;
            this.btn_mediu.Location = new System.Drawing.Point(69, 177);
            this.btn_mediu.Name = "btn_mediu";
            this.btn_mediu.Size = new System.Drawing.Size(100, 43);
            this.btn_mediu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_mediu.TabIndex = 2;
            this.btn_mediu.TabStop = false;
            this.btn_mediu.Click += new System.EventHandler(this.btn_mediu_Click);
            // 
            // btn_mic
            // 
            this.btn_mic.Image = global::ProiectJoc.Properties.Resources.mic;
            this.btn_mic.Location = new System.Drawing.Point(69, 128);
            this.btn_mic.Name = "btn_mic";
            this.btn_mic.Size = new System.Drawing.Size(100, 43);
            this.btn_mic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_mic.TabIndex = 1;
            this.btn_mic.TabStop = false;
            this.btn_mic.Click += new System.EventHandler(this.btn_mic_Click);
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.Transparent;
            this.inapoi.Image = global::ProiectJoc.Properties.Resources.inapoi;
            this.inapoi.Location = new System.Drawing.Point(1, 348);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(60, 61);
            this.inapoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inapoi.TabIndex = 3;
            this.inapoi.TabStop = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            this.inapoi.MouseLeave += new System.EventHandler(this.inapoi_MouseLeave);
            this.inapoi.MouseHover += new System.EventHandler(this.inapoi_MouseHover);
            // 
            // trove
            // 
            this.trove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trove.Image = global::ProiectJoc.Properties.Resources.trovedim;
            this.trove.Location = new System.Drawing.Point(69, 34);
            this.trove.Name = "trove";
            this.trove.Size = new System.Drawing.Size(99, 88);
            this.trove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trove.TabIndex = 5;
            this.trove.TabStop = false;
            // 
            // dimensiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.dimensiunemenu);
            this.Name = "dimensiune";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dimensiune";
            this.dimensiunemenu.ResumeLayout(false);
            this.dimensiunemenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_timp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mediu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inapoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dimensiunemenu;
        private System.Windows.Forms.PictureBox inapoi;
        private System.Windows.Forms.PictureBox btn_mic;
        private System.Windows.Forms.PictureBox btn_mare;
        private System.Windows.Forms.PictureBox btn_mediu;
        private System.Windows.Forms.PictureBox btn_timp;
        private System.Windows.Forms.PictureBox trove;
    }
}