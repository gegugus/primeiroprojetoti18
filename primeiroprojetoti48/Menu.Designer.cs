namespace primeiroprojetoti48
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.BtnVendas = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasAsTabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVendas
            // 
            this.BtnVendas.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnVendas.Location = new System.Drawing.Point(12, 34);
            this.BtnVendas.Name = "BtnVendas";
            this.BtnVendas.Size = new System.Drawing.Size(330, 330);
            this.BtnVendas.TabIndex = 0;
            this.BtnVendas.Text = "VENDAS";
            this.BtnVendas.UseVisualStyleBackColor = false;
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(160)))), ((int)(((byte)(102)))));
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.Location = new System.Drawing.Point(357, 34);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(200, 160);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(87)))), ((int)(((byte)(59)))));
            this.BtnProdutos.Location = new System.Drawing.Point(357, 204);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(415, 160);
            this.BtnProdutos.TabIndex = 0;
            this.BtnProdutos.Text = "PRODUTOS";
            this.BtnProdutos.UseVisualStyleBackColor = false;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalculadora.Image")));
            this.BtnCalculadora.Location = new System.Drawing.Point(572, 34);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Size = new System.Drawing.Size(200, 160);
            this.BtnCalculadora.TabIndex = 0;
            this.BtnCalculadora.UseVisualStyleBackColor = true;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuStrip.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.BtnSair});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(784, 27);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.todasAsTabelasToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // todasAsTabelasToolStripMenuItem
            // 
            this.todasAsTabelasToolStripMenuItem.Name = "todasAsTabelasToolStripMenuItem";
            this.todasAsTabelasToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.todasAsTabelasToolStripMenuItem.Text = "Todas as Tabelas";
            // 
            // BtnSair
            // 
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(43, 23);
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblLink
            // 
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(728, 383);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 22;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(629, 383);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 20;
            this.Lbl_Copyright.Text = "2025 ©Gegugus ";
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(12, 383);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(131, 17);
            this.Lbl_Rodape.TabIndex = 21;
            this.Lbl_Rodape.Text = "Sistema de Vendas v1.0";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 408);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.BtnProdutos);
            this.Controls.Add(this.BtnCalculadora);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnVendas);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Menu";
            this.Text = "Sistema de Vendas";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVendas;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnCalculadora;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasAsTabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnSair;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Label Lbl_Rodape;
    }
}