using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeFolhaPagamento
{
    internal class Calculos
    {

        public double bsSalario { get; set; }
        public double liqSalario { get; set; }
        public double desSalario { get; set; }
        string nmFuncionario { get; set; }


        public Calculos ()
        {
            
        }

        public Calculos(double bssalario, double liqsalario, double dessalario, string nmfuncionario) { 
        
            bsSalario = bssalario;
            liqSalario = liqsalario;
            desSalario = dessalario;
            nmFuncionario = nmfuncionario;
        
        }

        public void setBsSalario(double bssalario) { 
            this.bsSalario = bssalario;
        }

        public void setLiqSalario(double liqsalario) { 
            this.liqSalario = liqsalario;
        }

        public void setDesSalario(double dessalario) {
            this.desSalario = dessalario;
        }
        public void setNmFuncionario(string nmfuncionario)
        {
            this.nmFuncionario = nmfuncionario;
        }

        public string getNmFuncionario() { 
            return this.nmFuncionario;
        }

        public double getBsSalario()
        {
            return this.bsSalario;
        }

        public double getLiqSalario() {
            return this.liqSalario;
        }

        public double getDesSalario() {
            return this.desSalario;
        }

        public void descIrrf() {
            if (bsSalario >= 1908.98)
            {
                desSalario = Math.Round((bsSalario * 7.5 / 100) - 142.52, 2);
                liqSalario = Math.Round(bsSalario - desSalario, 2);

            }
            else {

                liqSalario = bsSalario;
            }
            
        
        }





    }
}
