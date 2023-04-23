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
            this.lblImpRenda = new System.Windows.Forms.Label();
            this.lblHE = new System.Windows.Forms.Label();
            this.txVlHE = new System.Windows.Forms.TextBox();
            this.txHoraMensal = new System.Windows.Forms.TextBox();
            this.lblHrsFunc = new System.Windows.Forms.Label();
            this.txQtdHE = new System.Windows.Forms.TextBox();
            this.lblHrsHE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBsSalario = new System.Windows.Forms.Label();
            this.lblHERecebe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLiqSalario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.bntOK.Location = new System.Drawing.Point(21, 486);
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
            this.lblSlLiq.Location = new System.Drawing.Point(18, 450);
            this.lblSlLiq.Name = "lblSlLiq";
            this.lblSlLiq.Size = new System.Drawing.Size(76, 13);
            this.lblSlLiq.TabIndex = 6;
            this.lblSlLiq.Text = "Salário Liquido";
            this.lblSlLiq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblImpRenda
            // 
            this.lblImpRenda.AutoSize = true;
            this.lblImpRenda.Location = new System.Drawing.Point(121, 419);
            this.lblImpRenda.Name = "lblImpRenda";
            this.lblImpRenda.Size = new System.Drawing.Size(10, 13);
            this.lblImpRenda.TabIndex = 7;
            this.lblImpRenda.Text = "-";
            this.lblImpRenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHE
            // 
            this.lblHE.AutoSize = true;
            this.lblHE.Location = new System.Drawing.Point(18, 183);
            this.lblHE.Name = "lblHE";
            this.lblHE.Size = new System.Drawing.Size(84, 13);
            this.lblHE.TabIndex = 10;
            this.lblHE.Text = "Horas Extras (%)";
            this.lblHE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txVlHE
            // 
            this.txVlHE.Location = new System.Drawing.Point(21, 199);
            this.txVlHE.Name = "txVlHE";
            this.txVlHE.Size = new System.Drawing.Size(204, 20);
            this.txVlHE.TabIndex = 11;
            // 
            // txHoraMensal
            // 
            this.txHoraMensal.Location = new System.Drawing.Point(21, 144);
            this.txHoraMensal.Name = "txHoraMensal";
            this.txHoraMensal.Size = new System.Drawing.Size(204, 20);
            this.txHoraMensal.TabIndex = 13;
            // 
            // lblHrsFunc
            // 
            this.lblHrsFunc.AutoSize = true;
            this.lblHrsFunc.Location = new System.Drawing.Point(18, 128);
            this.lblHrsFunc.Name = "lblHrsFunc";
            this.lblHrsFunc.Size = new System.Drawing.Size(77, 13);
            this.lblHrsFunc.TabIndex = 12;
            this.lblHrsFunc.Text = "Horas Mensais";
            this.lblHrsFunc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txQtdHE
            // 
            this.txQtdHE.Location = new System.Drawing.Point(21, 255);
            this.txQtdHE.Name = "txQtdHE";
            this.txQtdHE.Size = new System.Drawing.Size(204, 20);
            this.txQtdHE.TabIndex = 15;
            // 
            // lblHrsHE
            // 
            this.lblHrsHE.AutoSize = true;
            this.lblHrsHE.Location = new System.Drawing.Point(18, 239);
            this.lblHrsHE.Name = "lblHrsHE";
            this.lblHrsHE.Size = new System.Drawing.Size(90, 13);
            this.lblHrsHE.TabIndex = 14;
            this.lblHrsHE.Text = "Qtd. Horas Extras";
            this.lblHrsHE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resumo do Holerite";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Salário Base:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBsSalario
            // 
            this.lblBsSalario.AutoSize = true;
            this.lblBsSalario.Location = new System.Drawing.Point(93, 361);
            this.lblBsSalario.Name = "lblBsSalario";
            this.lblBsSalario.Size = new System.Drawing.Size(10, 13);
            this.lblBsSalario.TabIndex = 18;
            this.lblBsSalario.Text = "-";
            this.lblBsSalario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHERecebe
            // 
            this.lblHERecebe.AutoSize = true;
            this.lblHERecebe.Location = new System.Drawing.Point(102, 389);
            this.lblHERecebe.Name = "lblHERecebe";
            this.lblHERecebe.Size = new System.Drawing.Size(10, 13);
            this.lblHERecebe.TabIndex = 20;
            this.lblHERecebe.Text = "-";
            this.lblHERecebe.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "HE a Receber:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLiqSalario
            // 
            this.lblLiqSalario.AutoSize = true;
            this.lblLiqSalario.Location = new System.Drawing.Point(100, 450);
            this.lblLiqSalario.Name = "lblLiqSalario";
            this.lblLiqSalario.Size = new System.Drawing.Size(10, 13);
            this.lblLiqSalario.TabIndex = 21;
            this.lblLiqSalario.Text = "-";
            this.lblLiqSalario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 419);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Imposto de Renda:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLiqSalario);
            this.Controls.Add(this.lblHERecebe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBsSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txQtdHE);
            this.Controls.Add(this.lblHrsHE);
            this.Controls.Add(this.txHoraMensal);
            this.Controls.Add(this.lblHrsFunc);
            this.Controls.Add(this.txVlHE);
            this.Controls.Add(this.lblHE);
            this.Controls.Add(this.lblImpRenda);
            this.Controls.Add(this.lblSlLiq);
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
        private System.Windows.Forms.Label lblImpRenda;
        private System.Windows.Forms.Label lblHE;
        private System.Windows.Forms.TextBox txVlHE;
        private System.Windows.Forms.TextBox txHoraMensal;
        private System.Windows.Forms.Label lblHrsFunc;
        private System.Windows.Forms.TextBox txQtdHE;
        private System.Windows.Forms.Label lblHrsHE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBsSalario;
        private System.Windows.Forms.Label lblHERecebe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLiqSalario;
        private System.Windows.Forms.Label label7;
    }
}

