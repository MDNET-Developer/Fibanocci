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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double say2 = 1;
            double say1 = 1;
            double say3;

            double n;
            n = double.Parse(textBox1.Text);

           

            for(double i = 1; i <= n; i++)
            {
                listBox1.Items.Add(say1);
                listBox1.Items.Add(say2);
                say3 = say1 + say2;
                say1 = say2;
                say2 = say3;
                listBox1.Items.Add(say3);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Cursor = Cursors.WaitCursor;
            MessageBox.Show(" The program was closed !!! ");
            Application.Exit();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 izahat = new Form2();
            izahat.Show();
            this.Hide();
            
        }
    }
}
