using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class CadVendas : Form
    {
        BindingList<ItemCarrinho> listaCarrinho = new BindingList<ItemCarrinho>();
        int clienteIdSelecionado = 0;
        private Funcionario usuarioLogado;

        public CadVendas(Funcionario func)
        {
            InitializeComponent();
            this.usuarioLogado = func;

            ConfigurarLayout();
            ConfigurarEventos();
        }
        private void CadVendas_Load(object sender, EventArgs e)
        {
            DTG_View.DataSource = listaCarrinho;
            DTG_View.Dock = DockStyle.Fill;
            DTG_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox.Dock = DockStyle.Fill;

            CarregarComboProdutos();
            AlternarLogistica(false);

            if (usuarioLogado != null)
            {
                LBL_NOMEPROGRAMA.Text = $"BEM VINDO AO KERN, {usuarioLogado.NomeFunc.ToUpper()}";
            }

            AjustarControlesInternos(this);
            AjustarRodape();
            CentralizarBotoes();
            this.Focus();
        }

        private void ConfigurarLayout()
        {
            PANEL1.Width = (int)(this.ClientSize.Width * 0.45);

            //PANEL1
            FLOW_BOTOES_ENDERECO.SendToBack();
            PANEL_END2.SendToBack();
            PANEL_END1.SendToBack();
            PANEL_DADOSPESSOAIS.SendToBack();

            //PANEL2
            PANEL_RESUMO.SendToBack();
            FLOW_BOTOES_PRODUTO.SendToBack();
            PANEL_IMG_DESC.SendToBack();
            PANEL_PRODUTOS.SendToBack();

            PANEL_RESUMO.Dock = DockStyle.Fill;
            DTG_View.Dock = DockStyle.Fill;
            DTG_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //BOTÃO COMPRAR
            BtnRegistrarCompra.AutoSize = false;
        }
        private void CentralizarBotoes()
        {
            if (FLOW_BOTOES_PRODUTO != null)
            {
                BtnRegistrarCompra.Width = FLOW_BOTOES_PRODUTO.ClientSize.Width - (BtnRegistrarCompra.Margin.Left + BtnRegistrarCompra.Margin.Right + 10);
            }

            FlowLayoutPanel[] fluxos = { FLOW_BOTOES_ENDERECO, FLOW_BOTOES_PRODUTO };

            foreach (var f in fluxos)
            {
                if (f != null)
                {
                    f.FlowDirection = FlowDirection.LeftToRight;

                    f.Padding = new Padding(20, 10, 0, 10);

                    foreach (Control c in f.Controls)
                    {
                        c.Anchor = AnchorStyles.Left;
                    }
                }
            }
        }

        private void AjustarControlesInternos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl && lbl.Parent is TableLayoutPanel)
                {
                    lbl.AutoSize = true;
                    lbl.Dock = DockStyle.None;
                    lbl.Anchor = AnchorStyles.Left;
                    lbl.Margin = new Padding(3, 3, 3, 0);
                }

                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    if (c.Parent is TableLayoutPanel)
                    {
                        c.Anchor = AnchorStyles.None;
                        c.Dock = DockStyle.Fill;
                    }
                    c.Margin = new Padding(3, 0, 3, 5);
                    if (c is TextBox t) t.CharacterCasing = CharacterCasing.Upper;
                }

                if (c is Button btn && btn.Parent is FlowLayoutPanel)
                {
                    btn.Dock = DockStyle.None;
                    btn.Anchor = AnchorStyles.None;
                }

                if (c.HasChildren) AjustarControlesInternos(c);
            }
        }
        private void AjustarRodape()
        {
            LBL_NomeProgramaRodape.AutoSize = true;
            LblLink.AutoSize = true;
            int totalWidth = LBL_NomeProgramaRodape.Width + LblLink.Width + 5;
            int startX = (PANEL_RODAPE.ClientSize.Width - totalWidth) / 2;
            int yPos = (PANEL_RODAPE.ClientSize.Height - LBL_NomeProgramaRodape.Height) / 2;
            LBL_NomeProgramaRodape.Location = new Point(startX, yPos);
            LblLink.Location = new Point(LBL_NomeProgramaRodape.Right + 5, yPos);
        }
        private void ConfigurarEventos()
        {
            TxtCPF.Leave += TxtCPF_Leave;
            TxtQuantidade.KeyDown += TxtQuantidade_KeyDown;
            TxtDesconto.TextChanged += TxtDesconto_TextChanged;
            CB_FormaPag.SelectedIndexChanged += ValidarPagamento;
            CB_Parcelamento.SelectedIndexChanged += CalcularParcelas;
            BtnRetirada.Click += (s, e) => AlternarLogistica(false);
            BtnEntrega.Click += (s, e) => AlternarLogistica(true);
            CB_Produtos.SelectedIndexChanged += CB_Produtos_SelectedIndexChanged;
            this.SizeChanged += (s, e) => { AjustarRodape(); CentralizarBotoes(); };
        }

        private void CarregarComboProdutos()
        {
            try
            {
                using (SqlConnection conn = ConnBD.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ProdutoID, Nome FROM PRODUTOS ORDER BY Nome ASC", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CB_Produtos.DataSource = dt;
                    CB_Produtos.DisplayMember = "Nome";
                    CB_Produtos.ValueMember = "ProdutoID";
                    CB_Produtos.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CB_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Produtos.SelectedValue != null && int.TryParse(CB_Produtos.SelectedValue.ToString(), out int id))
            {
                try
                {
                    using (SqlConnection conn = ConnBD.GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand("SELECT Imagem FROM PRODUTOS WHERE ProdutoID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            if (dr["Imagem"] != DBNull.Value)
                            {
                                byte[] data = (byte[])dr["Imagem"];
                                PictureBox.Image = Image.FromStream(new MemoryStream(data));
                            }
                            else PictureBox.Image = null;
                        }
                    }
                }
                catch { PictureBox.Image = null; }
            }
        }
        private void AlternarLogistica(bool entrega)
        {
            PANEL_END1.Enabled = entrega;
            PANEL_END2.Enabled = entrega;

            Color corEntrega = Color.FromArgb(27, 94, 103);   
            Color corRetirada = Color.FromArgb(210, 143, 133); 
            Color corFundoForm = Color.FromArgb(235, 235, 235); 


            BtnEntrega.BackColor = entrega ? corEntrega : corFundoForm;
            BtnRetirada.BackColor = !entrega ? corRetirada : corFundoForm;

            BtnEntrega.ForeColor = entrega ? Color.White : Color.Black;
            BtnRetirada.ForeColor = !entrega ? Color.Black : Color.Black;
        }

        private void ValidarPagamento(object sender, EventArgs e)
        {
            string forma = CB_FormaPag.Text.ToUpper();
            CB_Band.Enabled = forma.Contains("CARTÃO");
            CB_Parcelamento.Enabled = forma.Contains("CRÉDITO");
            if (!CB_Parcelamento.Enabled) { CB_Parcelamento.SelectedIndex = -1; TxtValorParcelado.Clear(); }
            CalcularParcelas(null, null);
        }
        private void CalcularParcelas(object sender, EventArgs e)
        {
            if (!CB_Parcelamento.Enabled || CB_Parcelamento.SelectedIndex == -1) return;
            if (decimal.TryParse(TxtValorTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal total))
            {
                string n = Regex.Replace(CB_Parcelamento.Text, @"[^\d]", "");
                if (int.TryParse(n, out int p) && p > 0)
                {
                    TxtValorParcelado.Text = $"{p}x de {(total / p):C2}";
                }
            }
        }

        private void TxtCPF_Leave(object sender, EventArgs e)
        {
            string cpf = Regex.Replace(TxtCPF.Text, @"[^\d]", "");
            if (cpf.Length < 11) return;
            try
            {
                using (SqlConnection conn = ConnBD.GetConnection())
                {
                    string sql = @"SELECT c.ClienteID, c.Nome, ct.Telefone, ct.Email, 
                                  e.Logradouro, e.Numero, e.Bairro, e.Cidade, e.Estado, e.Cep 
                           FROM CLIENTES c 
                           LEFT JOIN ENDERECO e ON c.ClienteID = e.ClienteID 
                           LEFT JOIN CONTATOS ct ON c.ClienteID = ct.ClienteID 
                           WHERE c.CPF = @cpf";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        clienteIdSelecionado = (int)dr["ClienteID"];
                        TxtNome.Text = dr["Nome"].ToString();
                        TxtTelefone.Text = dr["Telefone"].ToString();
                        TxtEmail.Text = dr["Email"].ToString();
                        TxtEndereco.Text = dr["Logradouro"].ToString();
                        TxtNumero.Text = dr["Numero"].ToString();
                        TxtBairro.Text = dr["Bairro"].ToString();
                        TxtCidade.Text = dr["Cidade"].ToString();
                        TxtEstado.Text = dr["Estado"].ToString();
                        TxtCEP.Text = dr["Cep"].ToString();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AtualizarTotais()
        {
            decimal soma = listaCarrinho.Sum(x => x.Subtotal);
            decimal.TryParse(TxtDesconto.Text.Replace("%", ""), out decimal perc);

            decimal valorDesconto = soma * (perc / 100);
            decimal vFinal = soma - valorDesconto;

            TxtSemDesconto.Text = soma.ToString("C2");
            TxtComDesconto.Text = vFinal.ToString("C2");
            TxtValorTotal.Text = vFinal.ToString("C2");

            CalcularParcelas(null, null);
        }

        private void AtualizarCalculoParcelas(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            listaCarrinho.Clear();
            clienteIdSelecionado = 0;
            TxtCPF.Clear();
            TxtNome.Clear();
            TxtTelefone.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtNumero.Clear();
            TxtBairro.Clear();
            TxtCidade.Clear();
            TxtEstado.Clear();
            TxtCEP.Clear();
            TxtQuantidade.Clear();
            TxtValorTotal.Clear();
            TxtValorParcelado.Clear();
            CB_FormaPag.SelectedIndex = -1;
            PictureBox.Image = null;
            AlternarLogistica(false);
        }


        private void BtnRegistrarProduto_Click(object sender, EventArgs e)
        {
            if (CB_Produtos.SelectedValue == null || !int.TryParse(TxtQuantidade.Text, out int qtd)) return;
            using (SqlConnection conn = ConnBD.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT Preco, Estoque FROM PRODUTOS WHERE ProdutoID = @id", conn);
                cmd.Parameters.AddWithValue("@id", (int)CB_Produtos.SelectedValue);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    decimal pre = Convert.ToDecimal(dr["Preco"]);
                    if (qtd > Convert.ToInt32(dr["Estoque"])) { MessageBox.Show("Estoque insuficiente."); return; }
                    listaCarrinho.Add(new ItemCarrinho { ProdutoID = (int)CB_Produtos.SelectedValue, Nome = CB_Produtos.Text, Quantidade = qtd, PrecoUnitario = pre });
                    AtualizarTotais();
                }
            }
        }

        private void BtnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (DTG_View.CurrentRow != null)
            {
                var item = (ItemCarrinho)DTG_View.CurrentRow.DataBoundItem;
                CB_Produtos.SelectedValue = item.ProdutoID;
                TxtQuantidade.Text = item.Quantidade.ToString();
                listaCarrinho.Remove(item);
                AtualizarTotais();
                TxtQuantidade.Focus();
            }
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (DTG_View.CurrentRow != null && MessageBox.Show("Excluir?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaCarrinho.Remove((ItemCarrinho)DTG_View.CurrentRow.DataBoundItem);
                AtualizarTotais();
            }
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (clienteIdSelecionado == 0 || listaCarrinho.Count == 0) return;

            string formaPagamento = CB_FormaPag.Text.ToUpper();
            if (formaPagamento.Contains("CARTÃO"))
            {
                if (CB_Band.SelectedIndex == -1 || string.IsNullOrWhiteSpace(CB_Band.Text))
                {
                    MessageBox.Show("Por favor, selecione a BANDEIRA do cartão.");
                    CB_Band.Focus();
                    return;
                }
            }

            using (SqlConnection conn = ConnBD.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sqlV = @"INSERT INTO VENDAS (ClienteID, FuncionarioID, ValorTotal, Desconto, TipoEntrega, EnderecoEntrega, FormaPagamento, BandeiraCartao, Parcelas, ValorParcelado_Texto) 
                           OUTPUT INSERTED.VendaID VALUES (@cid, @fid, @total, @desc, @tipo, @end, @forma, @band, @parc, @vparc)";

                    SqlCommand cmdV = new SqlCommand(sqlV, conn, trans);
                    cmdV.Parameters.AddWithValue("@cid", clienteIdSelecionado);
                    cmdV.Parameters.AddWithValue("@fid", usuarioLogado != null ? usuarioLogado.ID : 1);
                    cmdV.Parameters.AddWithValue("@total", decimal.Parse(TxtValorTotal.Text, NumberStyles.Currency));
                    cmdV.Parameters.AddWithValue("@desc", decimal.TryParse(TxtDesconto.Text.Replace("%", ""), out decimal d) ? d : 0);

                    bool isEntrega = PANEL_END1.Enabled;
                    cmdV.Parameters.AddWithValue("@tipo", isEntrega ? "ENTREGA" : "RETIRADA");
                    cmdV.Parameters.AddWithValue("@end", isEntrega ? $"{TxtEndereco.Text}, {TxtNumero.Text}" : "RETIRADA");

                    cmdV.Parameters.AddWithValue("@forma", CB_FormaPag.Text);
                    cmdV.Parameters.AddWithValue("@band", CB_Band.Enabled ? CB_Band.Text : (object)DBNull.Value);

                    int p = 1;
                    if (CB_Parcelamento.Enabled && CB_Parcelamento.SelectedIndex != -1)
                        int.TryParse(Regex.Replace(CB_Parcelamento.Text, @"[^\d]", ""), out p);

                    cmdV.Parameters.AddWithValue("@parc", p);
                    cmdV.Parameters.AddWithValue("@vparc", TxtValorParcelado.Text);

                    int vId = (int)cmdV.ExecuteScalar();

                    foreach (var i in listaCarrinho)
                    {
                        SqlCommand cmdI = new SqlCommand("INSERT INTO VENDAS_ITENS (VendaID, ProdutoID, Quantidade, PrecoUnitario) VALUES (@vid, @pid, @qtd, @pre)", conn, trans);
                        cmdI.Parameters.AddWithValue("@vid", vId);
                        cmdI.Parameters.AddWithValue("@pid", i.ProdutoID);
                        cmdI.Parameters.AddWithValue("@qtd", i.Quantidade);
                        cmdI.Parameters.AddWithValue("@pre", i.PrecoUnitario);
                        cmdI.ExecuteNonQuery();

                        new SqlCommand($"UPDATE PRODUTOS SET Estoque = Estoque - {i.Quantidade} WHERE ProdutoID = {i.ProdutoID}", conn, trans).ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Venda registrada!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtQuantidade_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Enter) BtnRegistrarProduto.PerformClick(); }
        private void TxtDesconto_TextChanged(object sender, EventArgs e) => AtualizarTotais();
    
        private void PANEL2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblBandDeb_Click(object sender, EventArgs e)
        {

        }
    }
}

