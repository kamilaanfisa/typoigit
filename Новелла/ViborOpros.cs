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
    public partial class ViborOpros : Form
    {
        public ViborOpros()
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
            Random f15 = new Random();
            f15.Show();
            Hide();
            Shkala.nastroenie++;
            Shkala.otnoshenia++;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Mokrushin f16 = new Mokrushin();
            f16.Show();
            Hide();
            Shkala.otnoshenia++;
        }
    }
}
