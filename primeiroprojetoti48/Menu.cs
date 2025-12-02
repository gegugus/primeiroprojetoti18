using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            //Link Rodapé
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;
        }
        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Form1 Calculadora = new Form1();
            Calculadora.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes Cliente = new CadastroClientes();
            Cliente.ShowDialog();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            Produtos Produto = new Produtos();
            Produto.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
