using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectJoc
{
    public partial class option : Form
    {
        public option()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.wplayer.controls.play();
            btn_sound.Image = Properties.Resources.sound_on;
            Form1.wplayer.settings.volume = trackBar1.Value;
            
            if(trackBar1.Value == 0)
            {
                btn_sound.Image = Properties.Resources.sound_off;
            }
        }
        private void inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }
        private void inapoi_MouseHover_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
            inapoi.Image = Properties.Resources.inapoi_apas;
        }

        private void inapoi_MouseLeave_1(object sender, EventArgs e)
        {
            inapoi.Image = Properties.Resources.inapoi;
        }
    }
}
