using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;
using System.IO;

namespace Seminar_8__Bun
{
    public static class engine
    {
        public static Graphics grp;
        public static Bitmap bmp;
        public static int resx, resy;
        public static Color backColor = Color.Aquamarine;
        public static PictureBox display;

        public static List<PointF> p = new List<System.Drawing.PointF>();
        public static List<PointF> ch = new List<System.Drawing.PointF>();
        public static void loadFromFile(string fileName)
        {
            TextReader dataLoad = new StreamReader(fileName);
            string buffer;
            while ((buffer = dataLoad.ReadLine()) != null)
            {
                float x = float.Parse(buffer.Split(' ')[0]);
                float y = float.Parse(buffer.Split(' ')[1]);
                p.Add(new PointF(x * 6, y * 3));
            }
        }
        public static void initGraph(PictureBox T)
        {
            display = T;
            resx = T.Width;
            resy = T.Height;

            bmp = new Bitmap(resx, resy);
            grp = Graphics.FromImage(bmp);

            ClearGraph();
            RefreshGraph();
        }

        public static void ClearGraph()
        {
            grp.Clear(backColor);
        }
        public static void RefreshGraph()
        {
            display.Image = bmp;
        }
        public static void DrawMap(List<PointF> toDraw, Color draw)
        {
            foreach (PointF point in toDraw)
                grp.DrawEllipse(new Pen(draw, 3), point.X - 1, point.Y - 1, 3, 4);


        }
        public static int orientare(PointF P, PointF Q, PointF R)
        {
            double temp = (Q.Y - P.Y) * (R.X - Q.X) - (Q.X - P.X) * (R.Y - Q.Y);
            if (temp < 0)
                return -1;
            else if (temp == 0)
                return 0;
            else
                return 1;

        }

        public static void ConvexHull()
        {
            for (int x = 0; x < (p.Count - 1); x++)

                for (int y = x + 1; y < p.Count; y++)
                {
                    int semn = 0;
                    for (int k = 0; k < p.Count; k++)

                        if ((k != x) && (k != x))
                            semn += orientare(p[x], p[y], p[k]);

                    if (Math.Abs(semn) == p.Count - 2)

                    {
                        ch.Add(p[y]);
                        ch.Add(p[x]);
                    }
                }

        }
    
    }
}
