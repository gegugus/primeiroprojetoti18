using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class CadClientes : Form
    {
        private string clienteSelecionadoID = "";
        public CadClientes()
        {
            InitializeComponent();
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;
            this.Resize += (s, e) => AjustarRodape();
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = e.Link.LinkData.ToString(), UseShellExecute = true });
        }

        private void CadClientes_Load(object sender, EventArgs e)
        {
            ConfigurarLayout();
            CarregarGrid();
            this.Focus();
        }
        private void ConfigurarLayout()
        {
            this.AutoScroll = true;

            PANEL_RODAPE.Dock = DockStyle.Bottom;
            PANEL_DADOSPESSOAIS.Dock = DockStyle.Top;
            PANEL_CONTATO.Dock = DockStyle.Top;
            PANEL_ENDERECO.Dock = DockStyle.Top;
            PANEL_STATUS.Dock = DockStyle.Top;
            FLOW_BOTOES.Dock = DockStyle.Top;

            PANEL_LISTA.Dock = DockStyle.Fill;
            PANEL_LISTA.BringToFront();

            FLOW_BOTOES.AutoSize = true;
            FLOW_BOTOES.WrapContents = true;
            FLOW_BOTOES.FlowDirection = FlowDirection.LeftToRight;

            FLOW_BOTOES.Padding = new Padding(0, 10, 0, 10);

            foreach (Control c in FLOW_BOTOES.Controls)
            {
                if (c is Button)
                {
                    c.Margin = new Padding(10);
                    c.Anchor = AnchorStyles.None;
                }
            }

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

            foreach (Control p in this.Controls)
            {
                if (p is Panel || p is GroupBox || p is FlowLayoutPanel)
                {
                    foreach (Control c in p.Controls)
                    {
                        if (c is TextBox t)
                        {
                            t.CharacterCasing = CharacterCasing.Upper;
                        }
                    }
                }
            }

            AjustarControlesInternos(this);
            AjustarRodape();
            CentralizarBotoes();
        }

        private void CentralizarBotoes()
        {
            int totalButtonsWidth = 0;
            foreach (Control c in FLOW_BOTOES.Controls)
            {
                if (c.Visible)
                    totalButtonsWidth += c.Width + c.Margin.Left + c.Margin.Right;
            }

            int leftPadding = (FLOW_BOTOES.ClientSize.Width - totalButtonsWidth) / 2;
            if (leftPadding > 0)
            {
                FLOW_BOTOES.Padding = new Padding(leftPadding, 10, 0, 10);
            }
        }
        private void AjustarControlesInternos(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox || c is DateTimePicker)
                {
                    c.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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

        private void CarregarGrid()
        {
            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT C.ClienteID, C.Nome, C.CPF, C.DataNasct, C.DataRegistro, 
                           T.Telefone, T.Email, E.Logradouro, E.Numero, E.Bairro, 
                           E.Cidade, E.Estado, E.Cep, O.Situacao, O.Observacao
                           FROM CLIENTES C
                           LEFT JOIN CONTATOS T ON C.ClienteID = T.ClienteID
                           LEFT JOIN ENDERECO E ON C.ClienteID = E.ClienteID
                           LEFT JOIN OBSERVACOES O ON C.ClienteID = O.ClienteID
                           ORDER BY C.Nome ASC";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DTG_View.DataSource = dt;

                    string[] colunasVisiveis = { "ClienteID", "Nome", "CPF", "Telefone", "DataNasct", "DataRegistro", "Situacao" };

                    foreach (DataGridViewColumn col in DTG_View.Columns)
                    {
                        col.Visible = colunasVisiveis.Contains(col.Name);
                    }

                    if (DTG_View.Columns.Contains("ClienteID")) DTG_View.Columns["ClienteID"].FillWeight = 40;
                    if (DTG_View.Columns.Contains("Nome")) DTG_View.Columns["Nome"].FillWeight = 150;
                    if (DTG_View.Columns.Contains("DataNasct")) DTG_View.Columns["DataNasct"].HeaderText = "Nascimento";
                    if (DTG_View.Columns.Contains("DataRegistro")) DTG_View.Columns["DataRegistro"].HeaderText = "Cadastro";
                }
            }
            catch (Exception ex) { MessageBox.Show("Erro ao carregar lista: " + ex.Message); }
        }
        private void LimparCampos()
        {
            clienteSelecionadoID = "";
            TxtNome.Clear();
            TxtCPF.Clear();
            DTP_DataNascimento.Value = DateTime.Now;
            DTP_DataRegistro.Value = DateTime.Now;
            TxtTelefone.Clear();
            TxtEmail.Clear();
            TxtEndereco.Clear();
            TxtNumero.Clear();
            TxtBairro.Clear();
            TxtCidade.Clear();
            TxtEstado.Clear();
            TxtCEP.Clear();
            TxtObservacao.Clear();
            TxtSituacao.SelectedIndex = -1;
            TxtNome.Focus();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text)) return;

            string cpfLimpo = Regex.Replace(TxtCPF.Text, @"[^\d]", "");
            string telLimpo = Regex.Replace(TxtTelefone.Text, @"[^\d]", "");
            string cepLimpo = Regex.Replace(TxtCEP.Text, @"[^\d]", "");

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            string sqlC = @"INSERT INTO CLIENTES (Nome, CPF, DataNasct, DataRegistro) 
                                   VALUES (@Nome, @CPF, @DN, @DR); SELECT SCOPE_IDENTITY();";
                            SqlCommand cmdC = new SqlCommand(sqlC, conn, trans);
                            cmdC.Parameters.AddWithValue("@Nome", TxtNome.Text.Trim().ToUpper());
                            cmdC.Parameters.AddWithValue("@CPF", cpfLimpo);
                            cmdC.Parameters.AddWithValue("@DN", DTP_DataNascimento.Value);
                            cmdC.Parameters.AddWithValue("@DR", DateTime.Now);
                            int id = Convert.ToInt32(cmdC.ExecuteScalar());

                            string sqlT = "INSERT INTO CONTATOS (ClienteID, Telefone, Email) VALUES (@ID, @Tel, @Email)";
                            SqlCommand cmdT = new SqlCommand(sqlT, conn, trans);
                            cmdT.Parameters.AddWithValue("@ID", id);
                            cmdT.Parameters.AddWithValue("@Tel", telLimpo);
                            cmdT.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim().ToUpper());
                            cmdT.ExecuteNonQuery();

                            string sqlE = "INSERT INTO ENDERECO (ClienteID, Logradouro, Numero, Bairro, Cidade, Estado, Cep) VALUES (@ID, @L, @N, @B, @C, @E, @P)";
                            SqlCommand cmdE = new SqlCommand(sqlE, conn, trans);
                            cmdE.Parameters.AddWithValue("@ID", id);
                            cmdE.Parameters.AddWithValue("@L", TxtEndereco.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@N", TxtNumero.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@B", TxtBairro.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@C", TxtCidade.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@E", TxtEstado.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@P", cepLimpo);
                            cmdE.ExecuteNonQuery();

                            string sqlO = "INSERT INTO OBSERVACOES (ClienteID, Situacao, Observacao) VALUES (@ID, @S, @O)";
                            SqlCommand cmdO = new SqlCommand(sqlO, conn, trans);
                            cmdO.Parameters.AddWithValue("@ID", id);
                            cmdO.Parameters.AddWithValue("@S", TxtSituacao.Text.Trim().ToUpper());
                            cmdO.Parameters.AddWithValue("@O", TxtObservacao.Text.Trim().ToUpper());
                            cmdO.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Cadastrado!");
                            LimparCampos();
                            CarregarGrid();
                        }
                        catch { trans.Rollback(); throw; }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteSelecionadoID)) return;

            string cpfLimpo = Regex.Replace(TxtCPF.Text, @"[^\d]", "");
            string telLimpo = Regex.Replace(TxtTelefone.Text, @"[^\d]", "");
            string cepLimpo = Regex.Replace(TxtCEP.Text, @"[^\d]", "");

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    using (SqlTransaction trans = conn.BeginTransaction())
                    {
                        try
                        {
                            SqlCommand cmdC = new SqlCommand("UPDATE CLIENTES SET Nome=@N, CPF=@C, DataNasct=@DN WHERE ClienteID=@ID", conn, trans);
                            cmdC.Parameters.AddWithValue("@N", TxtNome.Text.Trim().ToUpper());
                            cmdC.Parameters.AddWithValue("@C", cpfLimpo);
                            cmdC.Parameters.AddWithValue("@DN", DTP_DataNascimento.Value);
                            cmdC.Parameters.AddWithValue("@ID", clienteSelecionadoID);
                            cmdC.ExecuteNonQuery();

                            SqlCommand cmdT = new SqlCommand("UPDATE CONTATOS SET Telefone=@Tel, Email=@Em WHERE ClienteID=@ID", conn, trans);
                            cmdT.Parameters.AddWithValue("@Tel", telLimpo);
                            cmdT.Parameters.AddWithValue("@Em", TxtEmail.Text.Trim().ToUpper());
                            cmdT.Parameters.AddWithValue("@ID", clienteSelecionadoID);
                            cmdT.ExecuteNonQuery();

                            SqlCommand cmdE = new SqlCommand("UPDATE ENDERECO SET Logradouro=@L, Numero=@Num, Bairro=@B, Cidade=@C, Estado=@Es, Cep=@Cep WHERE ClienteID=@ID", conn, trans);
                            cmdE.Parameters.AddWithValue("@L", TxtEndereco.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@Num", TxtNumero.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@B", TxtBairro.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@C", TxtCidade.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@Es", TxtEstado.Text.Trim().ToUpper());
                            cmdE.Parameters.AddWithValue("@Cep", cepLimpo);
                            cmdE.Parameters.AddWithValue("@ID", clienteSelecionadoID);
                            cmdE.ExecuteNonQuery();

                            SqlCommand cmdO = new SqlCommand("UPDATE OBSERVACOES SET Situacao=@S, Observacao=@O WHERE ClienteID=@ID", conn, trans);
                            cmdO.Parameters.AddWithValue("@S", TxtSituacao.Text.Trim().ToUpper());
                            cmdO.Parameters.AddWithValue("@O", TxtObservacao.Text.Trim().ToUpper());
                            cmdO.Parameters.AddWithValue("@ID", clienteSelecionadoID);
                            cmdO.ExecuteNonQuery();

                            trans.Commit();
                            MessageBox.Show("Alterado!");
                            LimparCampos();
                            CarregarGrid();
                        }
                        catch { trans.Rollback(); throw; }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteSelecionadoID)) return;
            if (MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTES WHERE ClienteID=@ID", conn);
                    cmd.Parameters.AddWithValue("@ID", clienteSelecionadoID);
                    cmd.ExecuteNonQuery();
                }
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string filtro = Regex.Replace(TxtNome.Text, @"[^\d\w\s]", "").ToUpper();
            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT C.*, T.Telefone, T.Email, E.Logradouro, E.Numero, E.Bairro, E.Cidade, E.Estado, E.Cep, O.Situacao, O.Observacao 
                       FROM CLIENTES C 
                       LEFT JOIN CONTATOS T ON C.ClienteID = T.ClienteID 
                       LEFT JOIN ENDERECO E ON C.ClienteID = E.ClienteID 
                       LEFT JOIN OBSERVACOES O ON C.ClienteID = O.ClienteID 
                       WHERE C.Nome LIKE @N OR C.CPF LIKE @N";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@N", "%" + filtro + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DTG_View.DataSource = dt;

                if (dt.Rows.Count > 0) PreencherCampos(dt.Rows[0]);
            }
        }
        private void PreencherCampos(DataRow dr)
        {
            clienteSelecionadoID = dr["ClienteID"].ToString();
            TxtNome.Text = dr["Nome"].ToString().ToUpper();
            TxtCPF.Text = dr["CPF"].ToString();

            if (dr["DataNasct"] != DBNull.Value)
                DTP_DataNascimento.Value = Convert.ToDateTime(dr["DataNasct"]);

            if (dr.Table.Columns.Contains("DataRegistro") && dr["DataRegistro"] != DBNull.Value)
                DTP_DataRegistro.Value = Convert.ToDateTime(dr["DataRegistro"]);

            TxtTelefone.Text = dr["Telefone"].ToString();
            TxtEmail.Text = dr["Email"].ToString().ToUpper();
            TxtEndereco.Text = dr["Logradouro"].ToString().ToUpper();
            TxtNumero.Text = dr["Numero"].ToString().ToUpper();
            TxtBairro.Text = dr["Bairro"].ToString().ToUpper();
            TxtCidade.Text = dr["Cidade"].ToString().ToUpper();
            TxtEstado.Text = dr["Estado"].ToString().ToUpper();
            TxtCEP.Text = dr["Cep"].ToString();
            TxtSituacao.Text = dr["Situacao"].ToString().ToUpper();
            TxtObservacao.Text = dr["Observacao"].ToString().ToUpper();
        }

        private void DTG_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable dt = DTG_View.DataSource as DataTable;
                if (dt != null)
                {
                    PreencherCampos(dt.Rows[e.RowIndex]);
                }
            }
        }

        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarGrid();
        }
    }
}
