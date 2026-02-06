namespace primeiroprojetoti48
{
    partial class TB_Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TB_Vendas));
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.LBL_VENDASTABELA = new System.Windows.Forms.Label();
            this.LblLink = new System.Windows.Forms.LinkLabel();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.Lbl_Rodape = new System.Windows.Forms.Label();
            this.DTG_View = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.BtnAtualizar.Font = new System.Drawing.Font("Rubik Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(12, 379);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(781, 34);
            this.BtnAtualizar.TabIndex = 39;
            this.BtnAtualizar.Text = "ATUALIZAR";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // LBL_VENDASTABELA
            // 
            this.LBL_VENDASTABELA.AutoSize = true;
            this.LBL_VENDASTABELA.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VENDASTABELA.Location = new System.Drawing.Point(12, 14);
            this.LBL_VENDASTABELA.Name = "LBL_VENDASTABELA";
            this.LBL_VENDASTABELA.Size = new System.Drawing.Size(193, 24);
            this.LBL_VENDASTABELA.TabIndex = 38;
            this.LBL_VENDASTABELA.Text = "VENDAS REGISTRADAS";
            // 
            // LblLink
            // 
            this.LblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLink.AutoSize = true;
            this.LblLink.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLink.Location = new System.Drawing.Point(751, 423);
            this.LblLink.Name = "LblLink";
            this.LblLink.Size = new System.Drawing.Size(44, 17);
            this.LblLink.TabIndex = 35;
            this.LblLink.TabStop = true;
            this.LblLink.Text = "GitHub";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(652, 423);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(96, 17);
            this.Lbl_Copyright.TabIndex = 36;
            this.Lbl_Copyright.Text = "2026 ©Gegugus ";
            // 
            // Lbl_Rodape
            // 
            this.Lbl_Rodape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbl_Rodape.AutoSize = true;
            this.Lbl_Rodape.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rodape.Location = new System.Drawing.Point(12, 423);
            this.Lbl_Rodape.Name = "Lbl_Rodape";
            this.Lbl_Rodape.Size = new System.Drawing.Size(131, 17);
            this.Lbl_Rodape.TabIndex = 37;
            this.Lbl_Rodape.Text = "Sistema de Vendas v1.0";
            // 
            // DTG_View
            // 
            this.DTG_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_View.Location = new System.Drawing.Point(12, 41);
            this.DTG_View.Name = "DTG_View";
            this.DTG_View.Size = new System.Drawing.Size(781, 323);
            this.DTG_View.TabIndex = 34;
            this.DTG_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTG_View_CellContentClick);
            // 
            // TB_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.LBL_VENDASTABELA);
            this.Controls.Add(this.LblLink);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Rodape);
            this.Controls.Add(this.DTG_View);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TB_Vendas";
            this.Text = "Tabela - Vendas Registradas";
            this.Load += new System.EventHandler(this.TB_Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Label LBL_VENDASTABELA;
        private System.Windows.Forms.LinkLabel LblLink;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Label Lbl_Rodape;
        private System.Windows.Forms.DataGridView DTG_View;
    }
}