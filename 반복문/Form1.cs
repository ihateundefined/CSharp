using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 반복문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            // 반복문
            label1.Text = "C# 프로그래밍\n";
            label1.Text += "C# 프로그래밍\n";
            label1.Text += "C# 프로그래밍\n";
            label1.Text += "C# 프로그래밍\n";
            label1.Text += "C# 프로그래밍\n";
            */

            /*
            // while문
            int i = 0;
            while (i < 5) {
                label1.Text += "C# 프로그래밍\n";
                i++;
            }
            */

            /*
            // do~while문
            // 무조건 한 번은 실행을 해야하는 경우 -> 입력값 받고, 그 결과에 따라 처리하는 경우
            int i = 0;
            do
            {
                label1.Text += "C# 프로그래밍\n";
                i++;
            } while (i < 5);
            */

            /*
            // for문
            for (int i = 0; i < 5; i++)
            {
                // label1.Text += "C# 프로그래밍\n";
                // Environment.NewLine == \n 개행
                label1.Text += "C# 프로그래밍" + Environment.NewLine;
            }
            */

            /*
            // 2단 출력하기
            for (int i = 1; i < 10; i++)
            {
                label1.Text += "2 * " + i.ToString() + " = " + (2*i).ToString() + Environment.NewLine;
            }
            */

            /*
            // textBox에 입력받은 정수에 해당하는 구구단 출력하기
            string dan = txtDan.Text;

            label1.Text = "구구단 "+ dan + "단을 출력합니다\n";

            for (int i = 1; i < 10; i++)
            {
                label1.Text += dan + " * " + i.ToString() + " = " + (int.Parse(dan) * i).ToString() + Environment.NewLine;
            }
            */
        }
    }
}
