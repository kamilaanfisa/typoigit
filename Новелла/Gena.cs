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

    public partial class Gena : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Gena()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gena_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "КА: Как проходит твоя пара?";
            String var2 = "КМ: Да чет никак, уже устал). Я заказал еды.";
            String var3 = "КА: Ладно мне выше, принесешь мне чаю?)";

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
            if (count==4)
            {
                ViborGena f28 = new ViborGena();
                f28.Show();
                Hide();
            }
        }
    }
}
