using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// sleep..? 으로 제어권 조정?
using System.Threading;

namespace _250507_MessageAlarm
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;
        private int h = 0;
        private MessageForm msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (h > 230)
            {
                h = 0;
                timer1.Stop();

                Thread.Sleep(300);
                msg.Close();
            } else
            {
                msg.Location = new Point(x, y - h);
                msg.Show();
                h += 10;
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            // width -> 화면(창)의 가로 길이 -> 우하단
            // 메세지 출력이 짤려서 보이지 않으므로 메세지 창 길이만큼 빼주기
            x = Screen.PrimaryScreen.Bounds.Width - 250;
            // y 축의 경우 -> 우상단이 시작
            y = Screen.PrimaryScreen.Bounds.Height;
            timer1.Start();
            msg = new MessageForm();
        }
    }
}
