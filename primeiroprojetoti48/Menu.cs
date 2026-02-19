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

namespace primeiroprojetoti48
{
    public partial class Menu : Form
    {
        private Funcionario usuarioLogado;
        public Menu(Funcionario func)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.usuarioLogado = func;

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


        private void Menu_Load(object sender, EventArgs e)
        {
            if (usuarioLogado != null)
            {
                LBL_NOMEPROGRAMA.Text = $"BEM VINDO AO KERN, {usuarioLogado.NomeFunc.ToUpper()}";
            }

            PANEL_RODAPE.Dock = DockStyle.Bottom;

            LBL_NomeProgramaRodape.AutoSize = true;
            LblLink.AutoSize = true;

            LayoutConfig();
        }

        //COFIGURAÇÃO LAYOUT
        private void LayoutConfig()
        {
            PANEL_RODAPE.Width = this.ClientSize.Width;
            PANEL_RODAPE.PerformLayout();

            int larguraUtil = this.ClientSize.Width;
            int alturaUtil = this.ClientSize.Height - PANEL_RODAPE.Height;

            int larguraTotalPaineis = PANEL1.Width + PANEL2.Width + PANEL3.Width + PANEL4.Width + 60;
            int xInicial = (larguraUtil - larguraTotalPaineis) / 2;
            int yPosicao = (alturaUtil - PANEL1.Height) / 2;

            if (xInicial < 20) xInicial = 20;

            PANEL1.Location = new Point(xInicial, yPosicao);
            PANEL2.Location = new Point(PANEL1.Right + 20, yPosicao);
            PANEL3.Location = new Point(PANEL2.Right + 20, yPosicao);
            PANEL4.Location = new Point(PANEL3.Right + 20, yPosicao);

            LBL_NOMEPROGRAMA.Left = (larguraUtil - LBL_NOMEPROGRAMA.Width) / 2;
            LBL_NOMEPROGRAMA.Top = Math.Max(50, PANEL1.Top - 80);

            AjustarRodape();
        }

        private void AjustarRodape()
        {
            LBL_NomeProgramaRodape.AutoSize = true;
            LblLink.AutoSize = true;

            LBL_NomeProgramaRodape.Text = "KERN - Gestão Inteligente | 2026 | @Gegugus |";

            int espacamento = 5;
            int larguraTotal = LBL_NomeProgramaRodape.Width + LblLink.Width + espacamento;

            int startX = (PANEL_RODAPE.Width - larguraTotal) / 2;
            int yCentro = (PANEL_RODAPE.Height - LBL_NomeProgramaRodape.Height) / 2;

            LBL_NomeProgramaRodape.Location = new Point(startX, yCentro);
            LblLink.Location = new Point(LBL_NomeProgramaRodape.Right + espacamento, yCentro);
        }


        private void Menu_Resize(object sender, EventArgs e)
        {
            LayoutConfig();
        }

        //CLICK - MENU STRIP
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void aUDITORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TB_Auditoria tela = new TB_Auditoria();
            tela.Show();
        }

        private void dESLOGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente deslogar?", "KERN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login telaLogin = new Login();
                telaLogin.ShowDialog();
                this.Close();
            }
        }

        //CLICK - PANEL
        private void PANEL1_Click(object sender, EventArgs e)
        {
            CadClientes Cliente = new CadClientes();
            Cliente.Show();
        }

        private void PANEL2_Click(object sender, EventArgs e)
        {
            CadProdutos Produto = new CadProdutos();
            Produto.ShowDialog();
        }

        private void PANEL3_Click(object sender, EventArgs e)
        {
            Vendas Venda = new Vendas();
            Venda.Show();
        }

        private void PANEL4_Click(object sender, EventArgs e)
        {
            //NomeForm.ShowDialog(); =  Janela não permite abrir outra
            //NomeForm.Show(); =  Janela permite abrir outra
            Form1 Calculadora = new Form1();
            Calculadora.Show();
        }

        //DESIGN - PANEL
        private void PANEL1_MouseEnter(object sender, EventArgs e)
        {
            PANEL1.BackColor = ColorTranslator.FromHtml("#154734");
        }

        private void PANEL1_MouseLeave(object sender, EventArgs e)
        {
            PANEL1.BackColor = ColorTranslator.FromHtml("#0B3022");
        }

        private void PANEL2_MouseEnter(object sender, EventArgs e)
        {
            PANEL2.BackColor = ColorTranslator.FromHtml("#96AA67");
        }

        private void PANEL2_MouseLeave(object sender, EventArgs e)
        {
            PANEL2.BackColor = ColorTranslator.FromHtml("#84965A");
        }

        private void PANEL3_MouseEnter(object sender, EventArgs e)
        {
            PANEL3.BackColor = ColorTranslator.FromHtml("#227681");
        }

        private void PANEL3_MouseLeave(object sender, EventArgs e)
        {
            PANEL3.BackColor = ColorTranslator.FromHtml("#1B5E67");
        }

        private void PANEL4_MouseEnter(object sender, EventArgs e)
        {
            PANEL4.BackColor = ColorTranslator.FromHtml("#DEA49B");
        }

        private void PANEL4_MouseLeave(object sender, EventArgs e)
        {
            PANEL4.BackColor = ColorTranslator.FromHtml("#D28F85");
        }

        private void PANEL_Resize(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            p.Invalidate(); 
        }

        private void ArredondarPainel(object sender, PaintEventArgs e)
        {
            //ESTUDO ARREDONDAMENTO DE QUINAS EM BOTÕES - GEMINI IA (USADA)
            Panel p = (Panel)sender;
            int r = 30; // Raio do arredondamento
            int d = 50; // Tamanho do corte diagonal

            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            // 1. Canto Superior Esquerdo (AGORA É A DIAGONAL)
            // A linha começa no ponto (0, d) e vai até (d, 0)
            gp.AddLine(0, d, d, 0);

            // 2. Canto Superior Direito (VOLTA A SER ARREDONDADO)
            gp.AddArc(p.Width - r, 0, r, r, 270, 90);

            // 3. Canto Inferior Direito (ARREDONDADO)
            gp.AddArc(p.Width - r, p.Height - r, r, r, 0, 90);

            // 4. Canto Inferior Esquerdo (ARREDONDADO)
            gp.AddArc(0, p.Height - r, r, r, 90, 90);

            gp.CloseFigure();

            // Aplica o formato ao painel
            p.Region = new Region(gp);

            // Melhora a qualidade do desenho
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Desenha uma borda fina para destacar o corte
            using (Pen lapis = new Pen(Color.FromArgb(40, Color.White), 2))
            {
                e.Graphics.DrawPath(lapis, gp);
            }
        }

  
    }
}
