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
    public partial class Random : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Random()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Random_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Итак, на рандоме число 15...";
            String var2 = "Кто же это у нас??? Мокрушин!";

            if (count == 1)
            {
                textZone.Text = var1;
            }
            if (count == 2)
            {
                textZone.Text = var2;
            }
            if (count == 3)
            {
                Mokrushin f16 = new Mokrushin();
                f16.Show();
                Hide();
            }
        }
    }
}
