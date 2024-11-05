using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutopistaenFuga
{
    public partial class Form1 : Form
    {
        private int velocidad;
        private PictureBox[] road = new PictureBox[8];
        private int puntuaje = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            velocidad = 3;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;

        }

        private void MovimientoPista_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox p in road)
            {
                p.Top += velocidad;
                if (p.Top >= this.Height)
                {
                    p.Top = -p.Height;
                }
            }

            if (puntuaje > 10 && puntuaje < 30)
            {
                velocidad = 5;
            }
            if (puntuaje > 30 && puntuaje < 50)
            {
                velocidad = 6;
            }
            if (puntuaje > 50 && puntuaje < 70)
            {
                velocidad = 7;
            }
            if (puntuaje > 100)
            {
                velocidad = 9;
            }
            label2.Text = "Velocidad: " + velocidad;
            if((CarroPrincipal.Bounds.IntersectsWith(carro1.Bounds)))
            {
                endGame();
            }
            if ((CarroPrincipal.Bounds.IntersectsWith(carro2.Bounds)))
            {
                endGame();
            }
            if ((CarroPrincipal.Bounds.IntersectsWith(carro3.Bounds)))
            {
                endGame();
            }

        }

        private void endGame()
        {
            b1.Visible = true;
            label3.Visible = true;
            MovimientoPista.Stop();
            CarroAmarillo.Stop();
            CarroAzulFuerte.Stop();
            CarroAzulBajo.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                LadoDerecho.Start();
            }
            if (e.KeyCode == Keys.Left)
            {
                LadoIzquierdo.Start();
            }
        }

        private void LadoDerecho_Tick(object sender, EventArgs e)
        {
            if (CarroPrincipal.Location.X < 287)
            {
                CarroPrincipal.Left += 5;
            }
        }

        private void LadoIzquierdo_Tick(object sender, EventArgs e)
        {
            if (CarroPrincipal.Location.X > 0)
            {
                CarroPrincipal.Left -= 5;
            }
        }

        private void Form1KeyUp(object sender, KeyEventArgs e)
        {
            LadoDerecho.Stop();
            LadoIzquierdo.Stop();
        }

        private void CarroAmarillo_Tick(object sender, EventArgs e)
        {
            carro1.Top += velocidad / 2;
            if (carro1.Top > this.Height)
            {
                puntuaje++;
                label1.Text = "Puntuaje: " + puntuaje;

                Random rnd = new Random();
                carro1.Top = -(Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 200)) + carro1.Height);
                carro1.Left = Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 50)) + 0;
            }
        }

        private void CarroAzulFuerte_Tick(object sender, EventArgs e)
        {
            carro2.Top += velocidad / 3;
            if (carro2.Top > this.Height)
            {
                puntuaje++;
                label1.Text = "Puntuaje: " + puntuaje;

                Random rnd = new Random();
                carro2.Top = -(Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 200)) + carro2.Height);
                carro2.Left = Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 50)) + 100;
            }
        }

        private void CarroAzulBajo_Tick(object sender, EventArgs e)
        {
            carro3.Top += velocidad * 1/2;
            if (carro3.Top > this.Height)
            {
                puntuaje++;
                label1.Text = "Puntuaje: " + puntuaje;

                Random rnd = new Random();
                carro3.Top = -(Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 200)) + carro3.Height);
                carro3.Left = Convert.ToInt32(Math.Ceiling(rnd.NextDouble() * 120)) + 180;
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            puntuaje = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }
    }
}
