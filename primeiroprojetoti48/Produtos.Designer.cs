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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblImagem = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.LblEstoque = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNome.Location = new System.Drawing.Point(12, 63);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(171, 29);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome do Produto";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox1.Location = new System.Drawing.Point(17, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 26);
            this.textBox1.TabIndex = 1;
            // 
            // LblImagem
            // 
            this.LblImagem.AutoSize = true;
            this.LblImagem.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblImagem.Location = new System.Drawing.Point(501, 63);
            this.LblImagem.Name = "LblImagem";
            this.LblImagem.Size = new System.Drawing.Size(87, 29);
            this.LblImagem.TabIndex = 0;
            this.LblImagem.Text = "Imagem";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDescricao.Location = new System.Drawing.Point(12, 141);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(104, 29);
            this.LblDescricao.TabIndex = 0;
            this.LblDescricao.Text = "Descrição";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(17, 173);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(440, 100);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblPreco.Location = new System.Drawing.Point(12, 292);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(67, 29);
            this.LblPreco.TabIndex = 0;
            this.LblPreco.Text = "Preço";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Rubik", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(17, 325);
            this.maskedTextBox1.Mask = "$";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 26);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // LblEstoque
            // 
            this.LblEstoque.AutoSize = true;
            this.LblEstoque.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblEstoque.Location = new System.Drawing.Point(252, 293);
            this.LblEstoque.Name = "LblEstoque";
            this.LblEstoque.Size = new System.Drawing.Size(89, 29);
            this.LblEstoque.TabIndex = 0;
            this.LblEstoque.Text = "Estoque";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Rubik", 12F);
            this.textBox2.Location = new System.Drawing.Point(257, 325);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Rubik", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(17, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(440, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rubik Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCategoria.Location = new System.Drawing.Point(12, 373);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(103, 29);
            this.LblCategoria.TabIndex = 0;
            this.LblCategoria.Text = "Categoria";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 594);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.LblImagem);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblPreco);
            this.Controls.Add(this.LblEstoque);
            this.Controls.Add(this.LblNome);
            this.Name = "Produtos";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblImagem;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label LblEstoque;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblCategoria;
    }
}