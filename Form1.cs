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
            
            nvCalc.calcHorasExtras(int.Parse(txHoraMensal.Text), double.Parse(txVlHE.Text), int.Parse(txQtdHE.Text));
            nvCalc.calcDSR(int.Parse(txDiasTrab.Text), int.Parse(txDiasNTrab.Text));
            nvCalc.descIrrf();
            nvCalc.calcLiqSalario();

            lblBsSalario.Text = (nvCalc.getBsSalario()).ToString();
            lblHERecebe.Text = (nvCalc.getHorasExtras()).ToString();
            lblDsrRecebe.Text = (nvCalc.getDsrReceber()).ToString();
            lblLiqSalario.Text = (nvCalc.getLiqSalario()).ToString();

            if (nvCalc.desSalario == 0)
            {
                lblImpRenda.Text = $"Isento";
                
            }
            else {
                lblImpRenda.Text = $"R$ {(nvCalc.getDesSalario()).ToString()}";

            }

        }
    }
}
