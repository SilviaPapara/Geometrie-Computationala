using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_8__Bun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
       

        private void Form1_Load(object sender, EventArgs e)
        {
            engine.initGraph(pictureBox1);
            engine.loadFromFile(@"..\..\Coordonate.txt");
            engine.DrawMap(engine.p, Color.Red);
           
            engine.ConvexHull();
            engine.DrawMap(engine.ch , Color.Blue);
            engine.RefreshGraph();

            

            // engine.initGraph(pictureBox1);

        }

        public int idx = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            engine.grp.DrawLine(Pens.Blue, engine.ch[(idx) % engine.ch.Count], engine.ch[(idx + 1) % engine.ch.Count]);
            idx++;
            idx = idx % engine.ch.Count;
            engine.RefreshGraph();


        }
    }
}
