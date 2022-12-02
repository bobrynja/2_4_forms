using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                textBox2.Text = "";
                try
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    if (a > 0)
                    {
                        for (int i = a; i >= 0; i--)
                        {
                            for (int j = i; j >= 0; j--)
                            {
                            textBox2.Text += j; textBox2.Text += "  ";
                            }
                        textBox2.Text += Environment.NewLine;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Число должно быть положительным");
                    }
                }
                catch
                {
                        MessageBox.Show("Некорректный ввод данных");
                }
            }
        }
    }


