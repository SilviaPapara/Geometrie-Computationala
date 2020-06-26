using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_nr_7
{

   
        public partial class Form1 : Form
    {
        Graphics grp;
        Bitmap bmp;
        Color backColor;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) // linie si segment
        {
            backColor = Color.WhiteSmoke;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            //grp.DrawLine(new Pen(Color.Red, 3), 10, 10, 300, 180);

           

        }

        private void button1_Click(object sender, EventArgs e) // linie si linie - done
        {
            


            grp.Clear(backColor);
            grp.DrawLine(new Pen(Color.Black, 2), 10, 10, 300, 500); // dreapta

            grp.DrawString("d", new Font("Tahoma", 12), Brushes.Black, 200, 300);

            // Create pen.
            Pen blackPen = new Pen(Color.Red, 2); // segment

            // Create points that define line.
            PointF point1 = new PointF(30, 190);
            grp.DrawEllipse(Pens.Red, 25, 190, 7, 7);
            PointF point2 = new PointF(120, 30);
            grp.DrawEllipse(Pens.Red, 120, 25, 7, 7);

            // Draw line to screen.
            grp.DrawLine(blackPen, point1, point2);

            SolidBrush solidb = new SolidBrush(Color.Magenta);

            grp.FillEllipse(solidb, 67, 111, 9, 9);
            grp.DrawString("A", new Font("Tahoma", 12), Brushes.Black, 25, 195);
            grp.DrawString("B", new Font("Tahoma", 12), Brushes.Black, 120, 30);

            textBox1.Text = "1";

            pictureBox1.Image = bmp;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grp.Clear(backColor);

            // segment 1 
            Pen blackPen = new Pen(Color.Blue, 2); 

            //float 

            PointF point1 = new PointF(300, 200);
            grp.DrawEllipse(Pens.Blue, 300, 195, 7, 7);
            
            PointF point2 = new PointF(150, 200);
            grp.DrawEllipse(Pens.Blue, 145, 195, 7, 7);

            grp.DrawEllipse(Pens.Green, 220, 195, 8, 8);


            //grp.FillEllipse(solidb, 220, 195, 8, 8);
            grp.DrawString("A1", new Font("Tahoma", 12), Brushes.Black,300, 200);
            grp.DrawString("A2", new Font("Tahoma", 12), Brushes.Black, 150, 200);


            grp.DrawLine(blackPen, point1, point2);

           
            // segment 2
            Pen blackkPen = new Pen(Color.Red, 2); 


            PointF point3 = new PointF(250, 250);
            grp.DrawEllipse(Pens.Red, 250, 250, 7, 7);
            
            PointF point4 = new PointF(150, 50);
            grp.DrawEllipse(Pens.Red, 145, 45, 7, 7);


            grp.DrawLine(blackkPen, point3, point4);

            SolidBrush solidb = new SolidBrush(Color.Green);
            grp.DrawString("B1", new Font("Tahoma", 12), Brushes.Black, 250, 260);
            grp.DrawString("B2", new Font("Tahoma", 12), Brushes.Black, 150, 40);

            grp.FillEllipse(solidb, 220, 195, 8, 8);
            textBox1.Text = "1";
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dreapta 1

            grp.Clear(backColor);
            grp.DrawLine(new Pen(Color.BlueViolet, 2), 10, 10, 300, 500);

            grp.DrawString("d1" ,new Font("Tahoma", 12), Brushes.Black, 80, 100);


            // dreapta 2

            grp.DrawLine(new Pen(Color.DarkOliveGreen, 2), 200,400, 550,30);

            SolidBrush solidb = new SolidBrush(Color.DarkCyan);

            grp.FillEllipse(solidb, 220, 370,10,10);

            grp.DrawString("d2", new Font("Tahoma", 12), Brushes.Black, 450, 90);
            textBox1.Text = "1";

            pictureBox1.Image = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grp.Clear(backColor);
            int xM = pictureBox1.Height / 2;
            int ym = pictureBox1.Width / 2;
            Pen blackPen = new Pen(Color.Black, 1);
            Pen blackTen = new Pen(Color.Red, 1);

            Pen p = new Pen(Color.Black, 5);
            //Punctul A
            SolidBrush solida = new SolidBrush(Color.Black);
            //grp.FillEllipse(solida, 10+xM, 8+ym, 10, 10);
            PointF pointA = new PointF(10 + xM, 10 + ym);
            grp.DrawEllipse(p, 10 + xM, 8 + ym, 5, 5);
         

            //Punctul B
            SolidBrush solidb = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidb, 50+xM, 30+ym, 10, 10);
            grp.DrawEllipse(p, 50 + xM, 30 + ym, 5,5);
            PointF pointB = new PointF(50 + xM, 30 + ym);

            //Punctul C
            SolidBrush solidc = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidc, -20+xM, -30+ym, 10, 10);
            grp.DrawEllipse(p, -20 + xM, -30 + ym, 5, 5);
            PointF pointC = new PointF(-20 + xM, -30 + ym);

            //Punctul D
            SolidBrush solidd = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidd, 30+xM, -10+ym, 10, 10);
            PointF pointD = new PointF(30 + xM, -10 + ym);
            grp.DrawEllipse(p, 30 + xM, -10 + ym, 5, 5);

            //Punctul E
            SolidBrush solide = new SolidBrush(Color.Black);
           // grp.FillEllipse(solide, 30+xM, 40+ym, 10, 10);
            PointF pointE = new PointF(30 + xM, 40 + ym);
            grp.DrawEllipse(p, 30 + xM, 40 + ym, 5, 5);

            //Punctul F
            SolidBrush solidf = new SolidBrush(Color.Black);
           // grp.FillEllipse(solidf, -20+xM, -70+ym, 10, 10);
            PointF pointF = new PointF(-20 + xM, -70 + ym);
            grp.DrawEllipse(p, -20 + xM, -70 + ym, 5, 5);

            //Punctul G
            SolidBrush solidg = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidg, -40+xM, -20+ym, 10, 10);
            PointF pointG = new PointF(-40 + xM, -20 + ym);
            grp.DrawEllipse(p, -40 + xM, -20 + ym, 5, 5);

            //Punctul H
            SolidBrush solidh = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidh, 30+xM,10+ym, 10, 10);
            PointF pointH = new PointF(30 + xM, 10 + ym);
            grp.DrawEllipse(p, 30 + xM, 10 + ym, 5, 5);

            //Punctul I
            SolidBrush solidi = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidi, -20+xM, 40+ym, 10, 10);
            PointF pointI = new PointF(-20 + xM, 40 + ym);
            grp.DrawEllipse(p, -20 + xM, 40 + ym, 5,5);

            //Punctul K
            SolidBrush solidk = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidk, 30+xM, -40+ym, 10, 10);
            PointF pointK = new PointF(30 + xM, -40 + ym);
            grp.DrawEllipse(p, 30 + xM, -40 + ym, 5, 5);

            //Punctul L
            SolidBrush solidl = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidl, -30 + xM, 30 + ym, 10, 10);
            PointF pointL = new PointF(-30 + xM, 30 + ym);
            grp.DrawEllipse(p, -30 + xM, 30 + ym, 5, 5);

            //Punctul M
            SolidBrush solidm = new SolidBrush(Color.Black);
            //grp.FillEllipse(solidm, 10 + xM, 30 + ym, 10, 10);
            PointF pointM = new PointF(10 + xM, 30 + ym);
            grp.DrawEllipse(p, 10 + xM, 30 + ym, 5, 5);

            grp.DrawLine(blackPen, pointA, pointB);
            grp.DrawLine(blackPen, pointG, pointH);
            grp.DrawLine(blackPen, pointC, pointD);
            

            grp.DrawLine(blackTen, pointE, pointF);
            grp.DrawLine(blackTen, pointI, pointK);
            grp.DrawLine(blackTen, pointL, pointM);



            textBox2.Text = "Numarul de intersectii este";
            textBox1.Text = "5";
            pictureBox1.Image = bmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
