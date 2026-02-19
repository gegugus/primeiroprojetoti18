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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PicFunc.Image = Properties.Resources.User_ProfilePerfil1;
            PicFunc.SizeMode = PictureBoxSizeMode.Zoom;
            LayoutConfig();
            this.ActiveControl = PANEL_LOGIN;
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            LayoutConfig();
        }


        private void LayoutConfig()
        {
            PANEL_LOGIN.Left = (this.ClientSize.Width - PANEL_LOGIN.Width) / 2;
            PANEL_LOGIN.Top = (this.ClientSize.Height - PANEL_LOGIN.Height) / 2;

            int centroHorizontal = PANEL_LOGIN.Width / 2;

            PicFunc.Width = 150;
            PicFunc.Height = 150;
            PicFunc.Left = centroHorizontal - (PicFunc.Width / 2);
            PicFunc.Top = 20;

            TxtFunc_Usuario.Width = 300;
            TxtFunc_Usuario.Left = centroHorizontal - (TxtFunc_Usuario.Width / 2);
            TxtFunc_Usuario.Top = PicFunc.Bottom + 25;

            TxtFunc_Senha.Width = 300;
            TxtFunc_Senha.Left = centroHorizontal - (TxtFunc_Senha.Width / 2);
            TxtFunc_Senha.Top = TxtFunc_Usuario.Bottom;

            BTN_Entrar.Width = TxtFunc_Usuario.Width;
            BTN_Entrar.Left = centroHorizontal - (BTN_Entrar.Width / 2);
            BTN_Entrar.Top = TxtFunc_Senha.Bottom + 15;

            LK_EsqueciSenha.Left = centroHorizontal - (LK_EsqueciSenha.Width / 2);
            LK_EsqueciSenha.Top = BTN_Entrar.Bottom + 15;

            LK_CadastroFunc.Left = centroHorizontal - (LK_CadastroFunc.Width / 2);
            LK_CadastroFunc.Top = PANEL_LOGIN.Height - LK_CadastroFunc.Height - 25;
        }

        //CONFIGURAÇÃO - PICTUREBOX
        private void PicFunc_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, PicFunc.Width - 1, PicFunc.Height - 1);
            PicFunc.Region = new Region(gp);

            using (Pen p = new Pen(Color.White, 2))
            {
                e.Graphics.DrawEllipse(p, 0, 0, PicFunc.Width - 1, PicFunc.Height - 1);
            }
        }

        //CONFIGURAÇÃO - TEXTBOX 
        private void TxtFunc_Usuario_Enter(object sender, EventArgs e)
        {
            if (TxtFunc_Usuario.Text.Trim().ToLower() == "nome de usuário ou email")
            {
                TxtFunc_Usuario.Text = "";
                TxtFunc_Usuario.ForeColor = Color.Black;
            }
        }

        private void TxtFunc_Usuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFunc_Usuario.Text))
            {
                TxtFunc_Usuario.Text = "Nome de Usuário ou Email";
                TxtFunc_Usuario.ForeColor = Color.Gray;
                PicFunc.Image = Properties.Resources.User_ProfilePerfil1;
                return;
            }

            string login = TxtFunc_Usuario.Text.Trim().ToLower();

            using (SqlConnection conexao = ConnBD.GetConnection())
            {
                string sql = "SELECT FotoFunc FROM Funcionarios WHERE Usuario = @login OR Email = @login";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@login", login);

                try
                {
                    conexao.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        byte[] imagem = (byte[])result;
                        using (MemoryStream ms = new MemoryStream(imagem))
                        {
                            PicFunc.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        PicFunc.Image = Properties.Resources.User_ProfilePerfil1;
                    }
                }
                catch { }
            }
        }

        private void TxtFunc_Senha_Enter(object sender, EventArgs e)
        {
            if (TxtFunc_Senha.Text == "Senha")
            {
                TxtFunc_Senha.Text = "";
                TxtFunc_Senha.ForeColor = Color.Black;
                TxtFunc_Senha.UseSystemPasswordChar = true; //Ativa as bolinhas
            }
        }

        private void TxtFunc_Senha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFunc_Senha.Text))
            {
                TxtFunc_Senha.Text = "Senha";
                TxtFunc_Senha.ForeColor = Color.Gray;
                TxtFunc_Senha.UseSystemPasswordChar = false; //Desativa as bolinhas
            }

        }


        //CONFIGURAÇÃO - BOTÃO ENTRAR
        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            string usuarioInput = TxtFunc_Usuario.Text.Trim();
            string senhaInput = TxtFunc_Senha.Text;

            if (string.IsNullOrWhiteSpace(usuarioInput) ||
                usuarioInput.ToLower() == "nome de usuário ou email" ||
                string.IsNullOrWhiteSpace(senhaInput) ||
                senhaInput == "Senha")
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "KERN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string login = usuarioInput.ToLower();
            string senhaCripto = Seguranca.Encriptar(senhaInput);

            using (SqlConnection conexao = ConnBD.GetConnection())
            {
                string sql = "SELECT ID, NomeFunc, Senha, FotoFunc FROM Funcionarios WHERE Usuario = @login OR Email = @login";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@login", login);

                try
                {
                    conexao.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (reader["Senha"].ToString() == senhaCripto)
                        {
                            Funcionario logado = new Funcionario
                            {
                                ID = (int)reader["ID"],
                                NomeFunc = reader["NomeFunc"].ToString(),
                                FotoFunc = reader["FotoFunc"] as byte[]
                            };

                            this.Hide();
                            using (Menu telaMenu = new Menu(logado))
                            {
                                telaMenu.ShowDialog();
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta.", "KERN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TxtFunc_Senha.Clear();
                            TxtFunc_Senha.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.", "KERN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtFunc_Usuario.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar: " + ex.Message, "KERN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_Entrar_MouseEnter(object sender, EventArgs e)
        {
            BTN_Entrar.BackColor = Color.Gainsboro;
        }

        private void BTN_Entrar_MouseLeave(object sender, EventArgs e)
        {
            BTN_Entrar.BackColor = Color.White;
        }

        private void BTN_Entrar_Paint(object sender, PaintEventArgs e)
        {
            int radius = 15;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(BTN_Entrar.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(BTN_Entrar.Width - radius, BTN_Entrar.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, BTN_Entrar.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            BTN_Entrar.Region = new Region(path);
        }


        //CONFIGURAÇÃO - LINK LABEL
        private void LK_EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*
            using (EsqueciSenha telaRecuperar = new EsqueciSenha())
            {
                telaRecuperar.ShowDialog();
            }
            */
        }

        private void LK_CadastroFunc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CadastroFunc telaCadastro = new CadastroFunc())
            {
                telaCadastro.ShowDialog();
            }
        }
    }
}

