
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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            wplayer.URL = (@"E:\ProiectJoc\Resources\gmfundal.wav");
              wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
            

        }

         public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start1_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;

        }

        private void btn_optiuni_MouseHover(object sender, EventArgs e)
        {
            btn_optiuni.Image = Properties.Resources.optiuni2_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_optiuni_MouseLeave(object sender, EventArgs e)
        {
            btn_optiuni.Image = Properties.Resources.optiuni1_hover;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.iesire_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_optiuni_Click(object sender, EventArgs e)
        {
            option option = new option();
            option.ShowDialog();
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btn_config_MouseHover_1(object sender, EventArgs e)
        {
            btn_config.Image = Properties.Resources.config_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"E:\ProiectJoc\Resources\sunetbuton1.wav");
            sound.Play();
        }

        private void btn_config_MouseLeave(object sender, EventArgs e)
        {
            btn_config.Image = Properties.Resources.config1_hover;
        }

        private void btn_config_Click_1(object sender, EventArgs e)
        { 
            configurare option = new configurare();
            option.ShowDialog();

        }
    }
}
