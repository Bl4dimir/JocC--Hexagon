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
    public partial class TextEffect : Label
    {
        public TextEffect()
        {
            InitializeComponent();
            UseCompatibleTextRendering = true;
            this.BackColor = Color.White;
            timer1.Start();
        }
        int position, speed;
        public int Set_Speed { get { return speed; } set { speed = value; Invalidate(); } }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TranslateTransform((float)position, 0);
            base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (position <- Width);
            {
                position = Width;
            }
            position -= speed;
            Invalidate();
        }
    }
}
