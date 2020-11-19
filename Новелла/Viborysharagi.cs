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
    public partial class Viborysharagi : Form
    {
        public Viborysharagi()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Viborysharagi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VSharagy f5 = new VSharagy ();
            f5.Show();
            Hide();
            Shkala.otnoshenia++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pokur f6 = new Pokur();
            f6.Show();
            Hide();
            Shkala.nastroenie++;
            Shkala.otnoshenia--;
            Shkala.zdorovie--;
        }
    }
}
