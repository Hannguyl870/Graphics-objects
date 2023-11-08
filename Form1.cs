using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            Pen darkgoldenrodpen = new Pen(Color.DarkGoldenrod, 10);
            Pen Darkturquisepen = new Pen(Color.DarkTurquoise, 10);
            SolidBrush blackbrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);
            g.DrawLine(redpen, 0, 0, 100, 100);

            g.DrawRectangle(darkgoldenrodpen, 30, 30, 200, 100);
            g.FillRectangle(blackbrush, 30, 30, 200, 100);

            g.DrawRectangle(Darkturquisepen, 25, 200, 200,100 );
            g.DrawEllipse(redpen, 25, 200, 100, 100);
            g.FillEllipse(blackbrush, 25, 200, 100, 100);

            g.DrawArc(redpen, 300, 20, 50, 50, 90, 300);
            g.DrawPie(redpen, 300, 100, 50, 50, 210, 300);

            g.DrawPie(redpen, 300, 200, 50, 50, 30, 45);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            Pen darkgoldenrodpen = new Pen(Color.DarkGoldenrod, 10);
            Pen Darkturquisepen = new Pen(Color.DarkTurquoise, 10);
            SolidBrush blackbrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);
            g.DrawLine(redpen, 0, 0, 100, 100);
        }
    }
}
