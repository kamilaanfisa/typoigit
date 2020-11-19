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
    public partial class Mokrushin : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Mokrushin()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mokrushin_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "КМ: Ответишь на один мой вопрос, поставлю 5";
            String var2 = "КМ: Как полностью называется наш предмет по МДК?";
            String var3 = "Сай шепчет: Компоненты и функционирование системы защиты информации";
            String var4 = "Мокрушин: /повторил/";
            String var5 = "КМ: А как зовут мою маму?";
            String var6 = "Ладно, садись, 5";

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
                label2.Text = var5;
            }
            if (count == 6)
            {
                label2.Text = var6;
            }
            if (count == 7)
            {
                Peremena f17 = new Peremena();
                f17.Show();
                Hide();
            }
        }
    }
}
