using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        double valor1 =0;
        double valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

      

        private void btn0_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "6";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textResultado.Text = textResultado.Text + "9";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textResultado.Text);
            textResultado.Text = "";
            operacao = "SOMA";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textResultado.Text);
            if(operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBT")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void btnsubt_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textResultado.Text);
            textResultado.Text = "";
            operacao = "SUBT";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textResultado.Text);
            textResultado.Text = "";
            operacao = "MULT";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textResultado.Text);
            textResultado.Text = "";
            operacao = "DIV";
        }
    }
}
