﻿using System;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada");
        }
    }
}
