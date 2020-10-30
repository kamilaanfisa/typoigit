using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novella
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void write_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            Hide();
        }

        private void play_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            Hide();
        }
    }
}
