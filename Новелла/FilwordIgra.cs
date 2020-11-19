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
    public partial class FilwordIgra : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public FilwordIgra()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void FilwordIgra_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "Я надеюсь, все помнят, что это?";
            String var2 = "А, в прочем разберетесь)))";
            String var3 = "/КМ идет играть в комп/";
            String var4 = "Во что же ему поиграть?";

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
                ViborIgra f14 = new ViborIgra();
                f14.Show();
                Hide();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
