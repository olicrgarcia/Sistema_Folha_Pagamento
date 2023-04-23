namespace exeFolhaPagamento
{
    partial class Form1
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
            this.txNome = new System.Windows.Forms.TextBox();
            this.bntOK = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSlBase = new System.Windows.Forms.Label();
            this.txtSlBase = new System.Windows.Forms.TextBox();
            this.lblSlLiq = new System.Windows.Forms.Label();
            this.txtSlLiq = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(21, 36);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(204, 20);
            this.txNome.TabIndex = 0;
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(21, 205);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(75, 23);
            this.bntOK.TabIndex = 1;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(108, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Funcionário";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSlBase
            // 
            this.lblSlBase.AutoSize = true;
            this.lblSlBase.Location = new System.Drawing.Point(18, 74);
            this.lblSlBase.Name = "lblSlBase";
            this.lblSlBase.Size = new System.Drawing.Size(66, 13);
            this.lblSlBase.TabIndex = 4;
            this.lblSlBase.Text = "Salário Base";
            this.lblSlBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSlBase
            // 
            this.txtSlBase.Location = new System.Drawing.Point(21, 90);
            this.txtSlBase.Name = "txtSlBase";
            this.txtSlBase.Size = new System.Drawing.Size(204, 20);
            this.txtSlBase.TabIndex = 3;
            // 
            // lblSlLiq
            // 
            this.lblSlLiq.AutoSize = true;
            this.lblSlLiq.Location = new System.Drawing.Point(18, 135);
            this.lblSlLiq.Name = "lblSlLiq";
            this.lblSlLiq.Size = new System.Drawing.Size(76, 13);
            this.lblSlLiq.TabIndex = 6;
            this.lblSlLiq.Text = "Salário Liquido";
            this.lblSlLiq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSlLiq
            // 
            this.txtSlLiq.Location = new System.Drawing.Point(21, 151);
            this.txtSlLiq.Name = "txtSlLiq";
            this.txtSlLiq.Size = new System.Drawing.Size(204, 20);
            this.txtSlLiq.TabIndex = 5;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(231, 154);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(0, 13);
            this.lblDesconto.TabIndex = 7;
            this.lblDesconto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 270);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblSlLiq);
            this.Controls.Add(this.txtSlLiq);
            this.Controls.Add(this.lblSlBase);
            this.Controls.Add(this.txtSlBase);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.txNome);
            this.Name = "Form1";
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSlBase;
        private System.Windows.Forms.TextBox txtSlBase;
        private System.Windows.Forms.Label lblSlLiq;
        private System.Windows.Forms.TextBox txtSlLiq;
        private System.Windows.Forms.Label lblDesconto;
    }
}

