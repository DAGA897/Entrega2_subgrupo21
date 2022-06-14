using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bitmap M = new Bitmap(Properties.Resources.Puntero3);
            Cursor r = new Cursor(M.GetHicon());
            this.Cursor = r;
        }
        int points;

        void Ballons()
        {
            if (G_1.Top < 0)
            {
                G_1.Top = 550;
                G_1.Image = Properties.Resources.Globo2;

            }
            G_1.Top -= 5;
            if (G_2.Top < 0)
            {
                G_2.Top = 550;
                G_2.Image = Properties.Resources.Globo2;

            }
            G_2.Top -= 5;
            if (G_3.Top < 0)
            {
                G_3.Top = 550;
                G_3.Image = Properties.Resources.Globo2;

            }
            G_3.Top -= 5;
            if (G_4.Top < 0)
            {
                G_4.Top = 550;
                G_4.Image = Properties.Resources.Globo2;

            }
            G_4.Top -= 5;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            points++;
            Points.Text = "Points : " + points;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ballons();
        }

        private void G_2_Click(object sender, EventArgs e)
        {
            points++;
            Points.Text = "Points : " + points;
        }

        private void G_3_Click(object sender, EventArgs e)
        {
            points++;
            Points.Text = "Points : " + points;
        }

        private void G_4_Click(object sender, EventArgs e)
        {
            points++;
            Points.Text = "Points : " + points;
        }
    }
}
