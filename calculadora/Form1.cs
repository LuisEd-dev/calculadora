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

        operacoes referencia = new operacoes();

        private void opcoes()
        {
            if (this.Width < 300)
            {
                button18.Text = "<";
                this.Width = 350;
            } else
            {
                button18.Text = ">";
                this.Width = 286;
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
                referencia.soma(textBox1.Text);
                textBox1.Text = null;
            } catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                referencia.sub(textBox1.Text);
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
                referencia.mult(textBox1.Text);
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
                referencia.div(textBox1.Text);
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
            referencia.ms(textBox1.Text);
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = referencia.mr();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            referencia.mc();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                referencia.mmais(textBox1.Text);
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
                referencia.mmenos(textBox1.Text);
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
                textBox1.Text = referencia.igual(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Preencha o campo corretamente!");
            }
        }
    }
}
