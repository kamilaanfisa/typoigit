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
    public partial class Viborpogovor : Form
    {
        public Viborpogovor()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pogovorit f8 = new Pogovorit();
            f8.Show();
            Hide();
            Shkala.nastroenie++;
            Shkala.otnoshenia++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cabinet f9 = new Cabinet();
            f9.Show();
            Hide();
            Shkala.otnoshenia--;
        }
    }
}
