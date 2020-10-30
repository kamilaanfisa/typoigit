using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novella
{
    public partial class Form6 : Form
    {
        public int count;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Сынок, тут тебе повестка";
            String var2 = "Что? Меня забирают в армию?";
            String var3 = "Лучше бы писал конспекты и не ливал с пар...";
            String name1 = "Мама";
            String name2 = "Я";

            if (count == 1)
            {
                nameText.Text = name1;
                textZone.Text = var1;
            }
            if (count == 2)
            {
                nameText.Text = name2;
                textZone.Text = var2;
            }
            if (count == 3)
            {
                nameText.Text = name2;
                textZone.Text = var3;
            }
            if (count == 5)
            {
                Form1 f1 = new Form1();
                f1.Show();
                Hide();
            }
        }

    }
}
