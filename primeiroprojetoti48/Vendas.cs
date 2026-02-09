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
    public partial class Vendas : Form
    {
        BindingList<ItemCarrinho> listaCarrinho = new BindingList<ItemCarrinho>();
        int clienteIdSelecionado = 0;
        public Vendas()
        {
            InitializeComponent();
            this.TxtQuantidade.KeyDown += new KeyEventHandler(this.TxtDesconto_KeyDown);
            this.TxtCPFCliente.Leave += new EventHandler(this.TxtCPFCliente_Leave);
        }

        private void Vendas_Load(object sender, EventArgs e)
        {
            DTG_View.DataSource = listaCarrinho;
            CarregarComboProdutos();
        }

        private void CarregarComboProdutos()
        {
            try
            {
                using (SqlConnection conn = ConnBD.GetConnection())
                {
                    string sql = "SELECT ProdutoID, Nome FROM PRODUTOS ORDER BY Nome ASC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CB_Produtos.DataSource = dt;
                    CB_Produtos.DisplayMember = "Nome";
                    CB_Produtos.ValueMember = "ProdutoID";
                    CB_Produtos.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro: " + ex.Message); }
        }

        private void CB_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Produtos.SelectedValue != null && int.TryParse(CB_Produtos.SelectedValue.ToString(), out int produtoId))
            {
                try
                {
                    using (SqlConnection conn = ConnBD.GetConnection())
                    {
                        string sql = "SELECT Imagem FROM PRODUTOS WHERE ProdutoID = @id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", produtoId);
                        conn.Open();

                        object result = cmd.ExecuteScalar();
                        if (PictureBox.Image != null) PictureBox.Image.Dispose();

                        if (result != DBNull.Value && result != null)
                        {
                            byte[] imgData = (byte[])result;
                            using (MemoryStream ms = new MemoryStream(imgData))
                            {
                                PictureBox.Image = Image.FromStream(ms);
                                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            }
                        }
                        else { PictureBox.Image = null; }
                    }
                }
                catch { PictureBox.Image = null; }
            }
        }

        private void TxtCPFCliente_Leave(object sender, EventArgs e)
        {
            string cpf = System.Text.RegularExpressions.Regex.Replace(TxtCPFCliente.Text, @"[^\d]", "");

            if (cpf.Length < 11) return;

            try
            {
                using (SqlConnection conn = ConnBD.GetConnection())
                {
                    string sql = "SELECT ClienteID FROM CLIENTES WHERE CPF = @cpf";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        clienteIdSelecionado = Convert.ToInt32(result);
                    }
                    else
                    {
                        clienteIdSelecionado = 0;
                        MessageBox.Show("CPF não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
            }
        }


        private void TxtDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarTotais();
                e.SuppressKeyPress = true;
            }
        }
        private void AtualizarTotais()
        {
            decimal somaSubtotais = listaCarrinho.Sum(x => x.Subtotal);

            string descTexto = TxtDesconto.Text.Replace("%", "").Trim();

            decimal percDesconto = 0;
            if (!string.IsNullOrEmpty(descTexto))
            {
                decimal.TryParse(descTexto, out percDesconto);
            }

            decimal valorDesconto = somaSubtotais * (percDesconto / 100);
            decimal valorFinal = somaSubtotais - valorDesconto;

            TxtSemDesconto.Text = somaSubtotais.ToString("C2");
            TxtComDesconto.Text = valorFinal.ToString("C2");
            TxtValorTotal.Text = valorFinal.ToString("C2");
        }

        private void BtnRegistrarProduto_Click(object sender, EventArgs e)
        {
            if (CB_Produtos.SelectedValue == null || string.IsNullOrEmpty(TxtQuantidade.Text))
            {
                MessageBox.Show("Preencha os campos.");
                return;
            }

            if (!int.TryParse(TxtQuantidade.Text, out int qtd)) return;

            decimal precoUnit = 0;
            int estoqueAtual = 0;

            using (SqlConnection conn = ConnBD.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT Preco, Estoque FROM PRODUTOS WHERE ProdutoID = @id", conn);
                cmd.Parameters.AddWithValue("@id", (int)CB_Produtos.SelectedValue);
                conn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        precoUnit = Convert.ToDecimal(dr["Preco"]);
                        estoqueAtual = Convert.ToInt32(dr["Estoque"]);
                    }
                }
            }

            if (qtd > estoqueAtual)
            {
                MessageBox.Show("Estoque insuficiente! Quantidade disponível: " + estoqueAtual);
                return;
            }

            listaCarrinho.Add(new ItemCarrinho
            {
                ProdutoID = (int)CB_Produtos.SelectedValue,
                Nome = CB_Produtos.Text,
                Quantidade = qtd,
                PrecoUnitario = precoUnit
            });

            AtualizarTotais();
        }

        private void BtnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (DTG_View.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Deseja excluir este produto do carrinho?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var item = (ItemCarrinho)DTG_View.CurrentRow.DataBoundItem;
                    listaCarrinho.Remove(item);
                    AtualizarTotais();
                }
            }
        }

        private void BtnAlterarProduto_Click(object sender, EventArgs e)
        {
            if (DTG_View.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Deseja alterar este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var item = (ItemCarrinho)DTG_View.CurrentRow.DataBoundItem;
                    CB_Produtos.SelectedValue = item.ProdutoID;
                    TxtQuantidade.Text = item.Quantidade.ToString();
                    listaCarrinho.Remove(item);
                    AtualizarTotais();
                    TxtQuantidade.Focus();
                }
            }
        }

        private void TxtDesconto_TextChanged(object sender, EventArgs e)
        {
            AtualizarTotais();
        }

        private void TxtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (clienteIdSelecionado == 0 || listaCarrinho.Count == 0)
            {
                MessageBox.Show("Verifique os dados.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Deseja registrar esta compra?", "Finalizar Venda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            using (SqlConnection conn = ConnBD.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sqlVenda = @"INSERT INTO VENDAS (ClienteID, DataVenda, ValorTotal, Desconto) 
                                OUTPUT INSERTED.VendaID VALUES (@cid, @data, @total, @desc)";

                    SqlCommand cmdV = new SqlCommand(sqlVenda, conn, trans);
                    cmdV.Parameters.AddWithValue("@cid", clienteIdSelecionado);
                    cmdV.Parameters.AddWithValue("@data", DTP_DataRegistro.Value);

                    decimal totalFinal = decimal.Parse(TxtValorTotal.Text, NumberStyles.Currency);
                    cmdV.Parameters.AddWithValue("@total", totalFinal);

                    decimal.TryParse(TxtDesconto.Text.Replace("%", "").Trim(), out decimal d);
                    cmdV.Parameters.AddWithValue("@desc", d);

                    int idVendaGerado = (int)cmdV.ExecuteScalar();

                    foreach (var item in listaCarrinho)
                    {
                        string sqlItem = @"INSERT INTO VENDAS_ITENS (VendaID, ProdutoID, Quantidade, PrecoUnitario) 
                                   VALUES (@vid, @pid, @qtd, @preco)";
                        SqlCommand cmdI = new SqlCommand(sqlItem, conn, trans);
                        cmdI.Parameters.AddWithValue("@vid", idVendaGerado);
                        cmdI.Parameters.AddWithValue("@pid", item.ProdutoID);
                        cmdI.Parameters.AddWithValue("@qtd", item.Quantidade);
                        cmdI.Parameters.AddWithValue("@preco", item.PrecoUnitario);
                        cmdI.ExecuteNonQuery();

                        string sqlEstoque = "UPDATE PRODUTOS SET Estoque = Estoque - @qtd WHERE ProdutoID = @pid";
                        SqlCommand cmdE = new SqlCommand(sqlEstoque, conn, trans);
                        cmdE.Parameters.AddWithValue("@qtd", item.Quantidade);
                        cmdE.Parameters.AddWithValue("@pid", item.ProdutoID);
                        cmdE.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Venda Nº " + idVendaGerado + " registrada com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    if (trans.Connection != null) trans.Rollback();
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            listaCarrinho.Clear();
            clienteIdSelecionado = 0;
            TxtCPFCliente.Clear();
            TxtQuantidade.Clear();
            TxtQuantidade.Clear();
            TxtSemDesconto.Clear();
            TxtComDesconto.Clear();
            TxtValorTotal.Clear();
            CB_Produtos.SelectedIndex = -1;
            if (PictureBox.Image != null) PictureBox.Image.Dispose();
            PictureBox.Image = null;
        }

        private void TxtIDCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
