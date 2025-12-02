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
    public partial class Produtos : Form
    {
        public Produtos()
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

        private byte[] ImageToByte(Image img)
        {
            if (img == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteToImage(byte[] bytes)
        {
            if (bytes == null) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void CarregarGrid()
        {
            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT ProdutoID, Nome, Descricao, Preco, Estoque, Categoria, DataRegistro
                FROM PRODUTOS
                ORDER BY ProdutoID DESC
                ";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DTG_View.DataSource = dt;
            }
        }

        private void LimparCampos()
        {
            TxtID.Clear();
            TxtNome.Clear();
            TxtDescricao.Clear();
            TxtPreco.Clear();
            TxtEstoque.Clear();
            TxtCategoria.SelectedIndex = -1;
            DTP_DataRegistro.Value = DateTime.Now;

            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose();
                PictureBox.Image = null;
            }

            TxtNome.Focus();
        }

        private void LblImgInserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (PictureBox.Image != null)
                {
                    PictureBox.Image.Dispose();
                    PictureBox.Image = null;
                }

                using (var temp = new Bitmap(ofd.FileName))
                {
                    PictureBox.Image = new Bitmap(temp);
                }
            }
        }

        private void LblImgAlterar_Click(object sender, EventArgs e)
        {
            LblImgInserir_Click(sender, e);
        }

        private void LblImgExcluir_Click(object sender, EventArgs e)
        {
            if (PictureBox.Image != null)
            {
                PictureBox.Image.Dispose();
                PictureBox.Image = null;
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                MessageBox.Show("Informe o nome do produto!");
                return;
            }

            if (!decimal.TryParse(TxtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido!");
                TxtPreco.Focus();
                return;
            }

            if (!int.TryParse(TxtEstoque.Text, out int estoque))
            {
                MessageBox.Show("Estoque inválido!");
                TxtEstoque.Focus();
                return;
            }

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO PRODUTOS
                           (Nome, Descricao, Preco, Estoque, Categoria, Imagem, DataRegistro)
                           VALUES
                           (@Nome, @Descricao, @Preco, @Estoque, @Categoria, @Imagem, @DataRegistro)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Estoque", estoque);
                    cmd.Parameters.AddWithValue("@Categoria", TxtCategoria.Text);
                    cmd.Parameters.AddWithValue("@DataRegistro", DTP_DataRegistro.Value);

                    byte[] img = ImageToByte(PictureBox.Image);
                    cmd.Parameters.Add("@Imagem", SqlDbType.VarBinary).Value = (object)img ?? DBNull.Value;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto cadastrado com sucesso!");
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar produto: " + ex.Message);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text))
            {
                MessageBox.Show("Selecione um produto para alterar!");
                return;
            }

            if (!decimal.TryParse(TxtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido!");
                TxtPreco.Focus();
                return;
            }

            if (!int.TryParse(TxtEstoque.Text, out int estoque))
            {
                MessageBox.Show("Estoque inválido!");
                TxtEstoque.Focus();
                return;
            }

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE PRODUTOS 
                           SET Nome=@Nome,
                               Descricao=@Descricao,
                               Preco=@Preco,
                               Estoque=@Estoque,
                               Categoria=@Categoria,
                               Imagem=@Imagem,
                               DataRegistro=@DataRegistro
                           WHERE ProdutoID=@ID";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ID", int.Parse(TxtID.Text));
                    cmd.Parameters.AddWithValue("@Nome", TxtNome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Descricao", TxtDescricao.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Estoque", estoque);
                    cmd.Parameters.AddWithValue("@Categoria", TxtCategoria.Text);
                    cmd.Parameters.AddWithValue("@DataRegistro", DTP_DataRegistro.Value);

                    byte[] img = null;
                    if (PictureBox.Image != null)
                    {
                        using (var temp = new Bitmap(PictureBox.Image))
                        {
                            img = ImageToByte(temp);
                        }
                    }

                    cmd.Parameters.Add("@Imagem", SqlDbType.VarBinary).Value = (object)img ?? DBNull.Value;

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto alterado com sucesso!");
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar produto: " + ex.Message);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text))
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }

            DialogResult r = MessageBox.Show(
                "Confirma a exclusão?",
                "Excluir Produto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r == DialogResult.No) return;

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM PRODUTOS WHERE ProdutoID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(TxtID.Text));
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto excluído com sucesso!");
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
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

                string sql = @"SELECT ProdutoID, Nome, Descricao, Preco, Estoque, Categoria, Imagem, DataRegistro
                FROM PRODUTOS
                WHERE Nome LIKE @Nome
                ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", "%" + pesquisa + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DTG_View.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                    TxtID.Text = dr["ProdutoID"].ToString();
                    TxtNome.Text = dr["Nome"].ToString();
                    TxtDescricao.Text = dr["Descricao"].ToString();
                    TxtPreco.Text = dr["Preco"].ToString();
                    TxtEstoque.Text = dr["Estoque"].ToString();
                    TxtCategoria.Text = dr["Categoria"].ToString();
                    DTP_DataRegistro.Value = Convert.ToDateTime(dr["DataRegistro"]);

                    if (dr["Imagem"] != DBNull.Value)
                        PictureBox.Image = ByteToImage((byte[])dr["Imagem"]);
                    else
                        PictureBox.Image = null;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado!");
                }
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void DTG_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnMostrarDados_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
