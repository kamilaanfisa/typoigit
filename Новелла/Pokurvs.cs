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
    public partial class Pokurvs : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Pokurvs()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Pokurvs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pokurvs_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "КМ: Обойдется, все равно на этом совещании одна нудятина.";
            String var2 = "АВ: Ну-у, да";

            if (count == 1)
            {
                textZone.Text = var1;
            }
            if (count == 2)
            {
                textZone.Text = var2;
            }
            if (count == 3)
            {
                Paraprod f30 = new Paraprod();
                f30.Show();
                Hide();
            }
        }
    }
}
