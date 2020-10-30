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
    public partial class Form7 : Form
    {
        public int count;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Сейчас списываем всю методичку на 60 листов за 2 урока.";
            String var2 = "На оценку, если чё.";
            String var3 = "Что то лень, может поиграть в БРАВЛ СТАРС?";
            String name1 = "Учитель";
            String name2 = "Я";

            if (count == 1)
            {
                nameText.Text = name1;
                textZone.Text = var1;
            }
            if (count == 2)
            {
                nameText.Text = name1;
                textZone.Text = var2;
            }
            if (count == 3)
            {
                nameText.Text = name2;
                textZone.Text = var3;
            }
            if (count == 4)
            {
                Form8 f8 = new Form8();
                f8.Show();
                Hide();
            }
        }
    }
}
