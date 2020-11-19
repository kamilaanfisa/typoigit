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
    public partial class ViborPokushat : Form
    {
        public ViborPokushat()
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
            SledUrok f19 = new SledUrok();
            f19.Show();
            Hide();
            Shkala.nastroenie++;
            Shkala.zdorovie--;
            Shkala.otnoshenia++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SledUrok f19 = new SledUrok();
            f19.Show();
            Hide();
            Shkala.zdorovie++;
            Shkala.otnoshenia++;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SledUrok f19 = new SledUrok();
            f19.Show();
            Hide();
            Shkala.nastroenie++;
            Shkala.zdorovie--;
            Shkala.otnoshenia++;
        }
    }
}
