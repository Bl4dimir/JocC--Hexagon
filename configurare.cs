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
    public partial class configurare : Form
    {
        
        public configurare()
        {
            InitializeComponent();

        }

        private void btn_incepator_Click(object sender, EventArgs e)
        {
            if (btn_incepator.Enabled == true)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();

            }
            btn_incepator.Image = Properties.Resources.usor_off;
            btn_incepator.Enabled = false;
            btn_mediu.Enabled = true;
            btn_avansat.Enabled = true;
            btn_mediu.Image = Properties.Resources.mediu;
            btn_avansat.Image = Properties.Resources.avansat;
        }

        private void btn_mediu_Click(object sender, EventArgs e)
        {
            if(btn_mediu.Enabled == true)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();

            }
            btn_mediu.Image = Properties.Resources.mediu_off;
            btn_mediu.Enabled = false;
            btn_avansat.Enabled = true;
            btn_incepator.Enabled = true;
            btn_avansat.Image = Properties.Resources.avansat;
            btn_incepator.Image = Properties.Resources.usor;
        }

        private void btn_avansat_Click(object sender, EventArgs e)
        {
            if(btn_avansat.Enabled == true)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();
            }
            btn_avansat.Image = Properties.Resources.avansat_off;
            btn_avansat.Enabled = false;
            btn_mediu.Enabled = true;
            btn_incepator.Enabled = true;
            btn_mediu.Image = Properties.Resources.mediu;
            btn_incepator.Image = Properties.Resources.usor;
        }

        private void btn_dimensiune_Click(object sender, EventArgs e)
        {
            if(btn_avansat.Enabled == false || btn_incepator.Enabled == false || btn_mediu.Enabled == false)
            {
                btn_dimensiune.Image = Properties.Resources.dimensiune;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();
                dimensiune option = new dimensiune();
                option.ShowDialog();
                this.Hide();
            }
            
        }

        private void btn_dimensiune_MouseHover(object sender, EventArgs e)
        {
            if (btn_avansat.Enabled == false || btn_incepator.Enabled == false || btn_mediu.Enabled == false)
            {
                btn_dimensiune.Image = Properties.Resources.dimensiune;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
                sound.Play();
            }
        }

        private void btn_dimensiune_MouseLeave(object sender, EventArgs e)
        {
            if (btn_avansat.Enabled == false || btn_incepator.Enabled == false || btn_mediu.Enabled == false)
            {
                btn_dimensiune.Image = Properties.Resources.dimensiune_off;
            }
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            configurare back = new configurare();
            back.Show();
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
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
    }
}
