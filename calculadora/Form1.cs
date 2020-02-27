using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op;
        double n1, n2;
        private double conta(string op, double n1, double n2)
        {
            if (op == "soma")
            {
                return (n1 + n2);
            }
            else if (op == "sub")
            {
                return (n1 - n2);
            }
            else if (op == "mult")
            {
                return (n1 * n2);
            }
            else if (op == "div")
            {
                return (n1 / n2);
            } else
            {
                return 0;
            }
            
        }
        private void opcoes()
        {
            if (this.Width < 300)
            {
                button18.Text = "<";
                this.Width = 350;
            } else
            {
                button18.Text = ">";
                this.Width = 270;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button22.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                op = "soma";
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                op = "sub";
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                op = "mult";
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                op = "div";
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = null;
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            catch
            {
                textBox1.Text = null;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            opcoes();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            StreamWriter ms = new StreamWriter("ms.txt");
            ms.WriteLine(textBox1.Text);
            ms.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            StreamReader mr = new StreamReader("ms.txt");
            textBox1.Text = mr.ReadLine();
            mr.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            StreamWriter mc = new StreamWriter("ms.txt");
            mc.Flush();
            mc.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader mr = new StreamReader("ms.txt");
                Double valor = Convert.ToDouble(mr.ReadLine());
                mr.Close();
                valor = valor + Convert.ToDouble(textBox1.Text);
                StreamWriter ms = new StreamWriter("ms.txt");
                ms.WriteLine(valor);
                ms.Close();
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader mr = new StreamReader("ms.txt");
                Double valor = Convert.ToDouble(mr.ReadLine());
                mr.Close();
                valor = valor - Convert.ToDouble(textBox1.Text);
                StreamWriter ms = new StreamWriter("ms.txt");
                ms.WriteLine(valor);
                ms.Close();
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                n2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(conta(op, n1, n2));
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }
    }
}
