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
    public partial class Ysharagi : Form
    {
        public int count = 0;
        public String[] arr = new String[3];
        public Ysharagi()
        {
            InitializeComponent();
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ysharagi_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "У Кирилла Михайловича дилемма";
            String var2 = "Через минуту начнется пара, но ему очень хочется перекурить";
            String var3 = "Ирина Юрьевна явно будет не довольна, если он опоздает на пару";

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
                textZone.Text = var3;
            }
            if (count == 4)
            {
                Viborysharagi f3 = new Viborysharagi();
                f3.Show();
                Hide();
            }
        }
    }
}
