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
    public partial class SledUrok : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public SledUrok()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SledUrok_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "КМ: О, нет... Пара...";
            String var2 = "/КМ проводит пару/";

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
                HourLater f20 = new HourLater();
                f20.Show();
                Hide();
            }
        }
    }
}
