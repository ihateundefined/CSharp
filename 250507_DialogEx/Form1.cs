﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            ModalForm modal = new ModalForm();
            modal.ShowDialog();
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            ModalessForm modaless = new ModalessForm();
            modaless.str = textBox1.Text;
            modaless.Show();
        }
    }
}
