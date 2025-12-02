namespace primeiroprojetoti48
{
    partial class Produtos
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
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblImagem = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.TxtDescricao = new System.Windows.Forms.RichTextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblEstoque = new System.Windows.Forms.Label();
            this.TxtEstoque = new System.Windows.Forms.TextBox();
            this.TxtCategoria = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.DTP_DataRegistro = new System.Windows.Forms.DateTimePicker();
            this.LblDataCadastro = new System.Windows.Forms.Label();
            this.LblImgInserir = new System.Windows.Forms.Button();
            this.LblImgExcluir = new System.Windows.Forms.Button();
            this.LblImgAlterar = new System.Windows.Forms.Button();
            this.DTG_View = new System.Windows.Forms.DataGridView();
            this.LblCadastrados = new System.Windows.Forms.Label();
            this.BtnMostrarDados = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtPreco = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNome.Location = new System.Drawing.Point(12, 15);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(212, 29);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome do Produto - ID:";
            // 
            // TxtNome
            // 
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtNome.Location = new System.Drawing.Point(17, 47);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(440, 26);
            this.TxtNome.TabIndex = 0;
            // 
            // LblImagem
            // 
            this.LblImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImagem.AutoSize = true;
            this.LblImagem.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblImagem.Location = new System.Drawing.Point(483, 15);
            this.LblImagem.Name = "LblImagem";
            this.LblImagem.Size = new System.Drawing.Size(87, 29);
            this.LblImagem.TabIndex = 0;
            this.LblImagem.Text = "Imagem";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDescricao.Location = new System.Drawing.Point(12, 93);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(104, 29);
            this.LblDescricao.TabIndex = 0;
            this.LblDescricao.Text = "Descrição";
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescricao.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.TxtDescricao.Location = new System.Drawing.Point(17, 125);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(440, 100);
            this.TxtDescricao.TabIndex = 1;
            this.TxtDescricao.Text = "";
            // 
            // LblPreco
            // 
            this.LblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblPreco.Location = new System.Drawing.Point(12, 244);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(67, 29);
            this.LblPreco.TabIndex = 0;
            this.LblPreco.Text = "Preço";
            // 
            // LblEstoque
            // 
            this.LblEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblEstoque.AutoSize = true;
            this.LblEstoque.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblEstoque.Location = new System.Drawing.Point(252, 245);
            this.LblEstoque.Name = "LblEstoque";
            this.LblEstoque.Size = new System.Drawing.Size(89, 29);
            this.LblEstoque.TabIndex = 0;
            this.LblEstoque.Text = "Estoque";
            // 
            // TxtEstoque
            // 
            this.TxtEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEstoque.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtEstoque.Location = new System.Drawing.Point(257, 277);
            this.TxtEstoque.Name = "TxtEstoque";
            this.TxtEstoque.Size = new System.Drawing.Size(200, 26);
            this.TxtEstoque.TabIndex = 3;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtCategoria.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtCategoria.FormattingEnabled = true;
            this.TxtCategoria.Items.AddRange(new object[] {
            "ALIMENTOS E BEBIDAS",
            "ACESSÓRIOS",
            "AUTOMOTIVO",
            "BELEZA E COSMÉTICOS",
            "BRINQUEDOS",
            "CALÇADOS",
            "CELULARES E TELEFONIA",
            "DECORAÇÃO",
            "ELETRÔNICOS",
            "ELETRODOMÉSTICOS",
            "ENTRETENIMENTO",
            "ESPORTES E FITNESS",
            "INFORMÁTICA",
            "JARDIM E EXTERIOR",
            "LIVROS",
            "MODA FEMININA",
            "MODA INFANTIL",
            "MODA MASCULINA",
            "MÓVEIS",
            "PAPELARIA",
            "PERFUMARIA",
            "PET SHOP",
            "UTENSÍLIOS PARA CASA"});
            this.TxtCategoria.Location = new System.Drawing.Point(17, 357);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(440, 32);
            this.TxtCategoria.TabIndex = 4;
            // 
            // LblCategoria
            // 
            this.LblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCategoria.Location = new System.Drawing.Point(12, 325);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(103, 29);
            this.LblCategoria.TabIndex = 0;
            this.LblCategoria.Text = "Categoria";
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(488, 47);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(350, 342);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 6;
            this.PictureBox.TabStop = false;
            // 
            // DTP_DataRegistro
            // 
            this.DTP_DataRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DTP_DataRegistro.Font = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataRegistro.Location = new System.Drawing.Point(17, 437);
            this.DTP_DataRegistro.Name = "DTP_DataRegistro";
            this.DTP_DataRegistro.Size = new System.Drawing.Size(440, 26);
            this.DTP_DataRegistro.TabIndex = 5;
            // 
            // LblDataCadastro
            // 
            this.LblDataCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblDataCadastro.AutoSize = true;
            this.LblDataCadastro.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDataCadastro.Location = new System.Drawing.Point(12, 402);
            this.LblDataCadastro.Name = "LblDataCadastro";
            this.LblDataCadastro.Size = new System.Drawing.Size(165, 29);
            this.LblDataCadastro.TabIndex = 0;
            this.LblDataCadastro.Text = "Data de Registro";
            // 
            // LblImgInserir
            // 
            this.LblImgInserir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImgInserir.Font = new System.Drawing.Font("Rubik Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImgInserir.Location = new System.Drawing.Point(488, 406);
            this.LblImgInserir.Name = "LblImgInserir";
            this.LblImgInserir.Size = new System.Drawing.Size(170, 60);
            this.LblImgInserir.TabIndex = 6;
            this.LblImgInserir.Text = "Carregar Imagem\r\n.png\r\n\r\n";
            this.LblImgInserir.UseVisualStyleBackColor = true;
            this.LblImgInserir.Click += new System.EventHandler(this.LblImgInserir_Click);
            // 
            // LblImgExcluir
            // 
            this.LblImgExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImgExcluir.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImgExcluir.Location = new System.Drawing.Point(668, 441);
            this.LblImgExcluir.Name = "LblImgExcluir";
            this.LblImgExcluir.Size = new System.Drawing.Size(170, 25);
            this.LblImgExcluir.TabIndex = 8;
            this.LblImgExcluir.Text = "Excluir Imagem";
            this.LblImgExcluir.UseVisualStyleBackColor = true;
            this.LblImgExcluir.Click += new System.EventHandler(this.LblImgExcluir_Click);
            // 
            // LblImgAlterar
            // 
            this.LblImgAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblImgAlterar.Font = new System.Drawing.Font("Rubik", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImgAlterar.Location = new System.Drawing.Point(668, 406);
            this.LblImgAlterar.Name = "LblImgAlterar";
            this.LblImgAlterar.Size = new System.Drawing.Size(170, 25);
            this.LblImgAlterar.TabIndex = 7;
            this.LblImgAlterar.Text = "Alterar Imagem";
            this.LblImgAlterar.UseVisualStyleBackColor = true;
            this.LblImgAlterar.Click += new System.EventHandler(this.LblImgAlterar_Click);
            // 
            // DTG_View
            // 
            this.DTG_View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_View.Location = new System.Drawing.Point(17, 511);
            this.DTG_View.Name = "DTG_View";
            this.DTG_View.Size = new System.Drawing.Size(821, 100);
            this.DTG_View.TabIndex = 0;
            this.DTG_View.TabStop = false;
            this.DTG_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_View_CellContentClick);
            // 
            // LblCadastrados
            // 
            this.LblCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCadastrados.AutoSize = true;
            this.LblCadastrados.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCadastrados.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblCadastrados.Location = new System.Drawing.Point(12, 479);
            this.LblCadastrados.Name = "LblCadastrados";
            this.LblCadastrados.Size = new System.Drawing.Size(192, 29);
            this.LblCadastrados.TabIndex = 0;
            this.LblCadastrados.Text = "Lista - Cadastrados";
            // 
            // BtnMostrarDados
            // 
            this.BtnMostrarDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnMostrarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.BtnMostrarDados.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.BtnMostrarDados.Location = new System.Drawing.Point(181, 627);
            this.BtnMostrarDados.Name = "BtnMostrarDados";
            this.BtnMostrarDados.Size = new System.Drawing.Size(160, 40);
            this.BtnMostrarDados.TabIndex = 10;
            this.BtnMostrarDados.Text = "Limpar Tela";
            this.BtnMostrarDados.UseVisualStyleBackColor = false;
            this.BtnMostrarDados.Click += new System.EventHandler(this.BtnMostrarDados_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnPesquisar.AutoSize = true;
            this.BtnPesquisar.BackColor = System.Drawing.Color.LightGray;
            this.BtnPesquisar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(512, 627);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(160, 40);
            this.BtnPesquisar.TabIndex = 12;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluir.AutoSize = true;
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(124)))), ((int)(((byte)(121)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.Location = new System.Drawing.Point(678, 627);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(160, 40);
            this.BtnExcluir.TabIndex = 13;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAlterar.AutoSize = true;
            this.BtnAlterar.BackColor = System.Drawing.Color.LightGray;
            this.BtnAlterar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.Location = new System.Drawing.Point(347, 627);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(160, 40);
            this.BtnAlterar.TabIndex = 11;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdicionar.AutoSize = true;
            this.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            this.BtnAdicionar.Font = new System.Drawing.Font("Rubik", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionar.Location = new System.Drawing.Point(17, 627);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(160, 40);
            this.BtnAdicionar.TabIndex = 9;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // LblLink
            // 
            this.LblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(794, 678);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 14;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(695, 678);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 24;
            this.Lbl_Copyright.Text = "2025 ©Gegugus ";
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(14, 678);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(144, 17);
            this.Lbl_Rodape.TabIndex = 25;
            this.Lbl_Rodape.Text = "Cadastro de Produtos v1.0";
            // 
            // TxtID
            // 
            this.TxtID.BackColor = System.Drawing.SystemColors.Control;
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtID.Cursor = System.Windows.Forms.Cursors.No;
            this.TxtID.Font = new System.Drawing.Font("Rubik", 11F);
            this.TxtID.Location = new System.Drawing.Point(230, 19);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(72, 18);
            this.TxtID.TabIndex = 27;
            this.TxtID.TabStop = false;
            // 
            // TxtPreco
            // 
            this.TxtPreco.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.TxtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPreco.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtPreco.Location = new System.Drawing.Point(17, 277);
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(200, 26);
            this.TxtPreco.TabIndex = 2;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 704);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.BtnMostrarDados);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.DTG_View);
            this.Controls.Add(this.LblImgAlterar);
            this.Controls.Add(this.LblImgExcluir);
            this.Controls.Add(this.LblImgInserir);
            this.Controls.Add(this.DTP_DataRegistro);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TxtCategoria);
            this.Controls.Add(this.TxtPreco);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.TxtEstoque);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblImagem);
            this.Controls.Add(this.LblCadastrados);
            this.Controls.Add(this.LblDataCadastro);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblEstoque);
            this.Controls.Add(this.LblNome);
            this.Name = "Produtos";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblImagem;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.RichTextBox TxtDescricao;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblEstoque;
        private System.Windows.Forms.TextBox TxtEstoque;
        private System.Windows.Forms.ComboBox TxtCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.DateTimePicker DTP_DataRegistro;
        private System.Windows.Forms.Label LblDataCadastro;
        private System.Windows.Forms.Button LblImgInserir;
        private System.Windows.Forms.Button LblImgExcluir;
        private System.Windows.Forms.Button LblImgAlterar;
        private System.Windows.Forms.DataGridView DTG_View;
        private System.Windows.Forms.Label LblCadastrados;
        private System.Windows.Forms.Button BtnMostrarDados;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Label Lbl_Rodape;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.MaskedTextBox TxtPreco;
    }
}