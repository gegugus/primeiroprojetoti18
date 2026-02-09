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
            this.WindowState = FormWindowState.Maximized;

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
            //NomeForm.ShowDialog(); =  Janela não permite abrir outra
            //NomeForm.Show(); =  Janela permite abrir outra
            Form1 Calculadora = new Form1();
            Calculadora.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            CadastroClientes Cliente = new CadastroClientes();
            Cliente.Show();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            Produtos Produto = new Produtos();
            Produto.ShowDialog();
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            Vendas Venda = new Vendas();
            Venda.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_Vendas tela = new TB_Vendas();
            tela.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_Clientes tela = new TB_Clientes();
            tela.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_Produtos tela = new TB_Produtos();
            tela.Show();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB_Auditoria tela = new TB_Auditoria();
            tela.Show();
        }
    }
}
