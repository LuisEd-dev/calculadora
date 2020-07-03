using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class operacoes
    {
        public String op;
        public Double n1;

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
            }
            else
            {
                return 0;
            }
        }

        public void soma( String textbox)
        {
            op = "soma";
            n1 = Convert.ToDouble(textbox);
        }
        public void sub(String textbox)
        {
            op = "sub";
            n1 = Convert.ToDouble(textbox);
        }
        public void mult(String textbox)
        {
            op = "mult";
            n1 = Convert.ToDouble(textbox);
        }
        public void div(String textbox)
        {
            op = "div";
            n1 = Convert.ToDouble(textbox);
        }
        public string igual(String n2)
        {
            return Convert.ToString(conta(op, n1, Convert.ToDouble(n2)));
        }
        
        public void ms(String textbox)
        {
            StreamWriter ms = new StreamWriter("ms.txt");
            ms.WriteLine(textbox);
            ms.Close();
        }
        public string mr()
        {
            StreamReader mr = new StreamReader("ms.txt");
            String readline = mr.ReadLine();
            mr.Close();
            return readline;
        }
        public void mc()
        {
            StreamWriter mc = new StreamWriter("ms.txt");
            mc.Flush();
            mc.Close();
        }
        public String mmais(String textbox)
        {
            StreamReader mr = new StreamReader("ms.txt");
            Double valor = Convert.ToDouble(mr.ReadLine());
            mr.Close();
            valor = valor + Convert.ToDouble(textbox);
            StreamWriter ms = new StreamWriter("ms.txt");
            ms.WriteLine(valor);
            ms.Close();
            mr = new StreamReader("ms.txt");
            String readline = mr.ReadLine();
            mr.Close();
            return readline;
        }
        public String mmenos(String textbox)
        {
            StreamReader mr = new StreamReader("ms.txt");
            Double valor = Convert.ToDouble(mr.ReadLine());
            mr.Close();
            valor = valor - Convert.ToDouble(textbox);
            StreamWriter ms = new StreamWriter("ms.txt");
            ms.WriteLine(valor);
            ms.Close();
            mr = new StreamReader("ms.txt");
            String readline = mr.ReadLine();
            mr.Close();
            return readline;
        }

    }
}
