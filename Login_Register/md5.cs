using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class md5 : Form
    {
        public md5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            byte[] data = UTF8Encoding.UTF8.GetBytes(textBox1.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Text));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textBox2.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            byte[] data = Convert.FromBase64String(textBox2.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Text));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    textBox3.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new base64().Show();
            this.Hide();
        }
    }
}
