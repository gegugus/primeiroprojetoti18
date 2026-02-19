namespace primeiroprojetoti48
{
    partial class CadClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBL_NOMEPROGRAMA = new System.Windows.Forms.Label();
            this.PANEL_DADOSPESSOAIS = new System.Windows.Forms.TableLayoutPanel();
            this.LblDadosPessoais = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            this.DTP_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.PANEL_CONTATO = new System.Windows.Forms.TableLayoutPanel();
            this.LblContato = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.TxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.PANEL_ENDERECO = new System.Windows.Forms.TableLayoutPanel();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.LblLogradouro = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.PANEL_STATUS = new System.Windows.Forms.TableLayoutPanel();
            this.LblStatusdocadastro = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TxtObservacao = new System.Windows.Forms.TextBox();
            this.LblDataCadastro = new System.Windows.Forms.Label();
            this.TxtSituacao = new System.Windows.Forms.ComboBox();
            this.DTP_DataRegistro = new System.Windows.Forms.DateTimePicker();
            this.LblObservacao = new System.Windows.Forms.Label();
            this.PANEL_LISTA = new System.Windows.Forms.TableLayoutPanel();
            this.DTG_View = new System.Windows.Forms.DataGridView();
            this.LblCadastrados = new System.Windows.Forms.Label();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.LBL_NomeProgramaRodape = new System.Windows.Forms.Label();
            this.PANEL_RODAPE = new System.Windows.Forms.Panel();
            this.FLOW_BOTOES = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnMostrarDados = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.PANEL_DADOSPESSOAIS.SuspendLayout();
            this.PANEL_CONTATO.SuspendLayout();
            this.PANEL_ENDERECO.SuspendLayout();
            this.PANEL_STATUS.SuspendLayout();
            this.PANEL_LISTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).BeginInit();
            this.PANEL_RODAPE.SuspendLayout();
            this.FLOW_BOTOES.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_NOMEPROGRAMA
            // 
            this.LBL_NOMEPROGRAMA.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_NOMEPROGRAMA.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMEPROGRAMA.Location = new System.Drawing.Point(0, 0);
            this.LBL_NOMEPROGRAMA.Name = "LBL_NOMEPROGRAMA";
            this.LBL_NOMEPROGRAMA.Size = new System.Drawing.Size(1260, 16);
            this.LBL_NOMEPROGRAMA.TabIndex = 25;
            this.LBL_NOMEPROGRAMA.Text = "KERN";
            this.LBL_NOMEPROGRAMA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PANEL_DADOSPESSOAIS
            // 
            this.PANEL_DADOSPESSOAIS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_DADOSPESSOAIS.ColumnCount = 3;
            this.PANEL_DADOSPESSOAIS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PANEL_DADOSPESSOAIS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PANEL_DADOSPESSOAIS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.LblDadosPessoais, 0, 0);
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.LblNome, 0, 1);
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.TxtNome, 0, 2);
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.TxtCPF, 1, 2);
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.LblCPF, 1, 1);
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.LblDataNascimento, 2, 1);
            this.PANEL_DADOSPESSOAIS.Controls.Add(this.DTP_DataNascimento, 2, 2);
            this.PANEL_DADOSPESSOAIS.Location = new System.Drawing.Point(12, 19);
            this.PANEL_DADOSPESSOAIS.Name = "PANEL_DADOSPESSOAIS";
            this.PANEL_DADOSPESSOAIS.Padding = new System.Windows.Forms.Padding(20);
            this.PANEL_DADOSPESSOAIS.RowCount = 3;
            this.PANEL_DADOSPESSOAIS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_DADOSPESSOAIS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_DADOSPESSOAIS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_DADOSPESSOAIS.Size = new System.Drawing.Size(1236, 122);
            this.PANEL_DADOSPESSOAIS.TabIndex = 26;
            // 
            // LblDadosPessoais
            // 
            this.LblDadosPessoais.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDadosPessoais.AutoSize = true;
            this.LblDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.LblDadosPessoais.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDadosPessoais.ForeColor = System.Drawing.Color.Silver;
            this.LblDadosPessoais.Location = new System.Drawing.Point(23, 25);
            this.LblDadosPessoais.Name = "LblDadosPessoais";
            this.LblDadosPessoais.Size = new System.Drawing.Size(229, 19);
            this.LblDadosPessoais.TabIndex = 27;
            this.LblDadosPessoais.Text = "Dados Pessoais - Obrigatórios";
            // 
            // LblNome
            // 
            this.LblNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(23, 55);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(126, 19);
            this.LblNome.TabIndex = 28;
            this.LblNome.Text = "Nome Completo";
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.White;
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(23, 83);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(392, 27);
            this.TxtNome.TabIndex = 29;
            // 
            // TxtCPF
            // 
            this.TxtCPF.BackColor = System.Drawing.Color.White;
            this.TxtCPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCPF.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtCPF.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCPF.Location = new System.Drawing.Point(740, 83);
            this.TxtCPF.Mask = "000.000.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(155, 27);
            this.TxtCPF.TabIndex = 30;
            // 
            // LblCPF
            // 
            this.LblCPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblCPF.Location = new System.Drawing.Point(740, 55);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(38, 19);
            this.LblCPF.TabIndex = 31;
            this.LblCPF.Text = "CPF";
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblDataNascimento.Location = new System.Drawing.Point(979, 55);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(133, 19);
            this.LblDataNascimento.TabIndex = 32;
            this.LblDataNascimento.Text = "Data Nascimento";
            // 
            // DTP_DataNascimento
            // 
            this.DTP_DataNascimento.CalendarFont = new System.Drawing.Font("Bahnschrift", 12F);
            this.DTP_DataNascimento.Dock = System.Windows.Forms.DockStyle.Left;
            this.DTP_DataNascimento.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DataNascimento.Location = new System.Drawing.Point(979, 83);
            this.DTP_DataNascimento.Name = "DTP_DataNascimento";
            this.DTP_DataNascimento.Size = new System.Drawing.Size(165, 27);
            this.DTP_DataNascimento.TabIndex = 33;
            // 
            // PANEL_CONTATO
            // 
            this.PANEL_CONTATO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_CONTATO.ColumnCount = 2;
            this.PANEL_CONTATO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_CONTATO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_CONTATO.Controls.Add(this.LblContato, 0, 0);
            this.PANEL_CONTATO.Controls.Add(this.LblTelefone, 0, 1);
            this.PANEL_CONTATO.Controls.Add(this.TxtTelefone, 0, 2);
            this.PANEL_CONTATO.Controls.Add(this.TxtEmail, 1, 2);
            this.PANEL_CONTATO.Controls.Add(this.LblEmail, 1, 1);
            this.PANEL_CONTATO.Location = new System.Drawing.Point(12, 141);
            this.PANEL_CONTATO.Name = "PANEL_CONTATO";
            this.PANEL_CONTATO.Padding = new System.Windows.Forms.Padding(20);
            this.PANEL_CONTATO.RowCount = 3;
            this.PANEL_CONTATO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_CONTATO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_CONTATO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_CONTATO.Size = new System.Drawing.Size(1236, 112);
            this.PANEL_CONTATO.TabIndex = 27;
            // 
            // LblContato
            // 
            this.LblContato.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblContato.AutoSize = true;
            this.LblContato.BackColor = System.Drawing.Color.Transparent;
            this.LblContato.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblContato.ForeColor = System.Drawing.Color.Silver;
            this.LblContato.Location = new System.Drawing.Point(23, 25);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(65, 19);
            this.LblContato.TabIndex = 1;
            this.LblContato.Text = "Contato";
            // 
            // LblTelefone
            // 
            this.LblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblTelefone.Location = new System.Drawing.Point(23, 55);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(71, 19);
            this.LblTelefone.TabIndex = 2;
            this.LblTelefone.Text = "Telefone";
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.BackColor = System.Drawing.Color.White;
            this.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefone.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefone.Location = new System.Drawing.Point(23, 83);
            this.TxtTelefone.Mask = "(00) 00000-0000";
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(194, 27);
            this.TxtTelefone.TabIndex = 4;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.White;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(621, 83);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(545, 27);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblEmail.Location = new System.Drawing.Point(621, 55);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(57, 19);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-Mail";
            // 
            // PANEL_ENDERECO
            // 
            this.PANEL_ENDERECO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_ENDERECO.ColumnCount = 3;
            this.PANEL_ENDERECO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.PANEL_ENDERECO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PANEL_ENDERECO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PANEL_ENDERECO.Controls.Add(this.LblEndereco, 0, 0);
            this.PANEL_ENDERECO.Controls.Add(this.LblLogradouro, 0, 1);
            this.PANEL_ENDERECO.Controls.Add(this.TxtEndereco, 0, 2);
            this.PANEL_ENDERECO.Controls.Add(this.TxtNumero, 1, 2);
            this.PANEL_ENDERECO.Controls.Add(this.LblNumero, 1, 1);
            this.PANEL_ENDERECO.Controls.Add(this.LblBairro, 2, 1);
            this.PANEL_ENDERECO.Controls.Add(this.TxtBairro, 2, 2);
            this.PANEL_ENDERECO.Controls.Add(this.LblCidade, 0, 3);
            this.PANEL_ENDERECO.Controls.Add(this.LblEstado, 1, 3);
            this.PANEL_ENDERECO.Controls.Add(this.LblCEP, 2, 3);
            this.PANEL_ENDERECO.Controls.Add(this.TxtCidade, 0, 4);
            this.PANEL_ENDERECO.Controls.Add(this.TxtEstado, 1, 4);
            this.PANEL_ENDERECO.Controls.Add(this.TxtCEP, 2, 4);
            this.PANEL_ENDERECO.Location = new System.Drawing.Point(12, 252);
            this.PANEL_ENDERECO.Name = "PANEL_ENDERECO";
            this.PANEL_ENDERECO.Padding = new System.Windows.Forms.Padding(20);
            this.PANEL_ENDERECO.RowCount = 5;
            this.PANEL_ENDERECO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_ENDERECO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_ENDERECO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_ENDERECO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_ENDERECO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PANEL_ENDERECO.Size = new System.Drawing.Size(1236, 198);
            this.PANEL_ENDERECO.TabIndex = 28;
            // 
            // LblEndereco
            // 
            this.LblEndereco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.LblEndereco.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblEndereco.ForeColor = System.Drawing.Color.Silver;
            this.LblEndereco.Location = new System.Drawing.Point(23, 25);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(79, 19);
            this.LblEndereco.TabIndex = 1;
            this.LblEndereco.Text = "Endereço";
            // 
            // LblLogradouro
            // 
            this.LblLogradouro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLogradouro.AutoSize = true;
            this.LblLogradouro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblLogradouro.Location = new System.Drawing.Point(23, 55);
            this.LblLogradouro.Name = "LblLogradouro";
            this.LblLogradouro.Size = new System.Drawing.Size(95, 19);
            this.LblLogradouro.TabIndex = 2;
            this.LblLogradouro.Text = "Logradouro";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEndereco.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndereco.Location = new System.Drawing.Point(23, 83);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(392, 27);
            this.TxtEndereco.TabIndex = 6;
            // 
            // TxtNumero
            // 
            this.TxtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNumero.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtNumero.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(740, 83);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(81, 27);
            this.TxtNumero.TabIndex = 7;
            // 
            // LblNumero
            // 
            this.LblNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblNumero.Location = new System.Drawing.Point(740, 55);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(68, 19);
            this.LblNumero.TabIndex = 8;
            this.LblNumero.Text = "Número";
            // 
            // LblBairro
            // 
            this.LblBairro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblBairro.Location = new System.Drawing.Point(979, 55);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(55, 19);
            this.LblBairro.TabIndex = 9;
            this.LblBairro.Text = "Bairro";
            // 
            // TxtBairro
            // 
            this.TxtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBairro.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtBairro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBairro.Location = new System.Drawing.Point(979, 83);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(230, 27);
            this.TxtBairro.TabIndex = 10;
            // 
            // LblCidade
            // 
            this.LblCidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblCidade.Location = new System.Drawing.Point(23, 119);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(59, 19);
            this.LblCidade.TabIndex = 11;
            this.LblCidade.Text = "Cidade";
            // 
            // LblEstado
            // 
            this.LblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblEstado.Location = new System.Drawing.Point(740, 119);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(59, 19);
            this.LblEstado.TabIndex = 12;
            this.LblEstado.Text = "Estado";
            // 
            // LblCEP
            // 
            this.LblCEP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCEP.AutoSize = true;
            this.LblCEP.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblCEP.Location = new System.Drawing.Point(979, 119);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(39, 19);
            this.LblCEP.TabIndex = 13;
            this.LblCEP.Text = "CEP";
            // 
            // TxtCidade
            // 
            this.TxtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCidade.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCidade.Location = new System.Drawing.Point(23, 147);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(339, 27);
            this.TxtCidade.TabIndex = 14;
            // 
            // TxtEstado
            // 
            this.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEstado.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtEstado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.Location = new System.Drawing.Point(740, 147);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(183, 27);
            this.TxtEstado.TabIndex = 15;
            // 
            // TxtCEP
            // 
            this.TxtCEP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCEP.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtCEP.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCEP.Location = new System.Drawing.Point(979, 147);
            this.TxtCEP.Mask = "(00000-000)";
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(177, 27);
            this.TxtCEP.TabIndex = 16;
            // 
            // PANEL_STATUS
            // 
            this.PANEL_STATUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_STATUS.ColumnCount = 3;
            this.PANEL_STATUS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PANEL_STATUS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PANEL_STATUS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PANEL_STATUS.Controls.Add(this.LblStatusdocadastro, 0, 0);
            this.PANEL_STATUS.Controls.Add(this.LblStatus, 0, 1);
            this.PANEL_STATUS.Controls.Add(this.TxtObservacao, 2, 2);
            this.PANEL_STATUS.Controls.Add(this.LblDataCadastro, 1, 1);
            this.PANEL_STATUS.Controls.Add(this.TxtSituacao, 0, 2);
            this.PANEL_STATUS.Controls.Add(this.DTP_DataRegistro, 1, 2);
            this.PANEL_STATUS.Controls.Add(this.LblObservacao, 2, 1);
            this.PANEL_STATUS.Location = new System.Drawing.Point(12, 450);
            this.PANEL_STATUS.Name = "PANEL_STATUS";
            this.PANEL_STATUS.Padding = new System.Windows.Forms.Padding(20);
            this.PANEL_STATUS.RowCount = 3;
            this.PANEL_STATUS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_STATUS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_STATUS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_STATUS.Size = new System.Drawing.Size(1236, 116);
            this.PANEL_STATUS.TabIndex = 29;
            // 
            // LblStatusdocadastro
            // 
            this.LblStatusdocadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblStatusdocadastro.AutoSize = true;
            this.LblStatusdocadastro.BackColor = System.Drawing.Color.Transparent;
            this.LblStatusdocadastro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblStatusdocadastro.ForeColor = System.Drawing.Color.Silver;
            this.LblStatusdocadastro.Location = new System.Drawing.Point(23, 25);
            this.LblStatusdocadastro.Name = "LblStatusdocadastro";
            this.LblStatusdocadastro.Size = new System.Drawing.Size(147, 19);
            this.LblStatusdocadastro.TabIndex = 1;
            this.LblStatusdocadastro.Text = "Status do Cadastro";
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblStatus.Location = new System.Drawing.Point(23, 55);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(55, 19);
            this.LblStatus.TabIndex = 2;
            this.LblStatus.Text = "Status";
            // 
            // TxtObservacao
            // 
            this.TxtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtObservacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtObservacao.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacao.Location = new System.Drawing.Point(819, 83);
            this.TxtObservacao.Name = "TxtObservacao";
            this.TxtObservacao.Size = new System.Drawing.Size(394, 27);
            this.TxtObservacao.TabIndex = 29;
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblDataCadastro.AutoSize = true;
            this.LblDataCadastro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblDataCadastro.Location = new System.Drawing.Point(421, 55);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(108, 19);
            this.LblDataCadastro.TabIndex = 3;
            this.LblDataCadastro.Text = "Data Registro";
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtSituacao.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSituacao.FormattingEnabled = true;
            this.TxtSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "SUSPENSO",
            "BANIDO"});
            this.TxtSituacao.Location = new System.Drawing.Point(23, 83);
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Size = new System.Drawing.Size(336, 27);
            this.TxtSituacao.TabIndex = 12;
            // 
            // DTP_DataRegistro
            // 
            this.DTP_DataRegistro.CalendarFont = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.DTP_DataRegistro.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DataRegistro.Location = new System.Drawing.Point(421, 83);
            this.DTP_DataRegistro.Name = "DTP_DataRegistro";
            this.DTP_DataRegistro.Size = new System.Drawing.Size(337, 27);
            this.DTP_DataRegistro.TabIndex = 13;
            // 
            // LblObservacao
            // 
            this.LblObservacao.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblObservacao.AutoSize = true;
            this.LblObservacao.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblObservacao.Location = new System.Drawing.Point(819, 55);
            this.LblObservacao.Name = "LblObservacao";
            this.LblObservacao.Size = new System.Drawing.Size(103, 19);
            this.LblObservacao.TabIndex = 14;
            this.LblObservacao.Text = "Observações";
            // 
            // PANEL_LISTA
            // 
            this.PANEL_LISTA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_LISTA.ColumnCount = 1;
            this.PANEL_LISTA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_LISTA.Controls.Add(this.DTG_View, 0, 1);
            this.PANEL_LISTA.Controls.Add(this.LblCadastrados, 0, 0);
            this.PANEL_LISTA.Location = new System.Drawing.Point(12, 634);
            this.PANEL_LISTA.Name = "PANEL_LISTA";
            this.PANEL_LISTA.Padding = new System.Windows.Forms.Padding(20);
            this.PANEL_LISTA.RowCount = 2;
            this.PANEL_LISTA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PANEL_LISTA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PANEL_LISTA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PANEL_LISTA.Size = new System.Drawing.Size(1236, 120);
            this.PANEL_LISTA.TabIndex = 36;
            // 
            // DTG_View
            // 
            this.DTG_View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTG_View.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTG_View.Location = new System.Drawing.Point(23, 53);
            this.DTG_View.Name = "DTG_View";
            this.DTG_View.Size = new System.Drawing.Size(1190, 44);
            this.DTG_View.TabIndex = 17;
            this.DTG_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_View_CellClick);
            // 
            // LblCadastrados
            // 
            this.LblCadastrados.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCadastrados.AutoSize = true;
            this.LblCadastrados.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LblCadastrados.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblCadastrados.Location = new System.Drawing.Point(23, 25);
            this.LblCadastrados.Name = "LblCadastrados";
            this.LblCadastrados.Size = new System.Drawing.Size(152, 19);
            this.LblCadastrados.TabIndex = 18;
            this.LblCadastrados.Text = "Lista - Cadastrados";
            // 
            // LblLink
            // 
            this.LblLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.LblLink.Location = new System.Drawing.Point(262, 30);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(40, 13);
            this.LblLink.TabIndex = 27;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // LBL_NomeProgramaRodape
            // 
            this.LBL_NomeProgramaRodape.AutoSize = true;
            this.LBL_NomeProgramaRodape.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NomeProgramaRodape.Location = new System.Drawing.Point(12, 30);
            this.LBL_NomeProgramaRodape.Name = "LBL_NomeProgramaRodape";
            this.LBL_NomeProgramaRodape.Size = new System.Drawing.Size(239, 13);
            this.LBL_NomeProgramaRodape.TabIndex = 23;
            this.LBL_NomeProgramaRodape.Text = "KERN - Gestão Inteligente | 2026 | @Gegugus |";
            // 
            // PANEL_RODAPE
            // 
            this.PANEL_RODAPE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PANEL_RODAPE.Controls.Add(this.LBL_NomeProgramaRodape);
            this.PANEL_RODAPE.Controls.Add(this.LblLink);
            this.PANEL_RODAPE.Location = new System.Drawing.Point(0, 754);
            this.PANEL_RODAPE.Name = "PANEL_RODAPE";
            this.PANEL_RODAPE.Size = new System.Drawing.Size(1260, 52);
            this.PANEL_RODAPE.TabIndex = 35;
            // 
            // FLOW_BOTOES
            // 
            this.FLOW_BOTOES.Controls.Add(this.BtnAdicionar);
            this.FLOW_BOTOES.Controls.Add(this.BtnPesquisar);
            this.FLOW_BOTOES.Controls.Add(this.BtnAlterar);
            this.FLOW_BOTOES.Controls.Add(this.BtnMostrarDados);
            this.FLOW_BOTOES.Controls.Add(this.BtnExcluir);
            this.FLOW_BOTOES.Location = new System.Drawing.Point(12, 565);
            this.FLOW_BOTOES.Name = "FLOW_BOTOES";
            this.FLOW_BOTOES.Padding = new System.Windows.Forms.Padding(20);
            this.FLOW_BOTOES.Size = new System.Drawing.Size(1236, 68);
            this.FLOW_BOTOES.TabIndex = 37;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAdicionar.AutoSize = true;
            this.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(48)))), ((int)(((byte)(34)))));
            this.BtnAdicionar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnAdicionar.Location = new System.Drawing.Point(23, 23);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(145, 40);
            this.BtnAdicionar.TabIndex = 35;
            this.BtnAdicionar.Text = "ADICIONAR";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPesquisar.AutoSize = true;
            this.BtnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.BtnPesquisar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnPesquisar.Location = new System.Drawing.Point(174, 23);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(145, 40);
            this.BtnPesquisar.TabIndex = 38;
            this.BtnPesquisar.Text = "PESQUISAR";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAlterar.AutoSize = true;
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.BtnAlterar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnAlterar.Location = new System.Drawing.Point(325, 23);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(145, 40);
            this.BtnAlterar.TabIndex = 37;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnMostrarDados
            // 
            this.BtnMostrarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMostrarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(103)))));
            this.BtnMostrarDados.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.BtnMostrarDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnMostrarDados.Location = new System.Drawing.Point(476, 23);
            this.BtnMostrarDados.Name = "BtnMostrarDados";
            this.BtnMostrarDados.Size = new System.Drawing.Size(145, 40);
            this.BtnMostrarDados.TabIndex = 36;
            this.BtnMostrarDados.Text = "LIMPAR TELA";
            this.BtnMostrarDados.UseVisualStyleBackColor = false;
            this.BtnMostrarDados.Click += new System.EventHandler(this.BtnMostrarDados_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcluir.AutoSize = true;
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(143)))), ((int)(((byte)(133)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BtnExcluir.Location = new System.Drawing.Point(627, 23);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(145, 40);
            this.BtnExcluir.TabIndex = 39;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // CadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1260, 817);
            this.Controls.Add(this.FLOW_BOTOES);
            this.Controls.Add(this.PANEL_LISTA);
            this.Controls.Add(this.PANEL_RODAPE);
            this.Controls.Add(this.PANEL_STATUS);
            this.Controls.Add(this.PANEL_ENDERECO);
            this.Controls.Add(this.PANEL_CONTATO);
            this.Controls.Add(this.PANEL_DADOSPESSOAIS);
            this.Controls.Add(this.LBL_NOMEPROGRAMA);
            this.Name = "CadClientes";
            this.Text = "KERN - CADASTRO CLIENTE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadClientes_Load);
            this.PANEL_DADOSPESSOAIS.ResumeLayout(false);
            this.PANEL_DADOSPESSOAIS.PerformLayout();
            this.PANEL_CONTATO.ResumeLayout(false);
            this.PANEL_CONTATO.PerformLayout();
            this.PANEL_ENDERECO.ResumeLayout(false);
            this.PANEL_ENDERECO.PerformLayout();
            this.PANEL_STATUS.ResumeLayout(false);
            this.PANEL_STATUS.PerformLayout();
            this.PANEL_LISTA.ResumeLayout(false);
            this.PANEL_LISTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).EndInit();
            this.PANEL_RODAPE.ResumeLayout(false);
            this.PANEL_RODAPE.PerformLayout();
            this.FLOW_BOTOES.ResumeLayout(false);
            this.FLOW_BOTOES.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_NOMEPROGRAMA;
        private System.Windows.Forms.TableLayoutPanel PANEL_DADOSPESSOAIS;
        private System.Windows.Forms.Label LblDadosPessoais;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblDataNascimento;
        private System.Windows.Forms.DateTimePicker DTP_DataNascimento;
        private System.Windows.Forms.TableLayoutPanel PANEL_CONTATO;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.MaskedTextBox TxtTelefone;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TableLayoutPanel PANEL_ENDERECO;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.Label LblLogradouro;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.MaskedTextBox TxtCEP;
        private System.Windows.Forms.TableLayoutPanel PANEL_STATUS;
        private System.Windows.Forms.Label LblStatusdocadastro;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblDataCadastro;
        private System.Windows.Forms.ComboBox TxtSituacao;
        private System.Windows.Forms.DateTimePicker DTP_DataRegistro;
        private System.Windows.Forms.Label LblObservacao;
        private System.Windows.Forms.TextBox TxtObservacao;
        private System.Windows.Forms.TableLayoutPanel PANEL_LISTA;
        private System.Windows.Forms.DataGridView DTG_View;
        private System.Windows.Forms.Label LblCadastrados;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label LBL_NomeProgramaRodape;
        private System.Windows.Forms.Panel PANEL_RODAPE;
        private System.Windows.Forms.FlowLayoutPanel FLOW_BOTOES;
        private System.Windows.Forms.Button BtnMostrarDados;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnAdicionar;
    }
}