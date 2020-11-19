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
    public partial class Peremena2 : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Peremena2()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Peremena2_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "ИЮ: /звонит/";
            String var2 = "ИЮ: сейчас будет совещание!";

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
                ViborPoslePari f22 = new ViborPoslePari();
                f22.Show();
                Hide();
            }
        }
    }
}
