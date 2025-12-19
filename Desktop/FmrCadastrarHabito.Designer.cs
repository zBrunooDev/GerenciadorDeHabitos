namespace Desktop
{
    partial class FmrCadastrarHabito
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCadastrarHabito = new System.Windows.Forms.TextBox();
            this.lblCadastrarHabito = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.btnCadastrarHabito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCadastrarHabito
            // 
            this.txtCadastrarHabito.Location = new System.Drawing.Point(45, 119);
            this.txtCadastrarHabito.Multiline = true;
            this.txtCadastrarHabito.Name = "txtCadastrarHabito";
            this.txtCadastrarHabito.Size = new System.Drawing.Size(275, 117);
            this.txtCadastrarHabito.TabIndex = 0;
            // 
            // lblCadastrarHabito
            // 
            this.lblCadastrarHabito.AutoSize = true;
            this.lblCadastrarHabito.Location = new System.Drawing.Point(129, 86);
            this.lblCadastrarHabito.Name = "lblCadastrarHabito";
            this.lblCadastrarHabito.Size = new System.Drawing.Size(101, 13);
            this.lblCadastrarHabito.TabIndex = 1;
            this.lblCadastrarHabito.Text = "Cadastre um hábito:";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Location = new System.Drawing.Point(348, 37);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(60, 13);
            this.lblBemVindo.TabIndex = 2;
            this.lblBemVindo.Text = "Bem vindo!";
            // 
            // btnCadastrarHabito
            // 
            this.btnCadastrarHabito.Location = new System.Drawing.Point(132, 269);
            this.btnCadastrarHabito.Name = "btnCadastrarHabito";
            this.btnCadastrarHabito.Size = new System.Drawing.Size(98, 44);
            this.btnCadastrarHabito.TabIndex = 3;
            this.btnCadastrarHabito.Text = "Cadastrar";
            this.btnCadastrarHabito.UseVisualStyleBackColor = true;
            this.btnCadastrarHabito.Click += new System.EventHandler(this.btnCadastrarHabito_Click);
            // 
            // FmrCadastrarHabito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrarHabito);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.lblCadastrarHabito);
            this.Controls.Add(this.txtCadastrarHabito);
            this.Name = "FmrCadastrarHabito";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadastrarHabito;
        private System.Windows.Forms.Label lblCadastrarHabito;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Button btnCadastrarHabito;
    }
}

