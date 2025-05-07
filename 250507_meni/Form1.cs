using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _250507_meni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripCopy_Click(object sender, EventArgs e)
        {
            lblResult.Text = "복사 되었습니다.";
        }

        private void ToolStripPaste_Click(object sender, EventArgs e)
        {
            lblResult.Text = "붙여넣기 되었습니다.";
        }

        private void ToolStripCut_Click(object sender, EventArgs e)
        {
            lblResult.Text = "잘라내기 되었습니다.";
        }

        private void ToolStripNew_Click(object sender, EventArgs e)
        {
            lblResult.Text = "새 파일을 만듭니다.";
        }

        private void ToolStripOpen_Click(object sender, EventArgs e)
        {
            lblResult.Text = "파일을 엽니다.";
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            lblResult.Text = "파일을 저장합니다.";
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
