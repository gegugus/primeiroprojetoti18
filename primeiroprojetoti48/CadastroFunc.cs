using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class CadastroFunc : Form
    {
        private byte[] fotoBytes = null;
        public CadastroFunc()
        {
            InitializeComponent();
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += (s, e) => {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = e.Link.LinkData.ToString(),
                    UseShellExecute = true
                });
            };
        }

        private void CadastroFunc_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(235, 235, 235);
            PicFunc.SizeMode = PictureBoxSizeMode.Zoom;
            PicFunc.Image = Properties.Resources.User_ProfilePerfil1;

            PANEL_RODAPE.Dock = DockStyle.Bottom;
            LBL_NomeProgramaRodape.AutoSize = true;
            LblLink.AutoSize = true;

            LayoutConfig();
        }

        private void CadastroFunc_Resize(object sender, EventArgs e)
        {
            LayoutConfig();
        }

        private void LayoutConfig()
        {
            int alturaRodape = PANEL_RODAPE.Height;
            int alturaUtil = this.ClientSize.Height - alturaRodape;
            int larguraUtil = this.ClientSize.Width;

            PANEL_CADASTRO.Size = new Size(800, 500);

            PANEL_CADASTRO.Left = (larguraUtil - PANEL_CADASTRO.Width) / 2;
            PANEL_CADASTRO.Top = (alturaUtil - PANEL_CADASTRO.Height) / 2;

            if (PANEL_CADASTRO.Left < 0) PANEL_CADASTRO.Left = 0;
            if (PANEL_CADASTRO.Top < 0) PANEL_CADASTRO.Top = 0;

            int margemEsq = 40;
            int larguraInputs = 320;
            int linhaBotoesFinais = 380;

            LBL_NomeFunc.Location = new Point(margemEsq, 50);
            TxtNome.Size = new Size(larguraInputs, 30);
            TxtNome.Location = new Point(margemEsq, 75);

            LBL_Usuario.Location = new Point(margemEsq, 115);
            TxtUsuario.Size = new Size(larguraInputs, 30);
            TxtUsuario.Location = new Point(margemEsq, 140);

            LBL_Email.Location = new Point(margemEsq, 180);
            TxtEmail.Size = new Size(larguraInputs, 30);
            TxtEmail.Location = new Point(margemEsq, 205);

            LBL_Senha.Location = new Point(margemEsq, 245);
            TxtSenha.Size = new Size(larguraInputs, 30);
            TxtSenha.Location = new Point(margemEsq, 270);
            TxtSenha.UseSystemPasswordChar = true;

            BTN_Salvar.Size = new Size(155, 45);
            BTN_Salvar.Location = new Point(margemEsq, linhaBotoesFinais);

            BTN_Cancelar.Size = new Size(155, 45);
            BTN_Cancelar.Location = new Point(margemEsq + larguraInputs - BTN_Cancelar.Width, linhaBotoesFinais);

            int margemDir = PANEL_CADASTRO.Width - 280;
            PicFunc.Size = new Size(240, 240);
            PicFunc.Location = new Point(margemDir, 75);
            LBL_FotoFunc.Location = new Point(PicFunc.Left, 50);

            BTN_Carregar.Size = new Size(115, 45);
            BTN_Carregar.Location = new Point(margemDir, linhaBotoesFinais);

            BTN_Deletar.Size = new Size(115, 45);
            BTN_Deletar.Location = new Point(PicFunc.Right - BTN_Deletar.Width, linhaBotoesFinais);

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

        private void PicFunc_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, PicFunc.Width - 1, PicFunc.Height - 1);
            PicFunc.Region = new Region(gp);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Pen p = new Pen(Color.LightGray, 1))
            {
                e.Graphics.DrawEllipse(p, 0, 0, PicFunc.Width - 1, PicFunc.Height - 1);
            }
        }

        private void BTN_Carregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens (*.jpg; *.png)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (PicFunc.Image != null && PicFunc.Image != Properties.Resources.User_ProfilePerfil1)
                    {
                        PicFunc.Image.Dispose();
                    }
                    PicFunc.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            if (PicFunc.Image != null && PicFunc.Image != Properties.Resources.User_ProfilePerfil1)
            {
                PicFunc.Image.Dispose();
            }
            PicFunc.Image = Properties.Resources.User_ProfilePerfil1;
            fotoBytes = null;
            PicFunc.Invalidate();
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(TxtUsuario.Text) ||
                string.IsNullOrWhiteSpace(TxtEmail.Text) || string.IsNullOrWhiteSpace(TxtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "KERN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PicFunc.Image != null && PicFunc.Image != Properties.Resources.User_ProfilePerfil1)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(PicFunc.Image);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    fotoBytes = ms.ToArray();
                    bmp.Dispose();
                }
            }

            Funcionario novoFunc = new Funcionario
            {
                NomeFunc = TxtNome.Text.Trim().ToUpper(),
                Usuario = TxtUsuario.Text.Trim().ToLower(),
                Email = TxtEmail.Text.Trim().ToLower(),
                Senha = Seguranca.Encriptar(TxtSenha.Text),
                FotoFunc = fotoBytes
            };

            using (SqlConnection conexao = ConnBD.GetConnection())
            {
                try
                {
                    conexao.Open();
                    string sql = "INSERT INTO Funcionarios (NomeFunc, Usuario, Email, Senha, FotoFunc) VALUES (@nome, @usuario, @email, @senha, @foto)";
                    SqlCommand cmd = new SqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nome", novoFunc.NomeFunc);
                    cmd.Parameters.AddWithValue("@usuario", novoFunc.Usuario);
                    cmd.Parameters.AddWithValue("@email", novoFunc.Email);
                    cmd.Parameters.AddWithValue("@senha", novoFunc.Senha);
                    cmd.Parameters.Add("@foto", SqlDbType.VarBinary).Value = (object)novoFunc.FotoFunc ?? DBNull.Value;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "KERN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar: " + ex.Message, "KERN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
