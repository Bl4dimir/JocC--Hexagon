using System.Drawing;
using System.Windows.Forms;

namespace Joculet
{
    partial class Joculet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.mesajpion = new System.Windows.Forms.Label();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.inchidejocin = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(10, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 659);
            this.panel1.TabIndex = 0;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Showcard Gothic", 27.75F);
            this.timerLabel.Location = new System.Drawing.Point(279, 24);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 46);
            this.timerLabel.TabIndex = 0;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Italic);
            this.scoreLabel.Location = new System.Drawing.Point(31, 24);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 46);
            this.scoreLabel.TabIndex = 1;
            // 
            // mesajpion
            // 
            this.mesajpion.AutoSize = true;
            this.mesajpion.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic);
            this.mesajpion.Location = new System.Drawing.Point(170, 39);
            this.mesajpion.Name = "mesajpion";
            this.mesajpion.Size = new System.Drawing.Size(0, 36);
            this.mesajpion.TabIndex = 2;
            // 
            // countdownLabel
            // 
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Italic);
            this.countdownLabel.Location = new System.Drawing.Point(336, 24);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(0, 44);
            this.countdownLabel.TabIndex = 3;
            // 
            // inchidejocin
            // 
            this.inchidejocin.AutoSize = true;
            this.inchidejocin.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Italic);
            this.inchidejocin.Location = new System.Drawing.Point(661, 24);
            this.inchidejocin.Name = "inchidejocin";
            this.inchidejocin.Size = new System.Drawing.Size(0, 44);
            this.inchidejocin.TabIndex = 4;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // Joculet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 902);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.inchidejocin);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.mesajpion);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Joculet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Panel panel1;
        private Label scoreLabel;
        private Label mesajpion;
        private Label countdownLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private Label inchidejocin;
        private System.Windows.Forms.Timer Timer;
        private Label timerLabel;
    }
}