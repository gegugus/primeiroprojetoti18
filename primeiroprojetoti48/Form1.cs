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

        private void lbl_Calculadora_Click(object sender, EventArgs e)
        {

        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            operacao = "Adicao";
            valor1 = double.Parse(txt_Display.Text); 
            txt_Resultado.Text = valor1.ToString() + " + ";
            txt_Display.Clear();
        }


        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            operacao = "Subtracao";
            valor1 = double.Parse(txt_Display.Text);
            txt_Resultado.Text = valor1.ToString() + " - ";
            txt_Display.Clear();
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            operacao = "Multiplicacao";
            valor1 = double.Parse(txt_Display.Text);
            txt_Resultado.Text = valor1.ToString() + " x ";
            txt_Display.Clear();
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            operacao = "Divisao";
            valor1 = double.Parse(txt_Display.Text);
            txt_Resultado.Text = valor1.ToString() + " / ";
            txt_Display.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_NumA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Resultado_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn1_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn9.Text;
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btnvirgula.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_Display.Text += btn0.Text;
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "Adicao":
                    valor2 = double.Parse(txt_Display.Text);
                    resultado = valor1 + valor2;
                    txt_Resultado.Text = valor1.ToString() + " + " + valor2.ToString();
                    txt_Display.Text = resultado.ToString();
                    break;

                case "Subtracao":
                    valor2 = double.Parse(txt_Display.Text);
                    resultado = valor1 - valor2;
                    txt_Resultado.Text = valor1.ToString() + " + " + valor2.ToString();
                    txt_Display.Text = resultado.ToString();
                    break;

                case "Multiplicacao":
                    valor2 = double.Parse(txt_Display.Text);
                    resultado = valor1 * valor2;
                    txt_Resultado.Text = valor1.ToString() + " + " + valor2.ToString();
                    txt_Display.Text = resultado.ToString();
                    break;

                case "Divisao":
                    valor2 = double.Parse(txt_Display.Text);
                    resultado = valor1 / valor2;
                    txt_Resultado.Text = valor1.ToString() + " + " + valor2.ToString();
                    txt_Display.Text = resultado.ToString();
                    break;
            }
        }
    }
}
