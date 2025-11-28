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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();

            //Link Rodapé
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;

            //Evento do DataGrid
            DataGridVisu.CellClick += DataGrid_Click;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
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
            TxtIdade.Clear();
            TxtEmail.Clear();
            TxtTelefone.Clear();
            DtpData.Value = DateTime.Now;
            TxtNome.Focus();
        }

        private void AtualizarGrid()
        {
            using (var conn = ConnBD.GetConnection())
            {
                string sql = "SELECT* FROM Contatos";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridVisu.DataSource = dt; 
                DataGridVisu.ClearSelection();
            }
        }

        private void DataGrid_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex >= 0)
                {
                    TxtID.Text = DataGridVisu.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                    TxtNome.Text = DataGridVisu.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    TxtIdade.Text = DataGridVisu.Rows[e.RowIndex].Cells["Idade"].Value.ToString();
                    TxtTelefone.Text = DataGridVisu.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                    TxtEmail.Text = DataGridVisu.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                    DtpData.Value = Convert.ToDateTime(DataGridVisu.Rows[e.RowIndex].Cells["DataRegistro"].Value);
                }
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Informe o nome!");
                return;
            }

            if (!Regex.IsMatch(TxtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail inválido!");
                return;
            }

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    string sql = @"INSERT INTO Contatos 
                           (Nome, Idade, Telefone, Email, DataRegistro)
                           VALUES (@Nome, @Idade, @Telefone, @Email, @DataRegistro)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Idade", TxtIdade.Text.ToString());
                    cmd.Parameters.AddWithValue("@Telefone", TxtTelefone.Text);
                    cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.ToLower());
                    cmd.Parameters.AddWithValue("@DataRegistro", DtpData.Value);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Registro inserido!");
                AtualizarGrid();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            // Limpar campos
            LimparCampos();
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
                string sql = @"UPDATE Contatos 
                       SET Nome=@Nome, Idade=@Idade, Telefone=@Telefone, Email=@Email, DataRegistro=@DataRegistro
                       WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", TxtID.Text);
                cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Idade", TxtIdade.Text.ToString());
                cmd.Parameters.AddWithValue("@Telefone", TxtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.ToLower());
                cmd.Parameters.AddWithValue("@DataRegistro", DtpData.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro alterado!");
            AtualizarGrid(); ;
            LimparCampos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("Selecione um registro para excluir!");
                return;
            }

            using (var conn = ConnBD.GetConnection())
            {
                string sql = "DELETE FROM Contatos WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", TxtID.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro excluído!");
            AtualizarGrid();
            LimparCampos();
        }


        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {
            using (var conn = ConnBD.GetConnection())
            {
                string sql = "SELECT* FROM Contatos";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridVisu.DataSource = dt;
            }
            LimparCampos();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = TxtNome.Text.Trim();

            if (string.IsNullOrEmpty(pesquisa))
            {
                AtualizarGrid();
                return;
            }

            using (var conn = ConnBD.GetConnection())
            {
                string sql = "SELECT * FROM Contatos WHERE Nome LIKE @Nome";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + pesquisa + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridVisu.DataSource = dt;
            }
        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }
    }
}
