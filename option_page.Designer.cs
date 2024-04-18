namespace ProiectJoc
{
    partial class option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(option));
            this.option_menu = new System.Windows.Forms.Panel();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.inapoi = new System.Windows.Forms.PictureBox();
            this.option_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inapoi)).BeginInit();
            this.SuspendLayout();
            // 
            // option_menu
            // 
            this.option_menu.BackColor = System.Drawing.Color.Transparent;
            this.option_menu.BackgroundImage = global::ProiectJoc.Properties.Resources.optiuni;
            this.option_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_menu.Controls.Add(this.btn_sound);
            this.option_menu.Controls.Add(this.trackBar1);
            this.option_menu.Location = new System.Drawing.Point(67, 42);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(238, 311);
            this.option_menu.TabIndex = 0;
            // 
            // btn_sound
            // 
            this.btn_sound.Image = global::ProiectJoc.Properties.Resources.sound_on;
            this.btn_sound.Location = new System.Drawing.Point(99, 194);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(50, 50);
            this.btn_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_sound.TabIndex = 1;
            this.btn_sound.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(72, 124);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.Transparent;
            this.inapoi.Image = global::ProiectJoc.Properties.Resources.inapoi;
            this.inapoi.Location = new System.Drawing.Point(1, 347);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(60, 61);
            this.inapoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inapoi.TabIndex = 3;
            this.inapoi.TabStop = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            this.inapoi.MouseLeave += new System.EventHandler(this.inapoi_MouseLeave_1);
            this.inapoi.MouseHover += new System.EventHandler(this.inapoi_MouseHover_1);
            // 
            // option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.option_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opțiuni";
            this.option_menu.ResumeLayout(false);
            this.option_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inapoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel option_menu;
        private System.Windows.Forms.PictureBox btn_sound;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox inapoi;
    }
}