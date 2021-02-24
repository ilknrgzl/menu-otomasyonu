using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label2.Text = "Kullanıcı Adı; ";
            label3.Text = "Şifre";
            button1.Text = "giriş";
            label6.Text = "derecesi";
            label1.Text = "tel no";
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = textBox1.Text.Length;
            if (karaktersayisi > 0 && karaktersayisi < 2)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
                label6.Text = "Zayıf";
            }
            else if (karaktersayisi >= 2 && karaktersayisi < 6)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
                label6.Text = "Orta";
            }
            else if (karaktersayisi >= 6)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
                label6.Text = "Güçlü";
            }
            else
            {
                progressBar1.Value = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sec = new Form2();
            sec.Show();
            this.Hide();
        }
    }
}
