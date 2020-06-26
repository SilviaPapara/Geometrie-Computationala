using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        List<Point> points = new List<Point>();
        Dictionary<Point, string> dic = new Dictionary<Point, String>();


        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            grp = Graphics.FromImage(bmp);
            grp.TranslateTransform(pictureBox.Width / 2, pictureBox.Height / 2);
            // grp.DrawLine(new Pen(Color.Black), 30, 40, 50, 60);
        }
        public void FillTriunghi(Point A, Point B, Point C, Color c)
        {
            grp.FillPolygon(new SolidBrush(c), new Point[] { A, B, C });
        }
        public Point SymetricOx(Point p)
        {
            Point M = new Point(p.X, 0);
            int sY = p.Y * (-1);
            int sX = p.X;
            return new Point(sX, sY);

        }
        public void DrawCircle(Point p, Color color)
        {
            int radius = 8;
            //Color color = Color.Green;
            grp.DrawEllipse(new Pen(color), p.X, p.Y, radius, radius);
            grp.FillEllipse(new SolidBrush(color), p.X, p.Y, radius, radius);
        }
        public void Tricolorare()
        {
            Color galben = Color.Yellow;
            Color albastru = Color.Blue;
            Color orange = Color.Orange;
            DrawCircle(points[0], galben);
            DrawCircle(points[1], albastru);
            DrawCircle(points[2], orange);
            //DrawCircle(points[1], );
            DrawCircle(points[3], albastru);
            DrawCircle(points[9], galben);
            DrawCircle(points[5], galben);

            DrawCircle(points[4], orange);
            DrawCircle(points[8], albastru);
            DrawCircle(points[6], albastru);
            DrawCircle(points[7], orange);
            DrawCircle(points[10], orange);
            DrawCircle(points[11], albastru);


        }


        public void Tricolorare2()
        {
            Color galben = Color.Yellow;
            Color albastru = Color.Green;
            Color orange = Color.Red;
            DrawCircle(points[0], galben);
            DrawCircle(points[1], albastru);
            DrawCircle(points[2], orange);
            //DrawCircle(points[1], );
            DrawCircle(points[3], albastru);
            DrawCircle(points[5], galben);

            DrawCircle(points[4], orange);
            DrawCircle(points[6], albastru);


        }
        public void Noteaza()
        {
            Font font = new Font("Georgia", 10, FontStyle.Regular);
            for (int i = 0; i < points.Count; i++)
                grp.DrawString(dic[points[i]], font, new SolidBrush(Color.Black), points[i]);
        }
        public void DrawLinie(Point A, Point B)
        {
            grp.DrawLine(new Pen(Color.Yellow), A, B);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox.BackColor);
            points.Clear(); dic.Clear();
            points.Add(new Point(10 * 2, 0 * 2));
            points.Add(new Point(20 * 2, 20 * 2));
            points.Add(new Point(0 * 2, 70 * 2));
            points.Add(new Point(40 * 2, 90 * 2));
            points.Add(new Point(70 * 2, 70 * 2));
            points.Add(new Point(110 * 2, 40 * 2));
            points.Add(new Point(20 * 2, 80 * 2));

            for (int i = 0; i < points.Count; i++)
                dic.Add(points[i], (i + 1).ToString());

            Point[] pointArray = points.ToArray();
            Tricolorare2();
            grp.DrawPolygon(new Pen(Color.Purple), pointArray);

            Noteaza();

            //DrawCircle(points[1],Color.Green);
            // DrawCircle(points[5],Color.Green);

            DrawLinie(points[1], points[3]);
            DrawLinie(points[3], points[4]);
            DrawLinie(points[2], points[5]);
            DrawLinie(points[3], points[6]);
            DrawLinie(points[4], points[0]);

            pictureBox.Image = bmp;
        }

        private void butonDraw_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox.BackColor);
            points.Clear(); dic.Clear();
            points.Add(new Point(40 * 2, 40 * 2));
            points.Add(new Point(50 * 2, 60 * 2));
            points.Add(new Point(60 * 2, 40 * 2));
            points.Add(new Point(70 * 2, 40 * 2));
            points.Add(new Point(90 * 2, 60 * 2));
            points.Add(new Point(110 * 2, 60 * 2));

            for (int i = 5; i >= 0; i--)
                points.Add(SymetricOx(points[i]));

            for (int i = 0; i < points.Count; i++)
                dic.Add(points[i], (i + 1).ToString());

           
            Point[] pointArray = points.ToArray();
            Tricolorare();
            grp.DrawPolygon(new Pen(Color.Purple), pointArray);

            Noteaza();

           

            DrawLinie(points[5], points[3]);
            DrawLinie(points[5], points[8]);
            DrawLinie(points[5], points[7]);
            
            DrawLinie(points[3], points[9]);
            DrawLinie(points[0], points[2]);
          
            DrawLinie(points[5], points[9]);
            DrawLinie(points[9], points[0]);
            DrawLinie(points[11], points[9]);

            pictureBox.Image = bmp;
        }
    }
}
