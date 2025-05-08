using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250508_원그리기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen p = new Pen(Color.DarkTurquoise, 10);
            Rectangle rc1 = new Rectangle(30, 20, 200, 200);
            g.DrawEllipse(p, rc1);

            Brush b = new SolidBrush(Color.DarkBlue);
            Rectangle rc2 = new Rectangle(260, 20, 200, 200);
            g.FillEllipse(b, rc2);
        }
    }
}
