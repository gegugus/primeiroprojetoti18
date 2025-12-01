namespace primeiroprojetoti48
{
    partial class CadastroClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblDadosPessoais = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.DTP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblContato = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblLogradouro = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblEstado = new System.Windows.Forms.Label();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.LblStatusdocadastro = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblObservacao = new System.Windows.Forms.Label();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnMostrarDados = new System.Windows.Forms.Button();
            this.LblDataCadastro = new System.Windows.Forms.Label();
            this.DTP_DataRegistro = new System.Windows.Forms.DateTimePicker();
            this.DTG_View = new System.Windows.Forms.DataGridView();
            this.TxtObservacao = new System.Windows.Forms.RichTextBox();
            this.LblCadastrados = new System.Windows.Forms.Label();
            this.TxtSituacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDadosPessoais
            // 
            this.LblDadosPessoais.AutoSize = true;
            this.LblDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.LblDadosPessoais.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold);
            this.LblDadosPessoais.ForeColor = System.Drawing.Color.Silver;
            this.LblDadosPessoais.Location = new System.Drawing.Point(22, 13);
            this.LblDadosPessoais.Name = "LblDadosPessoais";
            this.LblDadosPessoais.Size = new System.Drawing.Size(248, 24);
            this.LblDadosPessoais.TabIndex = 0;
            this.LblDadosPessoais.Text = "Dados Pessoais - Obrigatórios";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNome.Location = new System.Drawing.Point(22, 43);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(198, 29);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome Completo - ID:";
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtNome.Location = new System.Drawing.Point(26, 75);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(390, 26);
            this.TxtNome.TabIndex = 0;
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCPF.Location = new System.Drawing.Point(440, 43);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(50, 29);
            this.LblCPF.TabIndex = 0;
            this.LblCPF.Text = "CPF";
            // 
            // TxtCPF
            // 
            this.TxtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCPF.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtCPF.Location = new System.Drawing.Point(445, 75);
            this.TxtCPF.Mask = "000.000.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(155, 26);
            this.TxtCPF.TabIndex = 1;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDataNascimento.Location = new System.Drawing.Point(631, 43);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(169, 29);
            this.LblDataNascimento.TabIndex = 0;
            this.LblDataNascimento.Text = "Data Nascimento";
            // 
            // DTP_DataNascimento
            // 
            this.DTP_DataNascimento.CalendarFont = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataNascimento.Font = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DataNascimento.Location = new System.Drawing.Point(636, 75);
            this.DTP_DataNascimento.Name = "DTP_DataNascimento";
            this.DTP_DataNascimento.Size = new System.Drawing.Size(165, 26);
            this.DTP_DataNascimento.TabIndex = 2;
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.SystemColors.Control;
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtID.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtID.Font = new System.Drawing.Font("Rubik", 11F);
            this.TxtID.Location = new System.Drawing.Point(226, 47);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(72, 18);
            this.TxtID.TabIndex = 0;
            this.TxtID.TabStop = false;
            // 
            // LblContato
            // 
            this.LblContato.AutoSize = true;
            this.LblContato.BackColor = System.Drawing.Color.Transparent;
            this.LblContato.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold);
            this.LblContato.ForeColor = System.Drawing.Color.Silver;
            this.LblContato.Location = new System.Drawing.Point(23, 122);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(74, 24);
            this.LblContato.TabIndex = 0;
            this.LblContato.Text = "Contato";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblTelefone.Location = new System.Drawing.Point(22, 151);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(91, 29);
            this.LblTelefone.TabIndex = 0;
            this.LblTelefone.Text = "Telefone";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefone.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtTelefone.Location = new System.Drawing.Point(26, 183);
            this.TxtTelefone.Mask = "(00) 00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(194, 26);
            this.TxtTelefone.TabIndex = 3;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblEmail.Location = new System.Drawing.Point(250, 151);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(70, 29);
            this.LblEmail.TabIndex = 1;
            this.LblEmail.Text = "E-Mail";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtEmail.Location = new System.Drawing.Point(255, 183);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(545, 26);
            this.TxtEmail.TabIndex = 4;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.LblEndereco.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold);
            this.LblEndereco.ForeColor = System.Drawing.Color.Silver;
            this.LblEndereco.Location = new System.Drawing.Point(24, 236);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(86, 24);
            this.LblEndereco.TabIndex = 0;
            this.LblEndereco.Text = "Endereço";
            // 
            // LblLogradouro
            // 
            this.LblLogradouro.AutoSize = true;
            this.LblLogradouro.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblLogradouro.Location = new System.Drawing.Point(21, 266);
            this.LblLogradouro.Name = "LblLogradouro";
            this.LblLogradouro.Size = new System.Drawing.Size(120, 29);
            this.LblLogradouro.TabIndex = 0;
            this.LblLogradouro.Text = "Logradouro";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEndereco.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtEndereco.Location = new System.Drawing.Point(26, 298);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(392, 26);
            this.TxtEndereco.TabIndex = 5;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNumero.Location = new System.Drawing.Point(450, 266);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(85, 29);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Número";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumero.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtNumero.Location = new System.Drawing.Point(454, 298);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(81, 26);
            this.TxtNumero.TabIndex = 6;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblBairro.Location = new System.Drawing.Point(566, 266);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(69, 29);
            this.LblBairro.TabIndex = 0;
            this.LblBairro.Text = "Bairro";
            // 
            // TxtBairro
            // 
            this.TxtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBairro.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtBairro.Location = new System.Drawing.Point(570, 298);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(230, 26);
            this.TxtBairro.TabIndex = 7;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCidade.Location = new System.Drawing.Point(22, 338);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(77, 29);
            this.LblCidade.TabIndex = 0;
            this.LblCidade.Text = "Cidade";
            // 
            // TxtCidade
            // 
            this.TxtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCidade.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtCidade.Location = new System.Drawing.Point(26, 370);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(339, 26);
            this.TxtCidade.TabIndex = 8;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblEstado.Location = new System.Drawing.Point(399, 338);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(77, 29);
            this.LblEstado.TabIndex = 0;
            this.LblEstado.Text = "Estado";
            // 
            // TxtEstado
            // 
            this.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEstado.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtEstado.Location = new System.Drawing.Point(403, 370);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(183, 26);
            this.TxtEstado.TabIndex = 9;
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCEP.Location = new System.Drawing.Point(618, 338);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(51, 29);
            this.LblCEP.TabIndex = 0;
            this.LblCEP.Text = "CEP";
            // 
            // TxtCEP
            // 
            this.TxtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCEP.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtCEP.Location = new System.Drawing.Point(623, 370);
            this.TxtCEP.Mask = "(00000-000)";
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(177, 26);
            this.TxtCEP.TabIndex = 10;
            // 
            // LblLink
            // 
            this.LblLink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(755, 731);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 19;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            this.LblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLink_LinkClicked);
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(656, 731);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 0;
            this.Lbl_Copyright.Text = "2025 ©Gegugus ";
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(24, 731);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(133, 17);
            this.Lbl_Rodape.TabIndex = 0;
            this.Lbl_Rodape.Text = "Cadastro de Cliente v1.0";
            // 
            // LblStatusdocadastro
            // 
            this.LblStatusdocadastro.AutoSize = true;
            this.LblStatusdocadastro.BackColor = System.Drawing.Color.Transparent;
            this.LblStatusdocadastro.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold);
            this.LblStatusdocadastro.ForeColor = System.Drawing.Color.Silver;
            this.LblStatusdocadastro.Location = new System.Drawing.Point(23, 423);
            this.LblStatusdocadastro.Name = "LblStatusdocadastro";
            this.LblStatusdocadastro.Size = new System.Drawing.Size(161, 24);
            this.LblStatusdocadastro.TabIndex = 0;
            this.LblStatusdocadastro.Text = "Status do Cadastro";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblStatus.Location = new System.Drawing.Point(21, 453);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(74, 29);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = "Status";
            // 
            // LblObservacao
            // 
            this.LblObservacao.AutoSize = true;
            this.LblObservacao.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblObservacao.Location = new System.Drawing.Point(23, 526);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.Size = new System.Drawing.Size(132, 29);
            this.LblObservacao.TabIndex = 0;
            this.LblObservacao.Text = "Observações";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.AutoSize = true;
            this.BtnPesquisar.BackColor = System.Drawing.Color.LightGray;
            this.BtnPesquisar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(499, 673);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(145, 40);
            this.BtnPesquisar.TabIndex = 17;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.AutoSize = true;
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(124)))), ((int)(((byte)(121)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(655, 673);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(145, 40);
            this.BtnExcluir.TabIndex = 18;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.AutoSize = true;
            this.BtnAlterar.BackColor = System.Drawing.Color.LightGray;
            this.BtnAlterar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(341, 673);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(145, 40);
            this.BtnAlterar.TabIndex = 16;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.AutoSize = true;
            this.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            this.BtnAdicionar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(26, 673);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(145, 40);
            this.BtnAdicionar.TabIndex = 14;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnMostrarDados
            // 
            this.BtnMostrarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.BtnMostrarDados.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.BtnMostrarDados.Location = new System.Drawing.Point(184, 673);
            this.BtnMostrarDados.Name = "BtnMostrarDados";
            this.BtnMostrarDados.Size = new System.Drawing.Size(145, 40);
            this.BtnMostrarDados.TabIndex = 15;
            this.BtnMostrarDados.Text = "Limpar Tela";
            this.BtnMostrarDados.UseVisualStyleBackColor = false;
            this.BtnMostrarDados.Click += new System.EventHandler(this.BtnMostrarDados_Click);
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.AutoSize = true;
            this.LblDataCadastro.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDataCadastro.Location = new System.Drawing.Point(174, 453);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(138, 29);
            this.LblDataCadastro.TabIndex = 0;
            this.LblDataCadastro.Text = "Data Registro";
            // 
            // DTP_DataRegistro
            // 
            this.DTP_DataRegistro.CalendarFont = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataRegistro.Font = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataRegistro.Location = new System.Drawing.Point(179, 485);
            this.DTP_DataRegistro.Name = "DTP_DataRegistro";
            this.DTP_DataRegistro.Size = new System.Drawing.Size(620, 26);
            this.DTP_DataRegistro.TabIndex = 12;
            // 
            // DTG_View
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Rubik", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DTG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_View.Location = new System.Drawing.Point(425, 558);
            this.DTG_View.Name = "DTG_View";
            this.DTG_View.Size = new System.Drawing.Size(374, 96);
            this.DTG_View.TabIndex = 16;
            this.DTG_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_View_CellContentClick);
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtObservacao.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacao.Location = new System.Drawing.Point(28, 558);
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(375, 96);
            this.TxtObservacao.TabIndex = 13;
            this.TxtObservacao.Text = "";
            // 
            // LblCadastrados
            // 
            this.LblCadastrados.AutoSize = true;
            this.LblCadastrados.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCadastrados.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblCadastrados.Location = new System.Drawing.Point(420, 526);
            this.LblCadastrados.Name = "LblCadastrados";
            this.LblCadastrados.Size = new System.Drawing.Size(192, 29);
            this.LblCadastrados.TabIndex = 0;
            this.LblCadastrados.Text = "Lista - Cadastrados";
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.Font = new System.Drawing.Font("Rubik", 8.5F);
            this.TxtSituacao.FormattingEnabled = true;
            this.TxtSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "SUSPENSO",
            "BANIDO"});
            this.TxtSituacao.Location = new System.Drawing.Point(28, 485);
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Size = new System.Drawing.Size(121, 25);
            this.TxtSituacao.TabIndex = 11;
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 760);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(this.TxtObservacao);
            this.Controls.Add(this.DTG_View);
            this.Controls.Add(this.DTP_DataRegistro);
            this.Controls.Add(this.BtnMostrarDados);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.DTP_DataNascimento);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCEP);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtBairro);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.LblBairro);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.LblCEP);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblCadastrados);
            this.Controls.Add(this.LblObservacao);
            this.Controls.Add(this.LblDataCadastro);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblLogradouro);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.LblStatusdocadastro);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblContato);
            this.Controls.Add(this.LblDadosPessoais);
            this.Name = "CadastroClientes";
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDadosPessoais;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.DateTimePicker DTP_DataNascimento;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblLogradouro;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.MaskedTextBox TxtCEP;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Label Lbl_Rodape;
        private System.Windows.Forms.Label LblStatusdocadastro;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblObservacao;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnMostrarDados;
        private System.Windows.Forms.Label LblDataCadastro;
        private System.Windows.Forms.DateTimePicker DTP_DataRegistro;
        private System.Windows.Forms.DataGridView DTG_View;
        private System.Windows.Forms.RichTextBox TxtObservacao;
        private System.Windows.Forms.Label LblCadastrados;
        private System.Windows.Forms.ComboBox TxtSituacao;
    }
}