using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250508_미니그림판
{
    public partial class Form1 : Form
    {
        // 0 선, 1 사각형, 2 원
        int shape;

        // 시작점, 끝점
        Point ptStart;
        Point ptEnd;

        // 펜
        Pen myPen;

        int rtWidth;
        int rtHeight;

        // 마우스 누르고 있는지, 떼었는지
        Boolean bPress;

        // 그래픽
        Graphics g;

        // 사각형 정보
        Rectangle rect;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 초기화
            shape = 0;
            ptStart = new Point(0, 0);
            ptEnd = new Point(0, 0);
            myPen = new Pen(Color.BlanchedAlmond, 5);
            rtWidth = 0;
            rtHeight = 0;
            bPress = false;
            g = Graphics.FromHwnd(this.Handle);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            bPress = true;

            // x, y 좌표
            ptStart.X = e.X;
            ptStart.Y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (shape == 0) // 선 그리기
            {
                if (bPress)
                {
                    // 기존에 그린 것은 초기화
                    g.Clear(Color.White);

                    ptEnd = new Point(e.X, e.Y);
                    g.DrawLine(myPen, ptStart, ptEnd);
                }
            }
            else if (shape == 1) // 사각형 그리기
            {
                if (bPress)
                {
                    g.Clear(Color.White);

                    rtWidth = Math.Abs(e.X - ptStart.X);
                    rtHeight = Math.Abs(e.Y - ptStart.Y);

                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                    g.DrawRectangle(myPen, rect);
                }
            }
            else if (shape == 2) // 원 그리기
            {
                if (bPress)
                {
                    g.Clear(Color.White);

                    rtWidth = Math.Abs(e.X - ptStart.X);
                    rtHeight = Math.Abs(e.Y - ptStart.Y);

                    if (rtWidth == 0)
                    {
                        rtWidth = 1;
                    }

                    if (rtHeight == 0)
                    {
                        rtHeight = 1;
                    }

                    // 내접하는 원 -> 이번에는 arc로 그리기
                    rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                    g.DrawEllipse(myPen, rect);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            bPress = false;
            
            if (shape == 0)
            {
                ptEnd = new Point(e.X, e.Y);
                g.DrawLine(myPen, ptStart, ptEnd);
            }
            else if (shape == 1)
            {
                rtWidth = Math.Abs(e.X - ptStart.X);
                rtHeight = Math.Abs(e.Y - ptStart.Y);

                rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                g.DrawRectangle(myPen, rect);
            }
            else if (shape == 2)
            {
                rtWidth = Math.Abs(e.X - ptStart.X);
                rtHeight = Math.Abs(e.Y - ptStart.Y);

                rect = new Rectangle(ptStart.X, ptStart.Y, rtWidth, rtHeight);
                g.DrawArc(myPen, rect, 0, 360);
            }
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripLine_Click(object sender, EventArgs e)
        {
            this.shape = 0; // 직선 그리기
        }

        private void ToolStripRect_Click(object sender, EventArgs e)
        {
            this.shape = 1; // 사각형 그리기

        }

        private void ToolStripCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2; // 원 그리기

        }

        private void toolStripSelectColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                myPen.Color = colorDialog.Color;
            }
        }

        private void toolStripBtnLine_Click(object sender, EventArgs e)
        {
            this.shape = 0; // 직선 그리기

        }

        private void toolStripBtnRect_Click(object sender, EventArgs e)
        {
            this.shape = 1; // 사각형 그리기

        }

        private void toolStripBtnCircle_Click(object sender, EventArgs e)
        {
            this.shape = 2; // 원 그리기

        }

        private void toolStripBtnBlack_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Black;
        }

        private void toolStripBtnRed_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.Crimson;
        }

        private void toolStripBtnGreen_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.ForestGreen;
        }

        private void toolStripBtnBlue_Click(object sender, EventArgs e)
        {
            myPen.Color = Color.DeepSkyBlue;
        }
    }
}
