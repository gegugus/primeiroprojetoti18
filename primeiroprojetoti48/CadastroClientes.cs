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
            TxtSituacao.Clear();
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
            TxtSituacao.Clear();
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

                string sqlCliente = @"
                UPDATE CLIENTES 
                    SET Nome=@Nome, CPF=@CPF, DataNasct=@DataNascimento, DataRegistro=@DataRegistro)
                    WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sqlCliente, conn);

                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                cmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                cmd.Parameters.AddWithValue("@DataNascimento", DTP_DataNascimento.Value);
                cmd.Parameters.AddWithValue("@DataRegistro", DTP_DataRegistro.Value);

                cmd.ExecuteNonQuery();

            }

            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sql = @"
                INSERT INTO CONTATOS (ClienteID, Telefone, Email)
                VALUES (@ClienteID, @Telefone, @Email)";

                SqlCommand cmd = new SqlCommand(sql, conn);

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

                cmd.Parameters.AddWithValue("@Situacao", TxtSituacao.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Observacao", TxtObservacao.Text.ToUpper());

                cmd.ExecuteNonQuery();
            }
        }
    }
}

