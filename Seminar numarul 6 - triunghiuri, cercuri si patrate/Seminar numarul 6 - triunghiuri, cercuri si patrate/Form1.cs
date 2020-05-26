using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Seminar_numarul_6___triunghiuri__cercuri_si_patrate
{
   
    public partial class Form1 : Form
    {
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

        }


        Bitmap bmp;
        Graphics grp;
        
        //int xA, yA, xB, yB, xC, yC;

            //Generare PATRATE
        private void button3_Click(object sender, EventArgs e)
        {
            grp.Clear(BackColor);
            
            grp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int i = 0; i < 8; i++)
            {
                int n = 4, x, y;
                float l = (float)rnd.Next(30, 100);
                x = rnd.Next((int)l, pictureBox1.Width - (int)l);
                y = rnd.Next((int)l, pictureBox1.Height - (int)l);
                float a = (float)rnd.NextDouble() * (float)Math.PI * 2;
                Color draw = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                FigGeometrica2(n, l, new PointF(x, y), a, draw);
            }
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);

            //Culoarea de stergere a ecranului
            Color backColor = Color.Orchid;

            pictureBox1.Image = bmp;

        }

        public void FigGeometrica2(int n, float l, PointF center, float phi, Color Draw)
        {
            Pen pen = new Pen(Color.Blue);
            float unghi = (float)(Math.PI * 2) / n;
            PointF[] points = new PointF[n];
            for (int i = 0; i < n; i++)
            {
                float x = center.X + l * (float)Math.Cos(unghi * i + phi);
                float y = center.Y + l * (float)Math.Sin(unghi * i + phi);
                points[i] = new PointF(x, y);
            }
            grp.DrawPolygon(new Pen(Draw, 2), points);
        }
        //generare TRIUNGHIURI
        private void button2_Click(object sender, EventArgs e)
        {
            grp.Clear(BackColor);
            for (int i = 0; i < 8; i++)
            {

               

                PointF[] t = new PointF[3];
                t[0].X = rnd.Next(300);
                t[0].Y = rnd.Next(300);
                t[1].X = rnd.Next(300);
                t[1].Y = rnd.Next(300);
                t[2].X = rnd.Next(300);
                t[2].Y = rnd.Next(300);
                Color RandomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen p = new Pen(RandomColor, 3);
                Pen sb = new Pen(RandomColor, 3);
                //grp.FillPolygon(sb, t);
                grp.DrawPolygon(p, t);
                pictureBox1.Image = bmp;

                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            
            grp.Clear(BackColor);
            grp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int i = 0; i < 8; i++)
            {
                int n = 100, x, y;
                float l = (float)rnd.Next(30, 100);
                x = rnd.Next((int)l, pictureBox1.Width - (int)l);
                y = rnd.Next((int)l, pictureBox1.Height - (int)l);
                float a = (float)rnd.NextDouble() * (float)Math.PI * 2;
                Color draw = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                FigGeometrica2(n, l, new PointF(x, y), a, draw);
            }
            pictureBox1.Image = bmp;
        }
    }
}
