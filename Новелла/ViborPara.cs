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
    public partial class ViborPara : Form
    {
        public ViborPara()
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
            FilwordIgra f11 = new FilwordIgra();
            f11.Show();
            Hide();
            Shkala.nastroenie++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Opros f12 = new Opros();
            f12.Show();
            Hide();
            Shkala.otnoshenia++;
        }
    }
}
