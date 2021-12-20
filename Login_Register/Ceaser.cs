using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class Ceaser : Form
    {
        public Ceaser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            str = textBox1.Text;
            char[] karakterler = str.ToCharArray();
            foreach (char user in karakterler)
            {
                textBox2.Text += Convert.ToChar(user + 3).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str2 = "";
            str2 = textBox2.Text;
            char[] karakterler2 = str2.ToCharArray();
            foreach (char user2 in karakterler2)
            {
                textBox1.Text += Convert.ToChar(user2 - 3).ToString();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            new md5().Show();
            this.Hide();
        }
    }
}
