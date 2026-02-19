namespace primeiroprojetoti48
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_NOMEPROGRAMA = new System.Windows.Forms.Label();
            this.PANEL_LOGIN = new System.Windows.Forms.Panel();
            this.LK_EsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.LK_CadastroFunc = new System.Windows.Forms.LinkLabel();
            this.BTN_Entrar = new System.Windows.Forms.Button();
            this.TxtFunc_Senha = new System.Windows.Forms.TextBox();
            this.TxtFunc_Usuario = new System.Windows.Forms.TextBox();
            this.PicFunc = new System.Windows.Forms.PictureBox();
            this.TABLENOME = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Frase = new System.Windows.Forms.Label();
            this.LBL_Nome = new System.Windows.Forms.Label();
            this.PANEL_LOGIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFunc)).BeginInit();
            this.TABLENOME.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_NOMEPROGRAMA
            // 
            this.LBL_NOMEPROGRAMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_NOMEPROGRAMA.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMEPROGRAMA.Location = new System.Drawing.Point(0, 0);
            this.LBL_NOMEPROGRAMA.Name = "LBL_NOMEPROGRAMA";
            this.LBL_NOMEPROGRAMA.Size = new System.Drawing.Size(716, 16);
            this.LBL_NOMEPROGRAMA.TabIndex = 1;
            this.LBL_NOMEPROGRAMA.Text = "KERN";
            this.LBL_NOMEPROGRAMA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_LOGIN
            // 
            this.PANEL_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PANEL_LOGIN.Controls.Add(this.LK_EsqueciSenha);
            this.PANEL_LOGIN.Controls.Add(this.LK_CadastroFunc);
            this.PANEL_LOGIN.Controls.Add(this.BTN_Entrar);
            this.PANEL_LOGIN.Controls.Add(this.TxtFunc_Senha);
            this.PANEL_LOGIN.Controls.Add(this.TxtFunc_Usuario);
            this.PANEL_LOGIN.Controls.Add(this.PicFunc);
            this.PANEL_LOGIN.Location = new System.Drawing.Point(163, 234);
            this.PANEL_LOGIN.Name = "PANEL_LOGIN";
            this.PANEL_LOGIN.Size = new System.Drawing.Size(400, 500);
            this.PANEL_LOGIN.TabIndex = 26;
            this.PANEL_LOGIN.Resize += new System.EventHandler(this.Login_Resize);
            // 
            // LK_EsqueciSenha
            // 
            this.LK_EsqueciSenha.AutoSize = true;
            this.LK_EsqueciSenha.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.LK_EsqueciSenha.ForeColor = System.Drawing.Color.DimGray;
            this.LK_EsqueciSenha.LinkColor = System.Drawing.Color.DimGray;
            this.LK_EsqueciSenha.Location = new System.Drawing.Point(127, 361);
            this.LK_EsqueciSenha.Name = "LK_EsqueciSenha";
            this.LK_EsqueciSenha.Size = new System.Drawing.Size(127, 19);
            this.LK_EsqueciSenha.TabIndex = 5;
            this.LK_EsqueciSenha.TabStop = true;
            this.LK_EsqueciSenha.Text = "Esqueci a senha";
            this.LK_EsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_EsqueciSenha_LinkClicked);
            // 
            // LK_CadastroFunc
            // 
            this.LK_CadastroFunc.AutoSize = true;
            this.LK_CadastroFunc.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.LK_CadastroFunc.ForeColor = System.Drawing.Color.DimGray;
            this.LK_CadastroFunc.LinkColor = System.Drawing.Color.DimGray;
            this.LK_CadastroFunc.Location = new System.Drawing.Point(127, 472);
            this.LK_CadastroFunc.Name = "LK_CadastroFunc";
            this.LK_CadastroFunc.Size = new System.Drawing.Size(142, 19);
            this.LK_CadastroFunc.TabIndex = 6;
            this.LK_CadastroFunc.TabStop = true;
            this.LK_CadastroFunc.Text = "Cadastrar Usuário";
            this.LK_CadastroFunc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_CadastroFunc_LinkClicked);
            // 
            // BTN_Entrar
            // 
            this.BTN_Entrar.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BTN_Entrar.ForeColor = System.Drawing.Color.DimGray;
            this.BTN_Entrar.Location = new System.Drawing.Point(57, 317);
            this.BTN_Entrar.Name = "BTN_Entrar";
            this.BTN_Entrar.Size = new System.Drawing.Size(299, 27);
            this.BTN_Entrar.TabIndex = 4;
            this.BTN_Entrar.Text = "Entrar";
            this.BTN_Entrar.UseVisualStyleBackColor = true;
            this.BTN_Entrar.Click += new System.EventHandler(this.BTN_Entrar_Click);
            this.BTN_Entrar.Paint += new System.Windows.Forms.PaintEventHandler(this.BTN_Entrar_Paint);
            this.BTN_Entrar.MouseEnter += new System.EventHandler(this.BTN_Entrar_MouseEnter);
            this.BTN_Entrar.MouseLeave += new System.EventHandler(this.BTN_Entrar_MouseLeave);
            // 
            // TxtFunc_Senha
            // 
            this.TxtFunc_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtFunc_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFunc_Senha.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFunc_Senha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtFunc_Senha.Location = new System.Drawing.Point(57, 280);
            this.TxtFunc_Senha.Name = "TxtFunc_Senha";
            this.TxtFunc_Senha.Size = new System.Drawing.Size(299, 27);
            this.TxtFunc_Senha.TabIndex = 3;
            this.TxtFunc_Senha.Text = "Senha";
            this.TxtFunc_Senha.Enter += new System.EventHandler(this.TxtFunc_Senha_Enter);
            this.TxtFunc_Senha.Leave += new System.EventHandler(this.TxtFunc_Senha_Leave);
            // 
            // TxtFunc_Usuario
            // 
            this.TxtFunc_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TxtFunc_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFunc_Usuario.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFunc_Usuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TxtFunc_Usuario.Location = new System.Drawing.Point(57, 254);
            this.TxtFunc_Usuario.Name = "TxtFunc_Usuario";
            this.TxtFunc_Usuario.Size = new System.Drawing.Size(299, 27);
            this.TxtFunc_Usuario.TabIndex = 2;
            this.TxtFunc_Usuario.Text = "Nome de Usuário ou Email";
            this.TxtFunc_Usuario.Enter += new System.EventHandler(this.TxtFunc_Usuario_Enter);
            this.TxtFunc_Usuario.Leave += new System.EventHandler(this.TxtFunc_Usuario_Leave);
            // 
            // PicFunc
            // 
            this.PicFunc.Location = new System.Drawing.Point(131, 68);
            this.PicFunc.Name = "PicFunc";
            this.PicFunc.Size = new System.Drawing.Size(150, 150);
            this.PicFunc.TabIndex = 0;
            this.PicFunc.TabStop = false;
            this.PicFunc.Paint += new System.Windows.Forms.PaintEventHandler(this.PicFunc_Paint);
            // 
            // TABLENOME
            // 
            this.TABLENOME.ColumnCount = 1;
            this.TABLENOME.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TABLENOME.Controls.Add(this.LBL_Frase, 0, 1);
            this.TABLENOME.Controls.Add(this.LBL_Nome, 0, 0);
            this.TABLENOME.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TABLENOME.Location = new System.Drawing.Point(0, 784);
            this.TABLENOME.Name = "TABLENOME";
            this.TABLENOME.Padding = new System.Windows.Forms.Padding(20);
            this.TABLENOME.RowCount = 2;
            this.TABLENOME.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.92307F));
            this.TABLENOME.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07693F));
            this.TABLENOME.Size = new System.Drawing.Size(716, 195);
            this.TABLENOME.TabIndex = 27;
            // 
            // LBL_Frase
            // 
            this.LBL_Frase.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Frase.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Frase.Location = new System.Drawing.Point(23, 139);
            this.LBL_Frase.Name = "LBL_Frase";
            this.LBL_Frase.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LBL_Frase.Size = new System.Drawing.Size(670, 35);
            this.LBL_Frase.TabIndex = 1;
            this.LBL_Frase.Text = "GESTÃO INTELIGENTE";
            // 
            // LBL_Nome
            // 
            this.LBL_Nome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBL_Nome.Font = new System.Drawing.Font("Bahnschrift", 80F, System.Drawing.FontStyle.Bold);
            this.LBL_Nome.Location = new System.Drawing.Point(23, 26);
            this.LBL_Nome.Name = "LBL_Nome";
            this.LBL_Nome.Size = new System.Drawing.Size(670, 113);
            this.LBL_Nome.TabIndex = 0;
            this.LBL_Nome.Text = "KERN.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(716, 979);
            this.Controls.Add(this.TABLENOME);
            this.Controls.Add(this.PANEL_LOGIN);
            this.Controls.Add(this.LBL_NOMEPROGRAMA);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KERN - LOGIN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.Resize += new System.EventHandler(this.Login_Resize);
            this.PANEL_LOGIN.ResumeLayout(false);
            this.PANEL_LOGIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFunc)).EndInit();
            this.TABLENOME.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_NOMEPROGRAMA;
        private System.Windows.Forms.Panel PANEL_LOGIN;
        private System.Windows.Forms.PictureBox PicFunc;
        private System.Windows.Forms.TextBox TxtFunc_Usuario;
        private System.Windows.Forms.TextBox TxtFunc_Senha;
        private System.Windows.Forms.Button BTN_Entrar;
        private System.Windows.Forms.LinkLabel LK_CadastroFunc;
        private System.Windows.Forms.LinkLabel LK_EsqueciSenha;
        private System.Windows.Forms.TableLayoutPanel TABLENOME;
        private System.Windows.Forms.Label LBL_Frase;
        private System.Windows.Forms.Label LBL_Nome;
    }
}