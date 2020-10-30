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
    public partial class Form9 : Form
    {
        public int count;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            count += 1;
            String var1 = "спустя полтора часа..";
            String var2 = "Заколебало. Зачем я это спысывал?";
            String var3 = "Ты че серезьно это делал? Ладно, поставлю 4 за старания.";
            String name1 = "Учитель";
            String name2 = "Я";

            if (count == 1)
            {
                textZone.Text = var1;
            }
            if (count == 2)
            {
                nameText.Text = name2;
                textZone.Text = var2;
            }
            if (count == 3)
            {
                nameText.Text = name1;
                textZone.Text = var3;
            }
            if (count == 4)
            {
                Form1 f1 = new Form1();
                f1.Show();
                Hide();
            }
        }
    }
}
