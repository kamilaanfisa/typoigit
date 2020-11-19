using System;
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
    public partial class Opros : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Opros()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Opros_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Кого же мне сегодня спросить...";
            String var2 = "Точно! Выберу с помощью рандома";
            String var3 = "Или может все-таки спросить, например, Мокрушина??";

            if (count == 1)
            {
                label2.Text = var1;
            }
            if (count == 2)
            {
                label2.Text = var2;
            }
            if (count == 3)
            {
                label2.Text = var3;
            }
            if (count == 4)
            {
                ViborOpros f13 = new ViborOpros();
                f13.Show();
                Hide();
            }
        }
    }
}
