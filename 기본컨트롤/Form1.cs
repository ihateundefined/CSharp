using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기본컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            lblResult.Text = "";

            if (ckbA.Checked == true)
            {
                strOrder += ckbA.Text + Environment.NewLine;
            }

            if (ckbB.Checked == true)
            {
                strOrder += ckbB.Text + Environment.NewLine;
            }

            if (ckbC.Checked == true)
            {
                strOrder += ckbC.Text + Environment.NewLine;
            }

            if (ckbD.Checked == true)
            {
                strOrder += ckbD.Text + Environment.NewLine;
            }

            lblResult.Text = strOrder + Environment.NewLine + "주문 완료! 조금만 기다리세요";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked == true)
            {
                MessageBox.Show("개인정보를 동의하셨습니다");
            }
            else
            {
                MessageBox.Show("개인정보를 동의하지 않으셨습니다");
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            string strText = txtRequire.Text + Environment.NewLine + "라고 요구사항 접수 완료 :)";
            MessageBox.Show(strText, "요구사항");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string strText = cbPay.Text + "(으)로 " + lbArea.Text + "결제방법 선택하셨어요";
            MessageBox.Show(strText, "결제 알림창");
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // combo box 선택되었을 때, list box 초기화하기
            lbArea.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbArea.Items.Add("신한은행");
                lbArea.Items.Add("하나은행");
                lbArea.Items.Add("새마을금고");
                lbArea.Items.Add("카카오뱅크");
            }
            else if (cbPay.SelectedIndex == 2)
            {
                lbArea.Items.Add("카드");
                lbArea.Items.Add("포인트");
            }
            else if (cbPay.SelectedIndex == 3)
            {
                lbArea.Items.Add("일시불");
                lbArea.Items.Add("3개월 할부");
                lbArea.Items.Add("6개월 할부");
            }
        }
    }
}
