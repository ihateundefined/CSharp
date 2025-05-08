using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250508_이미지클래스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // bin -> debug에 파일 위치하기
            Image imgFile = Image.FromFile("1.png");

            Point pt = new Point(0, 0);
            Graphics g = e.Graphics;
            g.DrawImage(imgFile, pt);
        }
    }
}
