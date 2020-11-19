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
    public partial class VSharagy : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public VSharagy()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VSharagy_Load(object sender, EventArgs e)
        {

        }

        private void VSharagy_Click(object sender, EventArgs e)
        {

            count += 1;
            String var1 = "Только он успел об этом подумать";
            String var2 = "Как к нему подошел назойливый студент, чтобы обкашлять пару вопросов";

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
                Viborpogovor f7 = new Viborpogovor();
                f7.Show();
                Hide();
            }
        }
    }
}
