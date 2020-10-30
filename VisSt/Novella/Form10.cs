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
    public partial class Form10 : Form
    {
        public int count;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Я готов играть в нее вечность!";
            String var2 = "И тут я начинаю понимать,";
            String var3 = "что кто то пытается отвлечь меня от этой замечательной игры.";
            String var4 = "Все уже давно разошлись, показывай работу и уходи.";
            String var5 = "Так я ничего не делал.";
            String var6 = "Шизик, 5 двоек в ряд...";
            String name1 = "Учитель";
            String name2 = "Я";

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
                nameText.Text = name1;
                textZone.Text = var4;
            }
            if (count == 5)
            {
                nameText.Text = name2;
                textZone.Text = var5;
            }
            if (count == 6)
            {
                nameText.Text = name1;
                textZone.Text = var6;
            }
            if (count == 7)
            {
                Form6 f6 = new Form6();
                f6.Show();
                Hide();
            }
        }
    }
}
