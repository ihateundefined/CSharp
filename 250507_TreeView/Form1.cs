using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _250507_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNode.Text == "")
            {
                MessageBox.Show("데이터를 입력해주세요");
            } else
            {
                string strNode = txtNode.Text;
                TreeNode node1 = new TreeNode(strNode);

                if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
                {
                    // 선택된 노드에 대해 하위에 추가
                    treeView1.SelectedNode.Nodes.Add(node1);
                }
                else
                {
                    // 같은 수준의 노드에 추가
                    treeView1.Nodes.Add(node1);
                }

                txtNode.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.IsSelected)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
