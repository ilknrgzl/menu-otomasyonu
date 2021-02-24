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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // combobox içindeki degerleri listbox gönderildi
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 1)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 2)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 3)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 4)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 5)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 6)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
            else if (comboBox1.SelectedIndex == 7)
            {

                listBox1.Items.Add(button2);
                listBox1.Items.Add(button1);
                listBox1.Items.Add(button4);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "geri sayım ";
            comboBox1.Items.Add("1");//masa sayıları
            comboBox1.Items.Add("2");//masa sayıları
            comboBox1.Items.Add("3");//masa sayıları            
            comboBox1.Items.Add("4");//masa sayıları           
            comboBox1.Items.Add("5");//masa sayıları
            comboBox1.Items.Add("6");//masa sayıları            
            comboBox1.Items.Add("7");//masa sayıları
            comboBox1.Items.Add("8");//masa sayıları           
            comboBox1.Text = comboBox1.Items[0].ToString();
            radioButton1.Text = "hesap ödendi";// text ekleme
            radioButton2.Text = "hesap ödenmedi";// text ekleme
            groupBox2.Text = "Çorbalar";// text ekleme
            groupBox1.Text = "Soğukk İçeçekler";// text ekleme
            groupBox3.Text = "Salatalar";// text ekleme
            groupBox7.Text = "ara sıcaklar";// text ekleme
            groupBox6.Text = "Pasta ve Kurabiyeler";// text ekleme
            groupBox4.Text = "Sıcak İçeçekler";// text ekleme
            groupBox5.Text = "Tatlılar";// text ekleme
            checkBox2.Text = "tarhana";// checked text ekleme
            checkBox3.Text = "mercimek";// checked text ekleme
            checkBox4.Text = "domates";// checked text ekleme
            checkBox5.Text = "ezo gelin";// checked text ekleme
            checkBox6.Text = "mantar";// checked text ekleme
            checkBox45.Text = "patlıcan";// checked text ekleme
            tabPage1.Text = "yiyecekler";// text ekleme
            tabPage2.Text = "tatlı ve pasta";// text ekleme
            tabPage3.Text = "içeçekler";// text ekleme
            tabPage4.Text = "masa siparişi";// text ekleme
            tabPage5.Text = "hesaplar";// text ekleme
            button7.Text = "süreyi başlat";// text ekleme
            button2.Text = "listeye seçilenleri ekle";// text ekleme
            button1.Text = "listeye seçilenleri ekle";// text ekleme
            button4.Text = "listeye seçilenleri ekle";// text ekleme
            button11.Text = "listeye seçilenleri ekle";// text ekleme
            button10.Text = "temizle";// text ekleme
            button9.Text = "sil";// text ekleme
            button8.Text = "ekle";// text ekleme
            label3.Text = "hesap";// text ekleme
            button3.Text = "hesapla";// text ekleme
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;// label görünürlülügü acıldı
        }
        int sayi = 900;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayi >= 0)
            {
                timer1.Interval = 1000;
                timer1.Enabled = true;
                int sayac = sayi--;
                label1.Text = sayac.ToString();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" yemek seçimi değişti");//tıklandıgında mesaj gönderme özelligi
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" yemek seçimi değişti");//tıklandıgında mesaj gönderme özelligi
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > 10000)

            {

                errorProvider1.SetError(textBox1, "Lütfen ödenecek tutarı giriniz");

            }

            else
            {
                errorProvider1.Clear();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\filtrekahveorig.jpg"); //resim ekleme
        }
        int sayac = 0;
        private void button5_Click(object sender, EventArgs e)//projemde kullanablecegim bir yer bulamadım sayaç özelligini yaptım
        {
            int artis_degeri = Convert.ToInt32(numericUpDown1.Value);
            sayac += artis_degeri;
            label5.Text = sayac.ToString();
        }
    }
}
