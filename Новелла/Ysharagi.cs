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
    public partial class Ysharagi : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Ysharagi()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                count += 1;
                String var1 = "Это та пора, когда особенно хочеться свалить с пар.";
                String var2 = "Эти мучительные часы в колледже измотали меня по полной";
                String var3 = "Дома чай, мама, бравл старс, а я до сих пор тут, может свалить?";

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
                    textZone.Text = var3;
                }
                if (count == 4)
                {
                    Ysharagi f3 = new Ysharagi();
                    f3.Show();
                    Hide();
            }

        }
    }
}
