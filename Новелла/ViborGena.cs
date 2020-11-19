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
    public partial class ViborGena : Form
    {
        public ViborGena()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Paraprod f25 = new Paraprod();
            f25.Show();
            Hide();
            Shkala.otnoshenia++;
            Shkala.nastroenie++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Paraprod f25 = new Paraprod();
            f25.Show();
            Hide();
            Shkala.otnoshenia--;
            Shkala.zdorovie--;
        }
    }
}
