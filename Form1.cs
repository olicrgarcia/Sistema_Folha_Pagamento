using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeFolhaPagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            Calculos nvCalc = new Calculos();

            nvCalc.setNmFuncionario(txNome.Text);
            nvCalc.setBsSalario(double.Parse(txtSlBase.Text));

            nvCalc.descIrrf();

            txtSlLiq.Text = (nvCalc.getLiqSalario()).ToString();

            if (nvCalc.desSalario == 0)
            {

                lblDesconto.Text = $"Isento";
                
            }
            else {
                lblDesconto.Text = $"Desconto aplicado: R$ {(nvCalc.getDesSalario()).ToString()}";

            }
            

        }
    }
}
