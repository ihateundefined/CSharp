using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250507_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 세 개의 텍스트 박스의 값을 가져와서 리스트 뷰에 추가

            if(txtName.Text == "" || txtPhone.Text == "" || txtOrg.Text == "")
            {
                MessageBox.Show("빈 값이 있습니다. 데이터를 입력해주세요");
            } else
            {
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string org = txtOrg.Text;

                string[] strArr = new string[] { name, phone, org };

                // 아래와 같이 new 생략 가능
                // string[] strArr = { name, phone, org };

                ListViewItem item = new ListViewItem(strArr);
                listView1.Items.Add(item);

                txtName.Clear();
                txtPhone.Clear();
                txtOrg.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.FocusedItem.Index;
            listView1.Items.RemoveAt(selectedIndex);
        }
    }
}
