namespace primeiroprojetoti48
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.LblNomeProduto = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.CB_Produtos = new System.Windows.Forms.ComboBox();
            this.LblDataCompra = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.LblCPFCliente = new System.Windows.Forms.Label();
            this.LblValorTotal1 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.BtnRegistrarProduto = new System.Windows.Forms.Button();
            this.DTG_View = new System.Windows.Forms.DataGridView();
            this.LblRegistrados = new System.Windows.Forms.Label();
            this.BtnAlterarProduto = new System.Windows.Forms.Button();
            this.BtnExcluirProduto = new System.Windows.Forms.Button();
            this.LblDesconto = new System.Windows.Forms.Label();
            this.LblSemDesconto = new System.Windows.Forms.Label();
            this.TxtCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.LblComDesconto = new System.Windows.Forms.Label();
            this.TxtComDesconto = new System.Windows.Forms.MaskedTextBox();
            this.DTP_DataRegistro = new System.Windows.Forms.DateTimePicker();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblValorTotal2 = new System.Windows.Forms.Label();
            this.BtnRegistrarCompra = new System.Windows.Forms.Button();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.TxtSemDesconto = new System.Windows.Forms.MaskedTextBox();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeProduto
            // 
            this.LblNomeProduto.AutoSize = true;
            this.LblNomeProduto.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNomeProduto.Location = new System.Drawing.Point(12, 23);
            this.LblNomeProduto.Name = "LblNomeProduto";
            this.LblNomeProduto.Size = new System.Drawing.Size(176, 29);
            this.LblNomeProduto.TabIndex = 2;
            this.LblNomeProduto.Text = "Nome do Produto:";
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(622, 61);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(236, 326);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 7;
            this.PictureBox.TabStop = false;
            // 
            // CB_Produtos
            // 
            this.CB_Produtos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Produtos.Font = new System.Drawing.Font("Rubik", 12F);
            this.CB_Produtos.FormattingEnabled = true;
            this.CB_Produtos.Location = new System.Drawing.Point(17, 61);
            this.CB_Produtos.Name = "CB_Produtos";
            this.CB_Produtos.Size = new System.Drawing.Size(556, 32);
            this.CB_Produtos.TabIndex = 2;
            this.CB_Produtos.SelectedIndexChanged += new System.EventHandler(this.CB_Produtos_SelectedIndexChanged);
            // 
            // LblDataCompra
            // 
            this.LblDataCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblDataCompra.AutoSize = true;
            this.LblDataCompra.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDataCompra.Location = new System.Drawing.Point(12, 453);
            this.LblDataCompra.Name = "LblDataCompra";
            this.LblDataCompra.Size = new System.Drawing.Size(164, 29);
            this.LblDataCompra.TabIndex = 2;
            this.LblDataCompra.Text = "Data da Compra:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantidade.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtQuantidade.Location = new System.Drawing.Point(138, 109);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(119, 26);
            this.TxtQuantidade.TabIndex = 3;
            // 
            // LblCPFCliente
            // 
            this.LblCPFCliente.AutoSize = true;
            this.LblCPFCliente.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCPFCliente.Location = new System.Drawing.Point(277, 108);
            this.LblCPFCliente.Name = "LblCPFCliente";
            this.LblCPFCliente.Size = new System.Drawing.Size(124, 29);
            this.LblCPFCliente.TabIndex = 2;
            this.LblCPFCliente.Text = "CPF Cliente:";
            // 
            // LblValorTotal1
            // 
            this.LblValorTotal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblValorTotal1.AutoSize = true;
            this.LblValorTotal1.Font = new System.Drawing.Font("Rubik ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal1.Location = new System.Drawing.Point(18, 545);
            this.LblValorTotal1.Name = "LblValorTotal1";
            this.LblValorTotal1.Size = new System.Drawing.Size(209, 42);
            this.LblValorTotal1.TabIndex = 2;
            this.LblValorTotal1.Text = "VALOR TOTAL ";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.TxtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorTotal.Font = new System.Drawing.Font("Rubik", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtValorTotal.Location = new System.Drawing.Point(233, 545);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(340, 64);
            this.TxtValorTotal.TabIndex = 30;
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnRegistrarProduto
            // 
            this.BtnRegistrarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(214)))));
            this.BtnRegistrarProduto.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.BtnRegistrarProduto.Location = new System.Drawing.Point(17, 155);
            this.BtnRegistrarProduto.Name = "BtnRegistrarProduto";
            this.BtnRegistrarProduto.Size = new System.Drawing.Size(556, 40);
            this.BtnRegistrarProduto.TabIndex = 4;
            this.BtnRegistrarProduto.Text = "Registrar Produto";
            this.BtnRegistrarProduto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProduto.Click += new System.EventHandler(this.BtnRegistrarProduto_Click);
            // 
            // DTG_View
            // 
            this.DTG_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_View.Location = new System.Drawing.Point(17, 249);
            this.DTG_View.Name = "DTG_View";
            this.DTG_View.Size = new System.Drawing.Size(556, 142);
            this.DTG_View.TabIndex = 32;
            // 
            // LblRegistrados
            // 
            this.LblRegistrados.AutoSize = true;
            this.LblRegistrados.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblRegistrados.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblRegistrados.Location = new System.Drawing.Point(12, 216);
            this.LblRegistrados.Name = "LblRegistrados";
            this.LblRegistrados.Size = new System.Drawing.Size(275, 29);
            this.LblRegistrados.TabIndex = 33;
            this.LblRegistrados.Text = "Lista - Produtos Registrados";
            // 
            // BtnAlterarProduto
            // 
            this.BtnAlterarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAlterarProduto.BackColor = System.Drawing.Color.LightGray;
            this.BtnAlterarProduto.Font = new System.Drawing.Font("Rubik", 11F);
            this.BtnAlterarProduto.Location = new System.Drawing.Point(17, 409);
            this.BtnAlterarProduto.Name = "BtnAlterarProduto";
            this.BtnAlterarProduto.Size = new System.Drawing.Size(270, 30);
            this.BtnAlterarProduto.TabIndex = 6;
            this.BtnAlterarProduto.Text = "Alterar Produto";
            this.BtnAlterarProduto.UseVisualStyleBackColor = false;
            this.BtnAlterarProduto.Click += new System.EventHandler(this.BtnAlterarProduto_Click);
            // 
            // BtnExcluirProduto
            // 
            this.BtnExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnExcluirProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(124)))), ((int)(((byte)(121)))));
            this.BtnExcluirProduto.Font = new System.Drawing.Font("Rubik", 11F);
            this.BtnExcluirProduto.Location = new System.Drawing.Point(303, 409);
            this.BtnExcluirProduto.Name = "BtnExcluirProduto";
            this.BtnExcluirProduto.Size = new System.Drawing.Size(270, 30);
            this.BtnExcluirProduto.TabIndex = 7;
            this.BtnExcluirProduto.Text = "Excluir Produto";
            this.BtnExcluirProduto.UseVisualStyleBackColor = false;
            this.BtnExcluirProduto.Click += new System.EventHandler(this.BtnExcluirProduto_Click);
            // 
            // LblDesconto
            // 
            this.LblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDesconto.AutoSize = true;
            this.LblDesconto.Font = new System.Drawing.Font("Rubik Medium", 12F, System.Drawing.FontStyle.Bold);
            this.LblDesconto.Location = new System.Drawing.Point(618, 412);
            this.LblDesconto.Name = "LblDesconto";
            this.LblDesconto.Size = new System.Drawing.Size(87, 24);
            this.LblDesconto.TabIndex = 2;
            this.LblDesconto.Text = "Desconto:";
            // 
            // LblSemDesconto
            // 
            this.LblSemDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSemDesconto.AutoSize = true;
            this.LblSemDesconto.Font = new System.Drawing.Font("Rubik Medium", 12F, System.Drawing.FontStyle.Bold);
            this.LblSemDesconto.Location = new System.Drawing.Point(618, 457);
            this.LblSemDesconto.Name = "LblSemDesconto";
            this.LblSemDesconto.Size = new System.Drawing.Size(123, 24);
            this.LblSemDesconto.TabIndex = 2;
            this.LblSemDesconto.Text = "Sem desconto:";
            // 
            // TxtCPFCliente
            // 
            this.TxtCPFCliente.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TxtCPFCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCPFCliente.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtCPFCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtCPFCliente.Location = new System.Drawing.Point(417, 109);
            this.TxtCPFCliente.Mask = "000.000.000-00";
            this.TxtCPFCliente.Name = "TxtCPFCliente";
            this.TxtCPFCliente.Size = new System.Drawing.Size(156, 26);
            this.TxtCPFCliente.TabIndex = 1;
            this.TxtCPFCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblComDesconto
            // 
            this.LblComDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblComDesconto.AutoSize = true;
            this.LblComDesconto.Font = new System.Drawing.Font("Rubik Medium", 12F, System.Drawing.FontStyle.Bold);
            this.LblComDesconto.Location = new System.Drawing.Point(618, 490);
            this.LblComDesconto.Name = "LblComDesconto";
            this.LblComDesconto.Size = new System.Drawing.Size(124, 24);
            this.LblComDesconto.TabIndex = 2;
            this.LblComDesconto.Text = "Com desconto:";
            // 
            // TxtComDesconto
            // 
            this.TxtComDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtComDesconto.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtComDesconto.Location = new System.Drawing.Point(766, 484);
            this.TxtComDesconto.Name = "TxtComDesconto";
            this.TxtComDesconto.Size = new System.Drawing.Size(92, 26);
            this.TxtComDesconto.TabIndex = 34;
            this.TxtComDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DTP_DataRegistro
            // 
            this.DTP_DataRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTP_DataRegistro.Font = new System.Drawing.Font("Rubik", 12F);
            this.DTP_DataRegistro.Location = new System.Drawing.Point(17, 488);
            this.DTP_DataRegistro.Name = "DTP_DataRegistro";
            this.DTP_DataRegistro.Size = new System.Drawing.Size(556, 26);
            this.DTP_DataRegistro.TabIndex = 8;
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblQuantidade.Location = new System.Drawing.Point(13, 110);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(125, 29);
            this.LblQuantidade.TabIndex = 2;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // LblValorTotal2
            // 
            this.LblValorTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblValorTotal2.AutoSize = true;
            this.LblValorTotal2.Font = new System.Drawing.Font("Rubik ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal2.Location = new System.Drawing.Point(18, 579);
            this.LblValorTotal2.Name = "LblValorTotal2";
            this.LblValorTotal2.Size = new System.Drawing.Size(182, 42);
            this.LblValorTotal2.TabIndex = 2;
            this.LblValorTotal2.Text = "DA COMPRA";
            // 
            // BtnRegistrarCompra
            // 
            this.BtnRegistrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(189)))), ((int)(((byte)(121)))));
            this.BtnRegistrarCompra.Font = new System.Drawing.Font("Rubik", 14.25F);
            this.BtnRegistrarCompra.Location = new System.Drawing.Point(622, 545);
            this.BtnRegistrarCompra.Name = "BtnRegistrarCompra";
            this.BtnRegistrarCompra.Size = new System.Drawing.Size(236, 64);
            this.BtnRegistrarCompra.TabIndex = 9;
            this.BtnRegistrarCompra.Text = "Registrar Compra";
            this.BtnRegistrarCompra.UseVisualStyleBackColor = false;
            this.BtnRegistrarCompra.Click += new System.EventHandler(this.BtnRegistrarCompra_Click);
            // 
            // LblLink
            // 
            this.LblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(814, 637);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 36;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(711, 637);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 37;
            this.Lbl_Copyright.Text = "2025 ©Gegugus ";
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(21, 637);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(131, 17);
            this.Lbl_Rodape.TabIndex = 38;
            this.Lbl_Rodape.Text = "Sistema de Vendas v1.0";
            // 
            // TxtSemDesconto
            // 
            this.TxtSemDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSemDesconto.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtSemDesconto.Location = new System.Drawing.Point(766, 454);
            this.TxtSemDesconto.Name = "TxtSemDesconto";
            this.TxtSemDesconto.Size = new System.Drawing.Size(92, 26);
            this.TxtSemDesconto.TabIndex = 34;
            this.TxtSemDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDesconto.Font = new System.Drawing.Font("Rubik", 12F);
            this.TxtDesconto.Location = new System.Drawing.Point(710, 409);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(148, 26);
            this.TxtDesconto.TabIndex = 5;
            this.TxtDesconto.TextChanged += new System.EventHandler(this.TxtDesconto_TextChanged);
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 659);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.DTP_DataRegistro);
            this.Controls.Add(this.TxtSemDesconto);
            this.Controls.Add(this.TxtComDesconto);
            this.Controls.Add(this.TxtCPFCliente);
            this.Controls.Add(this.LblRegistrados);
            this.Controls.Add(this.DTG_View);
            this.Controls.Add(this.BtnExcluirProduto);
            this.Controls.Add(this.BtnAlterarProduto);
            this.Controls.Add(this.BtnRegistrarCompra);
            this.Controls.Add(this.BtnRegistrarProduto);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.TxtDesconto);
            this.Controls.Add(this.TxtQuantidade);
            this.Controls.Add(this.CB_Produtos);
            this.Controls.Add(this.LblComDesconto);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.LblSemDesconto);
            this.Controls.Add(this.LblQuantidade);
            this.Controls.Add(this.LblCPFCliente);
            this.Controls.Add(this.LblValorTotal2);
            this.Controls.Add(this.LblValorTotal1);
            this.Controls.Add(this.LblDesconto);
            this.Controls.Add(this.LblDataCompra);
            this.Controls.Add(this.LblNomeProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.Text = "Cadastro de Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblNomeProduto;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.ComboBox CB_Produtos;
        private System.Windows.Forms.Label LblDataCompra;
        private System.Windows.Forms.Label LblCPFCliente;
        private System.Windows.Forms.Label LblValorTotal1;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Button BtnRegistrarProduto;
        private System.Windows.Forms.DataGridView DTG_View;
        private System.Windows.Forms.Label LblRegistrados;
        private System.Windows.Forms.Button BtnAlterarProduto;
        private System.Windows.Forms.Button BtnExcluirProduto;
        private System.Windows.Forms.Label LblDesconto;
        private System.Windows.Forms.Label LblSemDesconto;
        private System.Windows.Forms.MaskedTextBox TxtCPFCliente;
        private System.Windows.Forms.Label LblComDesconto;
        private System.Windows.Forms.MaskedTextBox TxtComDesconto;
        private System.Windows.Forms.DateTimePicker DTP_DataRegistro;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblValorTotal2;
        private System.Windows.Forms.Button BtnRegistrarCompra;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Label Lbl_Rodape;
        private System.Windows.Forms.MaskedTextBox TxtSemDesconto;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.TextBox TxtDesconto;
    }
}