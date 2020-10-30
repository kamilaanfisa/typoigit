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
    public partial class Form4 : Form
    {
        public int count = 0;
        public Form4()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Выбежав в конце перемены с портфелем в руках, единственное что смутило охранников";
            String var2 = "это то что у меня не было карточки";
            String var3 = "Проходя через курилку встретилась она...";
            String var4 = "Куда намылился? С пар смыться пытаешься? МММ? ААА?";
            String name1 = "Она";

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
                textZone.Text = var4;
                nameText.Text = name1;
            }
            if (count == 5)
            {
                Form5 f5 = new Form5();
                f5.Show();
                Hide();
            }
        }
    }
}
