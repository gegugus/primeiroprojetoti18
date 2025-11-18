using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Form1 : Form
    {
        double resultado, valor1, valor2;
        string operacao;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }

        private void LblCalculadora_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
        }
        private void BtnLimparChar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
        }

        private void BtnMaisMenos_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtDisplay.Text);
            valor1 *= -1;
            txtDisplay.Clear();
            txtDisplay.Text = valor1.ToString();
        }

        private void BtnPorcentagem_Click(object sender, EventArgs e)
        {
            double porcentagem;
            valor1 = 0;

            valor1 = double.Parse(txtDisplay.Text);

            if (valor1 > 0)
            {
                porcentagem = valor1 / 100;
                txtDisplay.Text = porcentagem.ToString() + " % ";
            }
            else
            {
                porcentagem = resultado / 100;
                txtDisplay.Text = porcentagem.ToString() + " % ";
            }
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            double pi = 3.14;

            if (string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                txtDisplay.Text = pi.ToString();
            }
            else
            {
                valor1 = double.Parse(txtDisplay.Text);
                pi = valor1 * pi;
                txtDisplay.Text = pi.ToString();
            }
        }

        private void BtnFatorial_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtDisplay.Text);
            resultado = 1;

            for (int i = 1; i <= valor1; i++)
            {
                resultado *= i;
            }

            txtDisplay.Text = valor1.ToString();
            txtResultado.Text = resultado.ToString() + "!";
        }

        private void BtnEQuadrado_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtDisplay.Text);
            resultado = valor1 * valor1;
            txtDisplay.Text = resultado.ToString();
            txtResultado.Text = valor1.ToString() + "²";
        }
        private void BtnECubo_Click(object sender, EventArgs e)
        {
            operacao = "elevacao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + "^";
            txtDisplay.Clear();
        }
        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            operacao = "Adicao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " + ";
            txtDisplay.Clear();
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            operacao = "Subtracao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " - ";
            txtDisplay.Clear();
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacao = "Multiplicacao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " x ";
            txtDisplay.Clear();
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            operacao = "Divisao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " / ";
            txtDisplay.Clear();
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "Adicao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 + valor2;
                    txtResultado.Text = valor1.ToString() + " + " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "Subtracao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 - valor2;
                    txtResultado.Text = valor1.ToString() + " - " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "Multiplicacao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 * valor2;
                    txtResultado.Text = valor1.ToString() + " x " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "Divisao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 / valor2;
                    txtResultado.Text = valor1.ToString() + " / " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "elevacao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = 1;
                    for (int i = 1; i <= valor2; i++)
                    {
                        resultado *= valor1;
                    }
                    txtResultado.Text = valor1.ToString() + "^" + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn1.Text;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn2.Text;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn3.Text;
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn4.Text;
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn5.Text;
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn6.Text;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn7.Text;
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn8.Text;
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn9.Text;
        }
        private void Btnvirgula_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += BtnVirgula.Text;
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += Btn0.Text;
        }

        private void Txt_NumA_TextChanged(object sender, EventArgs e)
        {

        }
        private void Txt_Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        //private void btnNumero_Click(object sender, EventArgs e)
        //{
        //    Button botao = (Button)sender;

        //    txtDisplay.Text += botao.Text;
        //    valor1 = double.Parse(txtDisplay.Text);
        //}
    }
}
