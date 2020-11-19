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

    public partial class Pravila : Form
    {
        public Pravila()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ysharagi f3 = new Ysharagi();
            f3.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Ysharagi f3 = new Ysharagi();
            f3.Show();
            Hide();
        }
    }

    }

