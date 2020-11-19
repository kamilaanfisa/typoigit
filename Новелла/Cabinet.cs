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
    public partial class Cabinet : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Cabinet()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Cabinet_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "/КМ здоровается со студентами и садится за рабочий стол/";
            String var2 = "КМ: Что-то я уже и устал";

            if (count == 1)
            {
                label2.Text = var1;
            }
            if (count == 2)
            {
                label2.Text = var2;
            }
            if (count == 3)
            {
                ViborPara f10 = new ViborPara();
                f10.Show();
                Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
