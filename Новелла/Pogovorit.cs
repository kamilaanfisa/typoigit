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
    public partial class Pogovorit : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Pogovorit()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Pogovorit_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "КМ: Здравствуй, Дима!";
            String var2 = "Дима: :)))))))))))))))))))))))))))";

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
                Cabinet f9 = new Cabinet();
                f9.Show();
                Hide();
            }
        }

        private void Pogovorit_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
