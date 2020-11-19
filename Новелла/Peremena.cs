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
    public partial class Peremena : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Peremena()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Peremena_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "КМ: Время покушать";
            String var2 = "КМ: Надо бы заказать еды";
            String var3 = "Да и Кристина, наверное проголодалась";
            String var4 = "Осталось только выбрать что именно";

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
                label2.Text = var4;
            }
           
            if (count == 5)
            {
                ViborPokushat f18 = new ViborPokushat();
                f18.Show();
                Hide();
            }
        }

    }
}
