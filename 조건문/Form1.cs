using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 조건문
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int kuk = int.Parse(txtKuk.Text);
            int eng = int.Parse(txtEng.Text);
            int math = int.Parse(txtMath.Text);

            int total = kuk + eng + math;
            double avg = total / 3.0;
            lblAvg.Text = avg.ToString();

            // switch ~ case문
            switch ((int)(avg / 10))
            {
                case 10:
                case 9:
                    lblGrade.Text = "A학점";
                    break;
                case 8:
                    lblGrade.Text = "B학점";
                    break;
                case 7:
                    lblGrade.Text = "C학점";
                    break;
                case 6:
                    lblGrade.Text = "D학점";
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    lblGrade.Text = "F학점";
                    break;
                default:
                    lblGrade.Text = "잘못된 입력이에요 !";
                    break;
            }

            /*
            // if ~ else if 조건문
            if (avg >= 90 && avg <= 100)
            {
                lblGrade.Text = "A학점";
            }
            else if (avg >= 80 && avg < 90)
            {
                lblGrade.Text = "B학점";
            }
            else if (avg >= 70 && avg < 80)
            {
                lblGrade.Text = "C학점";
            }
            else if (avg >= 60 && avg < 70)
            {
                lblGrade.Text = "D학점";
            }
            else
            {
                lblGrade.Text = "F학점";
            }
            */

            if (total > 250 && total <= 300)
            {
                label1.Text = "합격입니다. 축하해요 :)";
            }
            else if (total <= 250 && total >= 0)
            {
                label1.Text = "불합격입니다. :(";
            }
            else
            {
                label1.Text = "잘못된 입력입니다. 다시 입력하세요";
            }
        }
    }
}
