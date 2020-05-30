using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_9___Bun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Graphics grp;
        Bitmap bmp;
        List<Point> points;
        HashSet<Point> CHS;
        Dictionary<Point, string> pointText;
        Random rnd;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
        }

        private void Generare_Click(object sender, EventArgs e) // Buton pt Jarvis
        {
            grp.Clear(pictureBox1.BackColor);
            points = new List<Point>();
            pointText = new Dictionary<Point, string>();

            int n = (int)UpDownPointCount.Value;
            if (n < 2)
            {
                MessageBox.Show("Va rog sa introduceti numarul de puncte ");
                return;
            }
            points = GetRandomPoints(n);
            for (int i = 0; i < points.Count; i++)
                pointText.Add(points[i], "P" + (i + 1));

            DrawPoints(points, Color.Black, true);
            DrawHull();

            pictureBox1.Image = bmp;
        }

        private void DrawPoints(List<Point> points, Color PointColor, bool text)
        {
            int pointWidth = 3;



            Font textFont = new Font("Arial", 9, FontStyle.Regular);
            for (int i = 0; i < points.Count; i++)
            {
                grp.DrawEllipse(new Pen(PointColor, pointWidth), points[i].X, points[i].Y, pointWidth, pointWidth);
                grp.FillEllipse(new SolidBrush(PointColor), points[i].X, points[i].Y, pointWidth, pointWidth);
                if (text == true)
                    grp.DrawString("P" + (i + 1), textFont, new SolidBrush(Color.Black), points[i]);
            }

        }

        List<Point> GetRandomPoints(int n)
        {
            rnd = new Random((int)System.DateTime.Now.Ticks);
            List<Point> returnPoints = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                Point toAdd;
                do
                {
                    int x = rnd.Next() % (pictureBox1.Width - 10);
                    int y = rnd.Next() % (pictureBox1.Height - 5);
                    toAdd = new Point(x, y);
                } while (returnPoints.Contains(toAdd));
                returnPoints.Add(toAdd);
            }
            return returnPoints;
        }

        #region Quick Hull
       
        int findSide(Point p1, Point p2, Point p)
        {
            int val = (p.Y - p1.Y)*(p2.X - p1.X) - (p2.Y - p1.Y)*(p.X - p1.X);

            if (val > 0)
                return 1;
            if (val < 0)
                return -1;
            return 0;
        }
        int SquaredDistance(Point p1, Point p2)
        {
            return Math.Abs((p2.Y - p1.Y)*(p2.Y - p1.Y) + (p2.X - p1.X)*(p2.X - p1.X));
        }
        int LineDist(Point p1, Point p2, Point p)
        {
            return Math.Abs((p.Y - p1.Y) * (p2.X - p1.X) -
                       (p2.Y - p1.Y) * (p.X - p1.X));
        }
        void DrawHull()
        {
            int minX = 0, maxX = 0;
            for (int i = 1; i < points.Count; i++)
            {
                if (points[i].X > points[maxX].X)
                    maxX = i;
                if (points[i].X < points[minX].X)
                    minX = i;
            }
            CHS = new HashSet<Point>();
            CHS.Add(points[minX]);
            CHS.Add(points[maxX]);
            Point aux1 = points[minX], aux2 = points[maxX];
            points.Remove(aux1);
            points.Remove(aux2);

            QuickHull(points, aux1, aux2, 1);
            QuickHull(points, aux1, aux2, -1);



            List<Point> CHSlist = Jarvis(CHS.ToList());

            for (int i = 0; i < CHSlist.Count - 1; i++)
            {
                grp.DrawLine(new Pen(Color.Black, 1), CHSlist[i], CHSlist[i + 1]);
            }
            grp.DrawLine(new Pen(Color.Black, 1), CHSlist[0], CHSlist[CHSlist.Count - 1]);


            DrawPoints(CHS.ToList(), Color.Orange, false);



        }

        private void QuickHull(List<Point> points, Point p1, Point p2, int side)
        {
            int index = -1;
            int distMax = 0;
            for (int i = 0; i < points.Count; i++)
            {
                int temp = LineDist(p1, p2, points[i]);
                if (findSide(p1, p2, points[i]) == side && temp > distMax)
                {
                    index = i;
                    distMax = temp;
                }
            }
            if (index == -1)
            {

                CHS.Add(p1);

                CHS.Add(p2);
                return;
            }
            Point toRemove = new Point(points[index].X, points[index].Y);
           
            QuickHull(points, toRemove, p1, -findSide(toRemove, p1, p2));
            QuickHull(points, toRemove, p2, -findSide(toRemove, p2, p1));

        }
        #endregion

        #region Jarvis
        public void Swap(ref Point a, ref Point b)
        {
            Point aux = new Point();
            aux = a;
            a = b;
            b = aux;


        }
        private double Distance(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X)*(B.X - A.X) + (B.Y - A.Y)*(B.Y - A.Y));
        }
        private float Orientare(Point A, Point B, Point C)
        {
            double temp = (B.Y - A.Y)*(C.X - A.X) - (C.Y - A.Y)*(B.X - A.X);
            if (temp < 0)
                return -1;
            else if (temp == 0)
                return 0;
            else
                return 1;
        }
        private List<Point> Jarvis(List<Point> points)
        {

            //se afla punctul cu  y minim, daca sunt mai multe puncte cu y min, se ia cea cu x minim.
            int indexmin = 0;
            for (int i = 1; i < points.Count; i++)
                if (points[i].Y < points[indexmin].Y || (points[i].Y == points[indexmin].Y && points[i].X > points[indexmin].X))
                    indexmin = i;
            List<Point> CHS = new List<Point>();
            CHS.Add(points[indexmin]);
            // points.Remove(points[indexmin]);
            for (int i = 0; i < CHS.Count; i++)
            {
                Point nextPoint = (CHS[i] == points[0]) ? points[1] : points[0];
                for (int j = 0; j < points.Count; j++)
                {
                    float det = Orientare(CHS[i], points[j], nextPoint);
                    if (det > 0 || (det == 0
                        && Distance(CHS[i], points[j]) > Distance(CHS[i], nextPoint)))
                        nextPoint = points[j];
                }

                if (nextPoint != CHS[0])
                    CHS.Add(nextPoint);
            }
            return CHS;
        }

        #endregion

        private void ScanareGraham_Click(object sender, EventArgs e)
        {
            grp.Clear(pictureBox1.BackColor);
            points = new List<Point>();
            points.Add(new Point(10 * 3, 110 * 3));
            points.Add(new Point(20 * 3, 90 * 3));
            points.Add(new Point(30 * 3, 100 * 3));
            points.Add(new Point(40 * 3, 90 * 3));
            points.Add(new Point(50 * 3, 70 * 3));
            points.Add(new Point(60 * 3, 70 * 3));
            points.Add(new Point(70 * 3, 110 * 3));

            DrawPoints(points, Color.Black, true);
            DrawHull();
            pictureBox1.Image = bmp;

         
        }

        private void button1_Click(object sender, EventArgs e) // Quick Hull
        {
            grp.Clear(pictureBox1.BackColor);
            points = new List<Point>();

            points.Add(new Point(20*3, 80 * 3));
            points.Add(new Point(10*3, 90 * 3));
            points.Add(new Point(50*3, 60 * 3));
            points.Add(new Point(80*3, 90 * 3));
            points.Add(new Point(10 * 3, 30 * 3));
            points.Add(new Point(60 * 3, 70 * 3));
            points.Add(new Point(60 * 3, 70 * 3));
            DrawPoints(points, Color.Black, true);
            //points.Add(new Point(80, 150));

            DrawPoints(points, Color.Black, true);
            DrawHull();
            MessageBox.Show("punctele eliminate sunt: P1(20,80), P6(60,70), P7(60,70)");
            pictureBox1.Image = bmp;
        }

     

        private void Introduceti_Click(object sender, EventArgs e)
        {

        }
    }
}
