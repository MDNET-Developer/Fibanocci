using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibanocci_hesablamasi_proqrami
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = " Cədvəldə oxlarla göstərildiyi \r\n" +
                          "kimi say2 uygun olaraq say1 -ə\r\n" +
                          "say3 uyğun olaraq say2-ə keçir\r\n" +
                          "Bu cür yer dəyişmələr ilə uyğun olaraq\r\n" +
                          "ardicil qaydada bir-biriləri ilə toplanirlar\r\n" +
                          "Ona görədə alqoritmada say1=say2 və say2=say3\r\n" +
                          "yazdiq\r\n" +
                          "\r\n" +
                          "\r\n" +
                          "\r\n" +
                          "\r\n" +
                          "1+1=2\r\n" +
                          "1+2=3\r\n" +
                          "2+3=5\r\n" +
                          "3+5=8\r\n" +
                          "5+8=13\r\n" +
                          "8+13=21\r\n" +
                          "Sürüşdürmə qaydası baş verdi";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1();
            geri.Show();
            this.Hide();
        }
    }
}
