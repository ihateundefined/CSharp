using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtAddress.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("웹 사이트 로딩 완료");
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            // enter 키 눌렀을 때만 반응하도록
            if (e.KeyCode == Keys.Enter) {
                webBrowser1.Navigate(txtAddress.Text);
            }
        }
    }
}
