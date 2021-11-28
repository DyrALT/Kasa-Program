using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasaProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //int[] paralar = { 1, 5, 10, 20, 50, 100, 200 };
        int[] paralar = { 200, 100, 50, 20, 10, 5, 1 };



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Textboxlar boş kalamaz", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                listBox1.Items.Clear();
                int verilen_para = Convert.ToInt32(textBox1.Text);
                int alınan_para = Convert.ToInt32(textBox2.Text);
                int para_üstü = (verilen_para - alınan_para);

                if (para_üstü > 0)
                {
                    textBox3.Text = para_üstü.ToString();

                    for (int i = 0; i < 7; i++)
                    {
                        int adet = para_üstü / paralar[i];
                        if (adet != 0)
                        {
                            listBox1.Items.Add(adet.ToString() + " Adet :" + paralar[i].ToString() + "TL");
                            para_üstü %= paralar[i];
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Eksik Para", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            listBox1.Items.Clear();

        }
    }
}
