namespace ProiectJoc
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
            this.menu = new System.Windows.Forms.Panel();
            this.btn_config = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.btn_optiuni = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_optiuni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.BackgroundImage = global::ProiectJoc.Properties.Resources.menu1;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.btn_config);
            this.menu.Controls.Add(this.btn_exit);
            this.menu.Controls.Add(this.btn_optiuni);
            this.menu.Controls.Add(this.btn_start);
            this.menu.Location = new System.Drawing.Point(67, 42);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(238, 311);
            this.menu.TabIndex = 4;
            // 
            // btn_config
            // 
            this.btn_config.Image = global::ProiectJoc.Properties.Resources.config1_hover;
            this.btn_config.Location = new System.Drawing.Point(63, 128);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(121, 39);
            this.btn_config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_config.TabIndex = 3;
            this.btn_config.TabStop = false;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click_1);
            this.btn_config.MouseLeave += new System.EventHandler(this.btn_config_MouseLeave);
            this.btn_config.MouseHover += new System.EventHandler(this.btn_config_MouseHover_1);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::ProiectJoc.Properties.Resources.exit_hover;
            this.btn_exit.Location = new System.Drawing.Point(63, 247);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(121, 39);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_exit.TabIndex = 2;
            this.btn_exit.TabStop = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
            this.btn_exit.MouseHover += new System.EventHandler(this.btn_exit_MouseHover);
            // 
            // btn_optiuni
            // 
            this.btn_optiuni.Image = global::ProiectJoc.Properties.Resources.optiuni1_hover;
            this.btn_optiuni.Location = new System.Drawing.Point(63, 186);
            this.btn_optiuni.Name = "btn_optiuni";
            this.btn_optiuni.Size = new System.Drawing.Size(121, 42);
            this.btn_optiuni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_optiuni.TabIndex = 1;
            this.btn_optiuni.TabStop = false;
            this.btn_optiuni.Click += new System.EventHandler(this.btn_optiuni_Click);
            this.btn_optiuni.MouseLeave += new System.EventHandler(this.btn_optiuni_MouseLeave);
            this.btn_optiuni.MouseHover += new System.EventHandler(this.btn_optiuni_MouseHover);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::ProiectJoc.Properties.Resources.start_hover;
            this.btn_start.Location = new System.Drawing.Point(63, 66);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(121, 42);
            this.btn_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_start.TabIndex = 0;
            this.btn_start.TabStop = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            this.btn_start.MouseLeave += new System.EventHandler(this.btn_start_MouseLeave);
            this.btn_start.MouseHover += new System.EventHandler(this.btn_start_MouseHover);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(36, 22);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_config)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_optiuni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menu;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_optiuni;
        private System.Windows.Forms.PictureBox btn_start;
        private System.Windows.Forms.PictureBox btn_config;
    }
}

