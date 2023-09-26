using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_calc_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            switch (comboBox1.Text)

            {
                case "+":
                    textBox3.Text = Convert.ToString(a + b);

                    break;

                case "-":
                    textBox3.Text = Convert.ToString(a - b);

                    break;

                case "*":
                    textBox3.Text = Convert.ToString(a * b);

                    break;

                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя");
                    }
                    textBox3.Text = Convert.ToString(a / b);

                    break;

                case "^": // Обрабатываем операцию возведения в степень
                    textBox3.Text = Convert.ToString(Math.Pow(a, b));
                    break;
                case "√":     // Обрабатываем операцию извлечения корня
                    textBox3.Text = Convert.ToString(Math.Sqrt(a));
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
