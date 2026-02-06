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
            if (bytes == null || bytes.Length == 0) return null;
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
                string sql = @"SELECT ProdutoID, Nome, Descricao, Preco, Estoque, Categoria, Imagem, DataRegistro
                               FROM PRODUTOS
                               ORDER BY ProdutoID DESC";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DTG_View.DataSource = dt;

                if (DTG_View.Columns.Contains("Imagem"))
                    DTG_View.Columns["Imagem"].Visible = false;
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

        private void DTG_View_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DTG_View.Rows[e.RowIndex];

                TxtID.Text = row.Cells["ProdutoID"].Value.ToString();
                TxtNome.Text = row.Cells["Nome"].Value.ToString();
                TxtDescricao.Text = row.Cells["Descricao"].Value.ToString();
                TxtPreco.Text = row.Cells["Preco"].Value.ToString();
                TxtEstoque.Text = row.Cells["Estoque"].Value.ToString();
                TxtCategoria.Text = row.Cells["Categoria"].Value.ToString();
                DTP_DataRegistro.Value = Convert.ToDateTime(row.Cells["DataRegistro"].Value);

                if (row.Cells["Imagem"].Value != DBNull.Value && row.Cells["Imagem"].Value != null)
                {
                    byte[] imgData = (byte[])row.Cells["Imagem"].Value;
                    PictureBox.Image = ByteToImage(imgData);
                    PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    PictureBox.Image = null;
                }
            }
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
            if (string.IsNullOrWhiteSpace(TxtNome.Text)) return;

            if (!decimal.TryParse(TxtPreco.Text, out decimal preco) || !int.TryParse(TxtEstoque.Text, out int estoque))
            {
                MessageBox.Show("Verifique preço e estoque.");
                return;
            }

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO PRODUTOS (Nome, Descricao, Preco, Estoque, Categoria, Imagem, DataRegistro)
                                   VALUES (@Nome, @Descricao, @Preco, @Estoque, @Categoria, @Imagem, @DataRegistro)";

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
                MessageBox.Show("Sucesso!");
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text)) return;

            decimal.TryParse(TxtPreco.Text, out decimal preco);
            int.TryParse(TxtEstoque.Text, out int estoque);

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE PRODUTOS SET Nome=@Nome, Descricao=@Descricao, Preco=@Preco, 
                                   Estoque=@Estoque, Categoria=@Categoria, Imagem=@Imagem, DataRegistro=@DataRegistro
                                   WHERE ProdutoID=@ID";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", int.Parse(TxtID.Text));
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
                MessageBox.Show("Alterado!");
                CarregarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtID.Text)) return;
            if (MessageBox.Show("Excluir?", "Confirma", MessageBoxButtons.YesNo) == DialogResult.No) return;

            try
            {
                using (var conn = ConnBD.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM PRODUTOS WHERE ProdutoID=@ID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", TxtID.Text);
                    cmd.ExecuteNonQuery();
                }
                LimparCampos();
                CarregarGrid();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            using (var conn = ConnBD.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM PRODUTOS WHERE Nome LIKE @Nome";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", "%" + TxtNome.Text + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DTG_View.DataSource = dt;
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
