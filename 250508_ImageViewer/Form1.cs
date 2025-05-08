using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        Bitmap  myBmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void TbBtnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                myBmp = new Bitmap(openFileDialog.FileName);
                pbImage.Width = myBmp.Width;
                pbImage.Height = myBmp.Height;
                pbImage.Image = myBmp;
            }
        }

        private void TbBtnSizeUp_Click(object sender, EventArgs e)
        {
            pbImage.Width += 10;
            pbImage.Height += 10;
            pbImage.Image = myBmp;
        }

        private void TbBtnSizeDown_Click(object sender, EventArgs e)
        {
            pbImage.Width -= 10;
            pbImage.Height -= 10;
            pbImage.Image = myBmp;
        }

        private void TbMenuItem90_Click(object sender, EventArgs e)
        {
            pbImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pbImage.Refresh();
        }

        private void TbMenuItem180_Click(object sender, EventArgs e)
        {
            pbImage.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pbImage.Refresh();
        }

        private void TbMenuItem270_Click(object sender, EventArgs e)
        {
            pbImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbImage.Refresh();
        }
    }
}
