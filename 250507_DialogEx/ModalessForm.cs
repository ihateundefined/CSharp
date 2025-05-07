using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250507_DialogEx
{
    public partial class ModalessForm : Form
    {
        public string str;

        public ModalessForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (str.Contains(txtSearch.Text))
            {
                MessageBox.Show("문자열을 찾았습니다!", "검색 결과");
            }
            else
            {
                MessageBox.Show("문자열 검색 실패 ㅠㅠ", "검색 결과");
            }
        }
    }
}
