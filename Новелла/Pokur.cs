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
    public partial class Pokur : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Pokur()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Pokur_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "ИЮ: Кирюша, я была о тебе лучшего мнения";
            String var2 = "ИЮ: Быстро на пару!!!!!!!!!!!!!!!!!!!!!!!!!!";

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
                VSharagy f5 = new VSharagy();
                f5.Show();
                Hide();
            }
        }
    }
    }

