﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Новелла
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1930;
            this.Height = 1040;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Pravila f2 = new Pravila();
            f2.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Pravila f2 = new Pravila();
            f2.Show();
            Hide();
        }
    }
}
