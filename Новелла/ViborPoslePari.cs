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
    public partial class ViborPoslePari : Form
    {
        public ViborPoslePari()
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
            Pokurvs f23 = new Pokurvs();
            f23.Show();
            Hide();
            Shkala.zdorovie--;
            Shkala.nastroenie++;
            Shkala.otnoshenia++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sovesh f24 = new Sovesh();
            f24.Show();
            Hide();
            Shkala.nastroenie--;
            Shkala.otnoshenia++;
        }
    }
}
