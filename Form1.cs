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
            //Con esta linea de codigo se cambia el simbolo del cursor para que tenga la forma del objeto seleccionado
            Bitmap M = new Bitmap(Properties.Resources.Puntero3);
            Cursor r = new Cursor(M.GetHicon());
            this.Cursor = r;
        }
        //Declaramos la variable points, con la cual haremos el contador, será llamada a la acción más adelante
        int points;
        int selección = 1;
        
        

        //Creamos el bloque Ballons dentro del cual le diremos en que dirección y a que velocidad se moveran los globos
        void Ballons()
        {
            if (G_1.Top < 0)
            {
                //Con este if decimos el elemento que irá en la pantalla y la dirección  en la cual irá
                G_1.Top = 550;
                G_1.Image = Properties.Resources.Globo2;

            }
            G_1.Top -= 1;
            if (G_2.Top < 0)
            {
                G_2.Top = 550;
                G_2.Image = Properties.Resources.Globo2;

            }
            G_2.Top -= 1;
            if (G_3.Top < 0)
            {
                G_3.Top = 550;
                G_3.Image = Properties.Resources.Globo2;

            }
            G_3.Top -= 1;
            if (G_4.Top < 0)
            {
                G_4.Top = 550;
                G_4.Image = Properties.Resources.Globo2;

            }
            G_4.Top -= 1;
        }

        void respuestasd()
        {
            if (o_1.Top < 0)
            {
                //Con este if decimos el elemento que irá en la pantalla y la dirección  en la cual irá
                o_1.Top = 550;
                

            }
            o_1.Top -= 1;
            if (o_2.Top < 0)
            {
                o_2.Top = 550;
               

            }
            o_2.Top -= 1;
            if (o_3.Top < 0)
            {
                o_3.Top = 550;
               
            }
            o_3.Top -= 1;
            if (o_4.Top < 0)
            {
                o_4.Top = 550;
               

            }
            o_4.Top -= 1;
        }
        private void iniciar()
        {
            this.Pregunats.Text = "7 * 8";
            this.o_1.Text = "54";
            this.o_2.Text = "56";
            this.o_3.Text = "48";
            this.o_4.Text = "63";
            selección++;
        }
        private void Pregunta2()
        {
            this.Pregunats.Text = "carro en inglés";
            this.o_1.Text = "Cat";
            this.o_2.Text = "Car";
            this.o_3.Text = "Trash";
            this.o_4.Text = "Cash";
            selección++;
        }
        private void Pregunta3()
        {
            this.Pregunats.Text = "Sombrero en inglés";
            this.o_1.Text = "Sock";
            this.o_2.Text = "Shoes";
            this.o_3.Text = "Short";
            this.o_4.Text = "Hat";
            selección++;
        }
        private void Pregunta4()
        {
            this.Pregunats.Text = " 85 / 5";
            this.o_1.Text = "25";
            this.o_2.Text = "17";
            this.o_3.Text = "33";
            this.o_4.Text = "19";
            selección++;
        }
        private void Pregunta5()
        {
            this.Pregunats.Text = " 347 + 589";
            this.o_1.Text = "926";
            this.o_2.Text = "946";
            this.o_3.Text = "936";
            this.o_4.Text = "1126";
            selección++;
        }
        private void Pregunta6()
        {
            this.Pregunats.Text = "queso en inglés";
            this.o_1.Text = "Chess";
            this.o_2.Text = "Cheer";
            this.o_3.Text = "Cherry";
            this.o_4.Text = "Chees";
            selección++;
        }
        private void Pregunta7()
        {
            this.Pregunats.Text = "oso en inglés";
            this.o_1.Text = "Bear";
            this.o_2.Text = "Bird";
            this.o_3.Text = "Beer";
            this.o_4.Text = "Bee";
            selección++;
        }
        private void Pregunta8()
        {
            this.Pregunats.Text = "79 * 125";
            this.o_1.Text = "12.563";
            this.o_2.Text = "10.468";
            this.o_3.Text = "9875";
            this.o_4.Text = "9897";
            selección++;
        }
        private void Pregunta9()
        {
            this.Pregunats.Text = "7589 / 57";
            this.o_1.Text = "254,84";
            this.o_2.Text = "133,14";
            this.o_3.Text = "150,32";
            this.o_4.Text = "210,06";
            selección++;
        }
        private void Pregunta10()
        {
            this.Pregunats.Text = "Cajero en inglés";
            this.o_1.Text = "AT&T";
            this.o_2.Text = "DHL";
            this.o_3.Text = "ATM";
            this.o_4.Text = "IBM";
            selección++;
        }
        private void Limpiar()
        {
            this.o_1.Visible = true;
        }



        void cloud()
        {
            if (Nubecita.Visible)
            {
                Nubecita.Image = Properties.Resources.Nubes;
            }
            if (Nubecita2.Visible)
            {
                Nubecita.Image = Properties.Resources.Nubes;
            }
        }
         void Lat()
        {
            if (L_1.Left < 0)
            {
                L_1.Left = 550;
                L_1.Image = Properties.Resources.Latidos;
            }
            if (L_2.Left < 0)
            {
                L_2.Left = 550;
                L_2.Image = Properties.Resources.Latidos;
            }
            if(L_3.Left < 0)
            {
                L_3.Left = 550;
                L_3.Image = Properties.Resources.Latidos;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Inicializamos el contador, cada que le demos click a los globos estos sumarán puntos 
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ballons();
            Lat();
            respuestasd();
            
        }

        private void G_2_Click(object sender, EventArgs e)
        {
           
        }

        private void G_3_Click(object sender, EventArgs e)
        {
           
        }

        private void G_4_Click(object sender, EventArgs e)
        {
            
        }

        private void L_3_Click(object sender, EventArgs e)
        {

        }

       
        
        private void button3_Click(object sender, EventArgs e)
        {
            switch (selección)
            {
                case 1:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.o_4.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.o_4.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.o_4.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    if (points >= 5)
                    {
                        MessageBox.Show(points.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(points.ToString(), "Sigue intentando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    break;
                default:
                    break;
            }
             }

        private void o_1_Click(object sender, EventArgs e)
        {
            switch (selección)
            {
                case 1:
                    if (this.o_1.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.o_1.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.o_1.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    if (points >= 5)
                    {
                        MessageBox.Show(points.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(points.ToString(), "Sigue intentando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    break;
                default:
                    break;

            }
        }

        private void o_2_Click(object sender, EventArgs e)
        {
            switch (selección)
            {
                case 1:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.o_2.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.o_2.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.o_2.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.o_2.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }

                    if (points >= 5)
                    {
                        MessageBox.Show(points.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(points.ToString(), "Sigue intentando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                    break;
                default:
                    break;
            }
        }

        private void o_3_Click(object sender, EventArgs e)
        {
            switch (selección)
            {
                case 1:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.o_3.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.o_3.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta9();
                    Limpiar();
                    break;

                case 9:
                    if (this.o_3.Visible == true)
                    {
                        points--;

                        Points.Text = "Points : " + points * 100;
                    }
                    Pregunta10();
                    Limpiar();
                    break;

                case 10:
                    if (this.o_3.Visible == true)
                    {
                        points++;

                        Points.Text = "Points : " + points * 100;
                    }

                    if (points >= 5)
                    {
                        MessageBox.Show(points.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show(points.ToString(), "Sigue intentando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }

                    break;
                default:
                    break;
            }
        }
        

    }
}
