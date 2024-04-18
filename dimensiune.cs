
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
    public partial class dimensiune : Form
    {

        public dimensiune()
        {
            InitializeComponent();
                     

        }

        private void inapoi_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
            inapoi.Image = Properties.Resources.inapoi_apas;
        }

        private void inapoi_MouseLeave(object sender, EventArgs e)
        {
            inapoi.Image = Properties.Resources.inapoi;
        }
        private void inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            configurare frm = new configurare();
            frm.Show();
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }
        private void btn_mic_Click(object sender, EventArgs e)
        {
            if (btn_mic.Enabled == true)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();

            }
            btn_mic.Image = Properties.Resources.mic_off;
            btn_mic.Enabled = false;
            btn_mediu.Enabled = true;
            btn_mare.Enabled = true;
            btn_mediu.Image = Properties.Resources.mediu;
            btn_mare.Image = Properties.Resources.mare;
            trove.Image = Properties.Resources.trovemic;
        }

        private void btn_mediu_Click(object sender, EventArgs e)
        {
            if (btn_mediu.Enabled == true)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();

            }
            btn_mediu.Image = Properties.Resources.mediu_off;
            btn_mediu.Enabled = false;
            btn_mic.Enabled = true;
            btn_mare.Enabled = true;
            btn_mic.Image = Properties.Resources.mic;
            btn_mare.Image = Properties.Resources.mare;
            trove.Image = Properties.Resources.trove1;
        }

        private void btn_mare_Click(object sender, EventArgs e)
        {
            if (btn_mare.Enabled == true)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();

            }
            btn_mare.Image = Properties.Resources.mare_off;
            btn_mare.Enabled = false;
            btn_mediu.Enabled = true;
            btn_mic.Enabled = true;
            btn_mediu.Image = Properties.Resources.mediu;
            btn_mic.Image = Properties.Resources.mic;
            trove.Image = Properties.Resources.trove;
        }

        private void btn_timp_Click(object sender, EventArgs e)
        {
            if (btn_mare.Enabled == false || btn_mic.Enabled == false || btn_mediu.Enabled == false)
            {
                btn_timp.Image = Properties.Resources.timp;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();
                Form option = new Form();
                option.ShowDialog();
                this.Hide();
            }
        }

        private void btn_timp_MouseHover(object sender, EventArgs e)
        {
            if (btn_mare.Enabled == false || btn_mic.Enabled == false || btn_mediu.Enabled == false)
            {
                btn_timp.Image = Properties.Resources.timp;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();
            }
        }

        private void btn_timp_MouseLeave(object sender, EventArgs e)
        {
            if (btn_mare.Enabled == false || btn_mic.Enabled == false || btn_mediu.Enabled == false)
            {
                btn_timp.Image = Properties.Resources.timp_off;
            }
        }
        
    }
}
