using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class CadProdutos : Form
    {
        private string produtoSelecionadoID = "";
        private DataView dvProdutos = new DataView();
        private TableLayoutPanel gradePrincipal;
        public CadProdutos()
        {
            InitializeComponent();

            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += (s, e) => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = e.Link.LinkData.ToString(), UseShellExecute = true });

            this.Resize += (s, e) => {
                AjustarRodape();
                CentralizarBotoes();
            };

            TxtNome.TextChanged += TxtNome_TextChanged;
            TxtPreco.TextChanged += TxtPreco_TextChanged;
            TxtPreco.Click += (s, e) => TxtPreco.SelectAll();
            TxtPreco.KeyPress += TxtPreco_KeyPress;
            TxtEstoque.KeyPress += TxtEstoque_KeyPress;
            DTG_View.CellFormatting += DTG_View_CellFormatting;

            LblImgExcluir.Click -= LblImgExcluir_Click;
            LblImgExcluir.Click += LblImgExcluir_Click;
        }

        private void CadProdutos_Load(object sender, EventArgs e)
        {
            ConfigurarLayout();
            CarregarGrid();
            this.Focus();
        }
        private void ConfigurarLayout()
        {
            this.AutoScroll = false;

            PANEL_RODAPE.Parent = this;
            PANEL_RODAPE.Dock = DockStyle.Bottom;
            PANEL_RODAPE.Height = 35;
            PANEL_RODAPE.BringToFront();

            LBL_NOMEPROGRAMA.Parent = this;
            LBL_NOMEPROGRAMA.Dock = DockStyle.Top;
            LBL_NOMEPROGRAMA.Height = 40;
            LBL_NOMEPROGRAMA.BringToFront();

            gradePrincipal = new TableLayoutPanel();
            gradePrincipal.Parent = this;
            gradePrincipal.Dock = DockStyle.Fill;
            gradePrincipal.ColumnCount = 2;
            gradePrincipal.RowCount = 1;
            gradePrincipal.ColumnStyles.Clear();
            gradePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            gradePrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            gradePrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gradePrincipal.Padding = new Padding(10, 15, 10, 50);
            gradePrincipal.Margin = new Padding(0);
            gradePrincipal.SendToBack();

            TableLayoutPanel colEsquerda = new TableLayoutPanel();
            colEsquerda.Dock = DockStyle.Fill;
            colEsquerda.ColumnCount = 1;
            colEsquerda.RowCount = 5;
            colEsquerda.RowStyles.Clear();
            colEsquerda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            colEsquerda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            colEsquerda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            colEsquerda.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            colEsquerda.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            colEsquerda.Padding = new Padding(0, 0, 15, 0);
            colEsquerda.Margin = new Padding(0);

            TABLE_DADOS1.Parent = colEsquerda;
            TABLE_DADOS1.Dock = DockStyle.Fill;
            TABLE_DADOS1.Margin = new Padding(0, 0, 0, -8);
            colEsquerda.SetRow(TABLE_DADOS1, 0);

            TABLE_DADOS2.Parent = colEsquerda;
            TABLE_DADOS2.Dock = DockStyle.Fill;
            TABLE_DADOS2.Margin = new Padding(0, 0, 0, -8);
            colEsquerda.SetRow(TABLE_DADOS2, 1);

            TABLE_DADOS3.Parent = colEsquerda;
            TABLE_DADOS3.Dock = DockStyle.Fill;
            TABLE_DADOS3.Margin = new Padding(0, 0, 0, -10);
            colEsquerda.SetRow(TABLE_DADOS3, 2);

            FLOW_BOTOES_DADOS.Parent = colEsquerda;
            FLOW_BOTOES_DADOS.Dock = DockStyle.Fill;
            FLOW_BOTOES_DADOS.AutoSize = true;
            FLOW_BOTOES_DADOS.Margin = new Padding(0, 0, 0, -12);
            colEsquerda.SetRow(FLOW_BOTOES_DADOS, 3);

            PANEL_LISTA.Parent = colEsquerda;
            PANEL_LISTA.Dock = DockStyle.Fill;
            PANEL_LISTA.Margin = new Padding(0);
            colEsquerda.SetRow(PANEL_LISTA, 4);

            DTG_View.Dock = DockStyle.Fill;
            DTG_View.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DTG_View.AllowUserToAddRows = false;
            DTG_View.RowHeadersVisible = false;
            DTG_View.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DTG_View.ReadOnly = true;
            DTG_View.MultiSelect = false;
            DTG_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTG_View.EnableHeadersVisualStyles = true;

            DTG_View.CellClick -= DTG_View_CellClick;
            DTG_View.CellClick += DTG_View_CellClick;

            gradePrincipal.Controls.Add(colEsquerda, 0, 0);

            TableLayoutPanel colDireita = new TableLayoutPanel();
            colDireita.Dock = DockStyle.Fill;
            colDireita.ColumnCount = 1;
            colDireita.RowCount = 2;
            colDireita.RowStyles.Clear();
            colDireita.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            colDireita.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));

            TABLE_DADOS_IMAGEM.Parent = colDireita;
            TABLE_DADOS_IMAGEM.Dock = DockStyle.Fill;
            colDireita.SetRow(TABLE_DADOS_IMAGEM, 0);

            PictureBox.Parent = TABLE_DADOS_IMAGEM;
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            FLOW_BOTOES_IMAGEM.Parent = colDireita;
            FLOW_BOTOES_IMAGEM.Dock = DockStyle.Fill;
            FLOW_BOTOES_IMAGEM.AutoSize = false;
            FLOW_BOTOES_IMAGEM.Margin = new Padding(0);
            colDireita.SetRow(FLOW_BOTOES_IMAGEM, 1);

            gradePrincipal.Controls.Add(colDireita, 1, 0);

            AjustarControlesInternos(this);
            AjustarRodape();
            CentralizarBotoes();
        }
        private void CentralizarBotoes()
        {
            if (FLOW_BOTOES_IMAGEM.Visible)
            {
                int totalW = 0;
                foreach (Control c in FLOW_BOTOES_IMAGEM.Controls)
                    if (c.Visible) totalW += c.Width + c.Margin.Left + c.Margin.Right;
                int pad = (FLOW_BOTOES_IMAGEM.ClientSize.Width - totalW) / 2;
                FLOW_BOTOES_IMAGEM.Padding = new Padding(Math.Max(0, pad), 10, 0, 10);
            }

            if (FLOW_BOTOES_DADOS.Visible)
            {
                int totalW = 0;
                foreach (Control c in FLOW_BOTOES_DADOS.Controls)
                    if (c.Visible) totalW += c.Width + c.Margin.Left + c.Margin.Right;
                int pad = (FLOW_BOTOES_DADOS.ClientSize.Width - totalW) / 2;
                FLOW_BOTOES_DADOS.Padding = new Padding(Math.Max(0, pad), 10, 0, 10);
            }
        }
        private void AjustarControlesInternos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label lbl && lbl.Parent is TableLayoutPanel)
                {
                    lbl.AutoSize = true;
                    lbl.Margin = new Padding(3, 3, 3, 0);
                }

                if (c is TextBox || c is ComboBox || c is MaskedTextBox || c is DateTimePicker)
                {
                    c.Margin = new Padding(3, 0, 3, 5);
                    if (c is TextBox t) t.CharacterCasing = CharacterCasing.Upper;
                }

                if (c.HasChildren) AjustarControlesInternos(c);
            }
        }
        private void AjustarRodape()
        {
            LBL_NomeProgramaRodape.AutoSize = true;
            LblLink.AutoSize = true;
            int totalWidth = LBL_NomeProgramaRodape.Width + LblLink.Width + 5;
            int startX = (PANEL_RODAPE.Width - totalWidth) / 2;
            int yPos = (PANEL_RODAPE.Height - LBL_NomeProgramaRodape.Height) / 2;
            LBL_NomeProgramaRodape.Location = new Point(startX, yPos);
            LblLink.Location = new Point(LBL_NomeProgramaRodape.Right + 5, yPos);
        }

        //CONFIGURAÇÃO - CÓDIGO DE BARRAS
        private string GerarCodigoAutomatico()
        {
            return "AUTO" + DateTime.Now.ToString("yyMMddHHmmss");
        }

        //CONFIGURAÇÃO - IMAGEM
        private byte[] ImageToByte(Image img)
        {
            if (img == null) return null;
            using (Bitmap resizer = new Bitmap(img, new Size(400, (int)(400.0 * img.Height / img.Width))))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    resizer.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }

        private Image ByteToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            return Image.FromStream(new MemoryStream(bytes));
        }

        //CONFIGURAÇÃO - GRID
        private void CarregarGrid()
        {
            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PRODUTOS ORDER BY Nome ASC", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dvProdutos = dt.DefaultView;
                    DTG_View.DataSource = dvProdutos;

                    foreach (DataGridViewColumn col in DTG_View.Columns)
                    {
                        if (col.Name == "Descricao" || col.Name == "Imagem")
                        {
                            col.Visible = false;
                        }
                        else
                        {
                            col.Visible = true;
                        }
                    }

                    if (DTG_View.Columns.Contains("ProdutoID")) DTG_View.Columns["ProdutoID"].FillWeight = 50;
                    if (DTG_View.Columns.Contains("Nome")) DTG_View.Columns["Nome"].FillWeight = 150;
                    if (DTG_View.Columns.Contains("Preco")) DTG_View.Columns["Preco"].DefaultCellStyle.Format = "C2";
                    if (DTG_View.Columns.Contains("CodigoBarras")) DTG_View.Columns["CodigoBarras"].HeaderText = "Cód. Barras";
                    if (DTG_View.Columns.Contains("DataRegistro")) DTG_View.Columns["DataRegistro"].HeaderText = "Cadastro";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //CONFIGURAÇÃO - LIMPAR CAMPOS
        private void LimparCampos()
        {
            produtoSelecionadoID = "";
            TxtCodigoBarras.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();
            TxtPreco.Text = "R$ 0,00";
            TxtEstoque.Clear();
            TxtCategoria.SelectedIndex = -1;
            DTP_DataRegistro.Value = DateTime.Now;

            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose();
                PictureBox.Image = null;
            }

            if (dvProdutos.Table != null) dvProdutos.RowFilter = "";
            TxtNome.Focus();
        }

        //CONFIGURAÇÃO - DATAVIEW E ATUALIZAÇÃO
        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            if (dvProdutos.Table == null) return;
            string filtro = TxtNome.Text.Replace("'", "''");
            dvProdutos.RowFilter = $"Nome LIKE '%{filtro}%' OR CodigoBarras LIKE '%{filtro}%'";
        }

        //CONFIGURAÇÃO  - BOTÕES
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text)) return;
            decimal.TryParse(TxtPreco.Text.Replace("R$", "").Trim(), out decimal preco);
            string codFinal = string.IsNullOrWhiteSpace(TxtCodigoBarras.Text) ? GerarCodigoAutomatico() : TxtCodigoBarras.Text.Trim();

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO PRODUTOS (CodigoBarras, Nome, Descricao, Preco, Estoque, Categoria, Imagem, DataRegistro)
                                   VALUES (@Cod, @Nome, @Desc, @Preco, @Est, @Cat, @Img, @Data)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Cod", codFinal);
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@Desc", TxtDescricao.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    int.TryParse(TxtEstoque.Text, out int est);
                    cmd.Parameters.AddWithValue("@Est", est);
                    cmd.Parameters.AddWithValue("@Cat", TxtCategoria.Text);
                    cmd.Parameters.AddWithValue("@Data", DateTime.Now);
                    byte[] img = ImageToByte(PictureBox.Image);
                    cmd.Parameters.Add("@Img", SqlDbType.VarBinary).Value = (object)img ?? DBNull.Value;
                    cmd.ExecuteNonQuery();
                }
                LimparCampos(); CarregarGrid(); MessageBox.Show("Cadastrado!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(produtoSelecionadoID)) return;
            decimal.TryParse(TxtPreco.Text.Replace("R$", "").Trim(), out decimal preco);
            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE PRODUTOS SET CodigoBarras=@Cod, Nome=@Nome, Descricao=@Desc, Preco=@Preco, Estoque=@Est, Categoria=@Cat, Imagem=@Img WHERE ProdutoID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", produtoSelecionadoID);
                    cmd.Parameters.AddWithValue("@Cod", TxtCodigoBarras.Text);
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Desc", TxtDescricao.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    int.TryParse(TxtEstoque.Text, out int est);
                    cmd.Parameters.AddWithValue("@Est", est);
                    cmd.Parameters.AddWithValue("@Cat", TxtCategoria.Text);
                    byte[] img = ImageToByte(PictureBox.Image);
                    cmd.Parameters.Add("@Img", SqlDbType.VarBinary).Value = (object)img ?? DBNull.Value;
                    cmd.ExecuteNonQuery();
                }
                LimparCampos(); CarregarGrid(); MessageBox.Show("Alterado!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(produtoSelecionadoID)) return;
            if (MessageBox.Show("Excluir?", "Confirma", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    new SqlCommand($"DELETE FROM PRODUTOS WHERE ProdutoID={produtoSelecionadoID}", conn).ExecuteNonQuery();
                }
                LimparCampos(); CarregarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DTG_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView drv = DTG_View.Rows[e.RowIndex].DataBoundItem as DataRowView;
                if (drv != null)
                {
                    PreencherCampos(drv.Row);
                }
            }
        }

        private void PreencherCampos(DataRow dr)
        {
            produtoSelecionadoID = dr["ProdutoID"].ToString();
            TxtCodigoBarras.Text = dr["CodigoBarras"].ToString();
            TxtNome.Text = dr["Nome"].ToString().ToUpper();
            TxtDescricao.Text = dr["Descricao"].ToString().ToUpper();

            decimal preco = dr["Preco"] != DBNull.Value ? Convert.ToDecimal(dr["Preco"]) : 0;
            TxtPreco.Text = preco.ToString("C2");

            TxtEstoque.Text = dr["Estoque"].ToString();
            TxtCategoria.Text = dr["Categoria"].ToString();

            if (dr.Table.Columns.Contains("DataRegistro") && dr["DataRegistro"] != DBNull.Value)
                DTP_DataRegistro.Value = Convert.ToDateTime(dr["DataRegistro"]);

            if (dr.Table.Columns.Contains("Imagem") && dr["Imagem"] != DBNull.Value)
                PictureBox.Image = ByteToImage((byte[])dr["Imagem"]);
            else
                PictureBox.Image = null;
        }
        private void DTG_View_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DTG_View.Columns[e.ColumnIndex].Name == "Estoque" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int est) && est < 5)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(DTG_View.Font, FontStyle.Bold);
                }
            }
        }

        private void LblImgInserir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Imagens|*.jpg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (PictureBox.Image != null)
                    {
                        PictureBox.Image.Dispose();
                    }
                    PictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void LblImgExcluir_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose();
                PictureBox.Image = null;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            TxtNome_TextChanged(null, null);
        }

        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }

        //CONFIGURAÇÕES - MOEDA REAL
        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {
            TxtPreco.TextChanged -= TxtPreco_TextChanged;
            try
            {
                string v = TxtPreco.Text.Replace("R$", "").Replace(",", "").Replace(".", "").TrimStart('0');
                if (string.IsNullOrEmpty(v)) TxtPreco.Text = "R$ 0,00";
                else TxtPreco.Text = string.Format("R$ {0:N2}", double.Parse(v) / 100);
                TxtPreco.SelectionStart = TxtPreco.Text.Length;
            }
            catch { }
            TxtPreco.TextChanged += TxtPreco_TextChanged;
        }

        private void TxtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        //CONFIGURAÇÕES - NÚMEROS ESTOQUE
        private void TxtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}