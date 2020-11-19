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
    public partial class ViborIgra : Form
    {
        public ViborIgra()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Peremena f17 = new Peremena();
            f17.Show();
            Hide();
            Shkala.nastroenie++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Peremena f17 = new Peremena();
            f17.Show();
            Hide();
            Shkala.nastroenie++;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Peremena f17 = new Peremena();
            f17.Show();
            Hide();
            Shkala.nastroenie++;
        }
    }
}
