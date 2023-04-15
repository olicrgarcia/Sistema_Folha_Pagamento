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
            this.txInput = new System.Windows.Forms.TextBox();
            this.bntOK = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txInput
            // 
            this.txInput.Location = new System.Drawing.Point(199, 70);
            this.txInput.Name = "txInput";
            this.txInput.Size = new System.Drawing.Size(204, 20);
            this.txInput.TabIndex = 0;
            this.txInput.TextChanged += new System.EventHandler(this.txInput_TextChanged);
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(199, 114);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(75, 23);
            this.bntOK.TabIndex = 1;
            this.bntOK.Text = "OK";
            this.bntOK.UseVisualStyleBackColor = true;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(305, 119);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(55, 13);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.bntOK);
            this.Controls.Add(this.txInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txInput;
        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Label lblRes;
    }
}

