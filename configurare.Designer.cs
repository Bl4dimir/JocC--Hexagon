namespace ProiectJoc
{
    partial class configurare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(configurare));
            this.configmenu = new System.Windows.Forms.Panel();
            this.btn_dimensiune = new System.Windows.Forms.PictureBox();
            this.btn_avansat = new System.Windows.Forms.PictureBox();
            this.btn_mediu = new System.Windows.Forms.PictureBox();
            this.btn_incepator = new System.Windows.Forms.PictureBox();
            this.inapoi = new System.Windows.Forms.PictureBox();
            this.configmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_dimensiune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avansat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mediu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_incepator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inapoi)).BeginInit();
            this.SuspendLayout();
            // 
            // configmenu
            // 
            this.configmenu.BackColor = System.Drawing.Color.Transparent;
            this.configmenu.BackgroundImage = global::ProiectJoc.Properties.Resources.DIFICULTATE1;
            this.configmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.configmenu.Controls.Add(this.btn_dimensiune);
            this.configmenu.Controls.Add(this.btn_avansat);
            this.configmenu.Controls.Add(this.btn_mediu);
            this.configmenu.Controls.Add(this.btn_incepator);
            this.configmenu.Location = new System.Drawing.Point(67, 42);
            this.configmenu.Name = "configmenu";
            this.configmenu.Size = new System.Drawing.Size(238, 311);
            this.configmenu.TabIndex = 1;
            // 
            // btn_dimensiune
            // 
            this.btn_dimensiune.Image = global::ProiectJoc.Properties.Resources.dimensiune_off;
            this.btn_dimensiune.Location = new System.Drawing.Point(65, 240);
            this.btn_dimensiune.Name = "btn_dimensiune";
            this.btn_dimensiune.Size = new System.Drawing.Size(108, 43);
            this.btn_dimensiune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_dimensiune.TabIndex = 4;
            this.btn_dimensiune.TabStop = false;
            this.btn_dimensiune.Click += new System.EventHandler(this.btn_dimensiune_Click);
            this.btn_dimensiune.MouseLeave += new System.EventHandler(this.btn_dimensiune_MouseLeave);
            this.btn_dimensiune.MouseHover += new System.EventHandler(this.btn_dimensiune_MouseHover);
            // 
            // btn_avansat
            // 
            this.btn_avansat.Image = ((System.Drawing.Image)(resources.GetObject("btn_avansat.Image")));
            this.btn_avansat.Location = new System.Drawing.Point(65, 174);
            this.btn_avansat.Name = "btn_avansat";
            this.btn_avansat.Size = new System.Drawing.Size(110, 41);
            this.btn_avansat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_avansat.TabIndex = 3;
            this.btn_avansat.TabStop = false;
            this.btn_avansat.Click += new System.EventHandler(this.btn_avansat_Click);
            // 
            // btn_mediu
            // 
            this.btn_mediu.Image = ((System.Drawing.Image)(resources.GetObject("btn_mediu.Image")));
            this.btn_mediu.Location = new System.Drawing.Point(65, 107);
            this.btn_mediu.Name = "btn_mediu";
            this.btn_mediu.Size = new System.Drawing.Size(108, 47);
            this.btn_mediu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_mediu.TabIndex = 2;
            this.btn_mediu.TabStop = false;
            this.btn_mediu.Click += new System.EventHandler(this.btn_mediu_Click);
            // 
            // btn_incepator
            // 
            this.btn_incepator.Image = ((System.Drawing.Image)(resources.GetObject("btn_incepator.Image")));
            this.btn_incepator.Location = new System.Drawing.Point(64, 42);
            this.btn_incepator.Name = "btn_incepator";
            this.btn_incepator.Size = new System.Drawing.Size(109, 47);
            this.btn_incepator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_incepator.TabIndex = 1;
            this.btn_incepator.TabStop = false;
            this.btn_incepator.Click += new System.EventHandler(this.btn_incepator_Click);
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.Transparent;
            this.inapoi.Image = global::ProiectJoc.Properties.Resources.inapoi;
            this.inapoi.Location = new System.Drawing.Point(1, 348);
            this.inapoi.Name = "inapoi";
            this.inapoi.Size = new System.Drawing.Size(60, 61);
            this.inapoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inapoi.TabIndex = 2;
            this.inapoi.TabStop = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            this.inapoi.MouseLeave += new System.EventHandler(this.inapoi_MouseLeave);
            this.inapoi.MouseHover += new System.EventHandler(this.inapoi_MouseHover);
            // 
            // configurare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.configmenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "configurare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurare";
            this.configmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_dimensiune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_avansat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_mediu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_incepator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inapoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel configmenu;
        private System.Windows.Forms.PictureBox btn_avansat;
        private System.Windows.Forms.PictureBox btn_mediu;
        private System.Windows.Forms.PictureBox btn_incepator;
        private System.Windows.Forms.PictureBox btn_dimensiune;
        private System.Windows.Forms.PictureBox inapoi;
    }
}