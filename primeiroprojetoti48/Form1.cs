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
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Calculadora_Click(object sender, EventArgs e)
        {

        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txt_NumA.Text);
            double valor2 = double.Parse(txt_NumB.Text);
            double resultado = valor1 + valor2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txt_NumA.Text);
            double valor2 = double.Parse(txt_NumB.Text);
            double resultado = valor1 - valor2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txt_NumA.Text);
            double valor2 = double.Parse(txt_NumB.Text);
            double resultado = valor1 * valor2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            double valor1 = double.Parse(txt_NumA.Text);
            double valor2 = double.Parse(txt_NumB.Text);
            double resultado = valor1 / valor2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
