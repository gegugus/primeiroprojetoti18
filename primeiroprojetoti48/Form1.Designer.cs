namespace primeiroprojetoti48
{
    partial class Form1
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
            this.btn_Adicao = new System.Windows.Forms.Button();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.lbl_Calculadora = new System.Windows.Forms.Label();
            this.txt_NumA = new System.Windows.Forms.TextBox();
            this.txt_NumB = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Adicao
            // 
            this.btn_Adicao.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Adicao.Font = new System.Drawing.Font("SansSerif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Adicao.Location = new System.Drawing.Point(27, 152);
            this.btn_Adicao.Name = "btn_Adicao";
            this.btn_Adicao.Size = new System.Drawing.Size(47, 41);
            this.btn_Adicao.TabIndex = 0;
            this.btn_Adicao.Text = "+";
            this.btn_Adicao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Adicao.UseVisualStyleBackColor = true;
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Subtracao.Font = new System.Drawing.Font("SansSerif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Subtracao.Location = new System.Drawing.Point(80, 152);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(47, 41);
            this.btn_Subtracao.TabIndex = 0;
            this.btn_Subtracao.Text = "-";
            this.btn_Subtracao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Subtracao.UseVisualStyleBackColor = true;
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Multiplicacao.Font = new System.Drawing.Font("SansSerif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Multiplicacao.Location = new System.Drawing.Point(133, 152);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(47, 41);
            this.btn_Multiplicacao.TabIndex = 0;
            this.btn_Multiplicacao.Text = "x";
            this.btn_Multiplicacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Divisao.Font = new System.Drawing.Font("SansSerif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_Divisao.Location = new System.Drawing.Point(186, 152);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(47, 41);
            this.btn_Divisao.TabIndex = 0;
            this.btn_Divisao.Text = "/";
            this.btn_Divisao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Divisao.UseVisualStyleBackColor = true;
            this.btn_Divisao.Click += new System.EventHandler(this.btn_Divisao_Click);
            // 
            // lbl_Calculadora
            // 
            this.lbl_Calculadora.AutoSize = true;
            this.lbl_Calculadora.Font = new System.Drawing.Font("SansSerif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_Calculadora.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Calculadora.Location = new System.Drawing.Point(47, 38);
            this.lbl_Calculadora.Name = "lbl_Calculadora";
            this.lbl_Calculadora.Size = new System.Drawing.Size(168, 31);
            this.lbl_Calculadora.TabIndex = 1;
            this.lbl_Calculadora.Text = "Calculadora";
            this.lbl_Calculadora.Click += new System.EventHandler(this.lbl_Calculadora_Click);
            // 
            // txt_NumA
            // 
            this.txt_NumA.Location = new System.Drawing.Point(27, 105);
            this.txt_NumA.Name = "txt_NumA";
            this.txt_NumA.Size = new System.Drawing.Size(100, 20);
            this.txt_NumA.TabIndex = 2;
            // 
            // txt_NumB
            // 
            this.txt_NumB.Location = new System.Drawing.Point(133, 105);
            this.txt_NumB.Name = "txt_NumB";
            this.txt_NumB.Size = new System.Drawing.Size(100, 20);
            this.txt_NumB.TabIndex = 2;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(27, 219);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(206, 20);
            this.txt_Resultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(274, 311);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_NumB);
            this.Controls.Add(this.txt_NumA);
            this.Controls.Add(this.lbl_Calculadora);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_Adicao);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Adicao;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_Divisao;
        private System.Windows.Forms.Label lbl_Calculadora;
        private System.Windows.Forms.TextBox txt_NumA;
        private System.Windows.Forms.TextBox txt_NumB;
        private System.Windows.Forms.TextBox txt_Resultado;
    }
}

