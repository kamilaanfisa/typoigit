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
    public partial class Sovesh : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Sovesh()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textZone_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "ИЮ: бла-бла-бла-бла-бла";
            String var2 = "Очень полезная информация";

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
                Gena f24 = new Gena();
                f24.Show();
                Hide();
            }
        }
    }
}
