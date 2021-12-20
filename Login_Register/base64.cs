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
    public partial class base64 : Form
    {
        public base64()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string anametin = textBox1.Text;
            byte[] EncryptAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(anametin);
            string value = System.Convert.ToBase64String(EncryptAsBytes);
            textBox2.Text = value;

        }
    }
}
