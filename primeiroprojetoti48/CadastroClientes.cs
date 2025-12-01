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
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();

            //Link Rodapé
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;

        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            TxtNome.Focus();
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void LimparCampos()
        {
            TxtID.Clear();
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
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("Informe o nome!");
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtCPF.Text))
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            int novoClienteID = 0;

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sqlCliente = @"
                INSERT INTO CLIENTES (Nome, CPF, DataNasct, DataRegistro)
                VALUES (@Nome, @CPF, @DataNascimento, @DataRegistro);
                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sqlCliente, conn);

                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", DTP_DataNascimento.Value);
                    cmd.Parameters.AddWithValue("@DataRegistro", DTP_DataRegistro.Value);

                    novoClienteID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO CONTATOS (ClienteID, Telefone, Email)
                VALUES (@ClienteID, @Telefone, @Email)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ClienteID", novoClienteID);
                    cmd.Parameters.AddWithValue("@Telefone", TxtTelefone.Text);
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.ToLower());

                    cmd.ExecuteNonQuery();
                }

                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO ENDERECO 
                (ClienteID, Logradouro, Numero, Bairro, Cidade, Estado, Cep)
                VALUES (@ClienteID, @Logradouro, @Numero, @Bairro, @Cidade, @Estado, @Cep)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ClienteID", novoClienteID);
                    cmd.Parameters.AddWithValue("@Logradouro", TxtEndereco.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Numero", TxtNumero.Text);
                    cmd.Parameters.AddWithValue("@Bairro", TxtBairro.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Cidade", TxtCidade.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Estado", TxtEstado.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Cep", TxtCEP.Text);

                    cmd.ExecuteNonQuery();
                }

                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                INSERT INTO OBSERVACOES (ClienteID, Situacao, Observacao)
                VALUES (@ClienteID, @Situacao, @Observacao)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ClienteID", novoClienteID);
                    cmd.Parameters.AddWithValue("@Situacao", TxtSituacao.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Observacao", TxtObservacao.Text.ToUpper());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro inserido com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {
            TxtID.Clear();
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
            TxtSituacao.SelectedIndex = 1;
            TxtNome.Focus();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Selecione um registro para alterar!");
                return;
            }

            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sqlCliente = @"UPDATE CLIENTES 
            SET Nome=@Nome, CPF=@CPF, DataNasct=@DataNascimento, DataRegistro=@DataRegistro
            WHERE ClienteID=@ID";

                SqlCommand cmd = new SqlCommand(sqlCliente, conn);

                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", DTP_DataNascimento.Value);
                cmd.Parameters.AddWithValue("@DataRegistro", DTP_DataRegistro.Value);
                cmd.Parameters.AddWithValue("@ID", TxtID.Text);

                cmd.ExecuteNonQuery();
            }

            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sqlContato = @"UPDATE CONTATOS 
            SET Telefone=@Telefone, Email=@Email
            WHERE ClienteID=@ID";

                SqlCommand cmd = new SqlCommand(sqlContato, conn);
                cmd.Parameters.AddWithValue("@Telefone", TxtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.ToLower());
                cmd.Parameters.AddWithValue("@ID", TxtID.Text);

                cmd.ExecuteNonQuery();
            }

            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sqlEndereco = @"UPDATE ENDERECO 
            SET Logradouro=@Logradouro, Numero=@Numero, Bairro=@Bairro, Cidade=@Cidade, Estado=@Estado, Cep=@Cep
            WHERE ClienteID=@ID";

                SqlCommand cmd = new SqlCommand(sqlEndereco, conn);
                cmd.Parameters.AddWithValue("@Logradouro", TxtEndereco.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Numero", TxtNumero.Text);
                cmd.Parameters.AddWithValue("@Bairro", TxtBairro.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Cidade", TxtCidade.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Estado", TxtEstado.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Cep", TxtCEP.Text);
                cmd.Parameters.AddWithValue("@ID", TxtID.Text);

                cmd.ExecuteNonQuery();
            }

            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sqlObs = @"UPDATE OBSERVACOES 
            SET Situacao=@Situacao, Observacao=@Observacao
            WHERE ClienteID=@ID";

                SqlCommand cmd = new SqlCommand(sqlObs, conn);
                cmd.Parameters.AddWithValue("@Situacao", TxtSituacao.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Observacao", TxtObservacao.Text.ToUpper());
                cmd.Parameters.AddWithValue("@ID", TxtID.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro alterado com sucesso!");
            LimparCampos();
        }


        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = TxtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(pesquisa))
            {
                MessageBox.Show("Digite um nome para pesquisar!");
                return;
            }

            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sql = @"
            SELECT 
                C.ClienteID, C.Nome, C.CPF, C.DataNasct, C.DataRegistro, 
                T.Telefone, T.Email, 
                E.Logradouro, E.Numero, E.Bairro, E.Cidade, E.Estado, E.Cep,
                O.Situacao, O.Observacao
            FROM CLIENTES C
            LEFT JOIN CONTATOS T ON C.ClienteID = T.ClienteID
            LEFT JOIN ENDERECO E ON C.ClienteID = E.ClienteID
            LEFT JOIN OBSERVACOES O ON C.ClienteID = O.ClienteID
            WHERE C.Nome LIKE @Nome
             ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", "%" + pesquisa + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DTG_View.DataSource = dt;

                    foreach (DataGridViewColumn col in DTG_View.Columns)
                    {
                        col.Visible = (col.Name == "ClienteID" || col.Name == "Nome" || col.Name == "CPF");
                    }

                    DataRow dr = dt.Rows[0];

                    TxtID.Text = dr["ClienteID"].ToString();
                    TxtNome.Text = dr["Nome"].ToString();
                    TxtCPF.Text = dr["CPF"].ToString();
                    DTP_DataNascimento.Value = Convert.ToDateTime(dr["DataNasct"]);
                    DTP_DataRegistro.Value = Convert.ToDateTime(dr["DataRegistro"]);

                    TxtTelefone.Text = dr["Telefone"].ToString();
                    TxtEmail.Text = dr["Email"].ToString();

                    TxtEndereco.Text = dr["Logradouro"].ToString();
                    TxtNumero.Text = dr["Numero"].ToString();
                    TxtBairro.Text = dr["Bairro"].ToString();
                    TxtCidade.Text = dr["Cidade"].ToString();
                    TxtEstado.Text = dr["Estado"].ToString();
                    TxtCEP.Text = dr["Cep"].ToString();

                    TxtSituacao.Text = dr["Situacao"].ToString();
                    TxtObservacao.Text = dr["Observacao"].ToString();
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado!");
                    DTG_View.DataSource = null;
                }
            }
        }

        private void DTG_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTG_View.Rows[e.RowIndex];

                // Preencher os campos do formulário
                TxtID.Text = row.Cells["ClienteID"].Value.ToString();
                TxtNome.Text = row.Cells["Nome"].Value.ToString();
                TxtCPF.Text = row.Cells["CPF"].Value.ToString();

                // Recuperar todas as informações do DataTable
                DataTable dt = DTG_View.DataSource as DataTable;
                if (dt != null)
                {
                    DataRow dr = dt.Rows[e.RowIndex];

                    DTP_DataNascimento.Value = Convert.ToDateTime(dr["DataNasct"]);
                    DTP_DataRegistro.Value = Convert.ToDateTime(dr["DataRegistro"]);

                    TxtTelefone.Text = dr["Telefone"].ToString();
                    TxtEmail.Text = dr["Email"].ToString();

                    TxtEndereco.Text = dr["Logradouro"].ToString();
                    TxtNumero.Text = dr["Numero"].ToString();
                    TxtBairro.Text = dr["Bairro"].ToString();
                    TxtCidade.Text = dr["Cidade"].ToString();
                    TxtEstado.Text = dr["Estado"].ToString();
                    TxtCEP.Text = dr["Cep"].ToString();

                    TxtObservacao.Text = dr["Observacao"].ToString();
                    string situacao = dr["Situacao"].ToString();
                    if (TxtSituacao.Items.Contains(situacao))
                    {
                        TxtSituacao.SelectedItem = situacao;
                    }
                    else
                    {
                        TxtSituacao.Text = situacao;
                    }
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir!");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja excluir este registro?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.No)
            {
                return; 
            }

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sqlObs = "DELETE FROM OBSERVACOES WHERE ClienteID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sqlObs, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", TxtID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlEndereco = "DELETE FROM ENDERECO WHERE ClienteID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sqlEndereco, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", TxtID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlContatos = "DELETE FROM CONTATOS WHERE ClienteID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sqlContatos, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", TxtID.Text);
                        cmd.ExecuteNonQuery();
                    }

                    string sqlCliente = "DELETE FROM CLIENTES WHERE ClienteID=@ID";
                    using (SqlCommand cmd = new SqlCommand(sqlCliente, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", TxtID.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro excluído com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

    }
}

