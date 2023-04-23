using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exeFolhaPagamento
{
    internal class Calculos
    {
        //Criando os atributos
        public double bsSalario { get; set; }
        public double liqSalario { get; set; }
        public double desSalario { get; set; }
        public double horasExtras { get; set; }
        public double dsrReceber {get; set; }
        string nmFuncionario { get; set; }


        public Calculos()
        {

        }

        public Calculos(double bssalario, double liqsalario,
            double dessalario, string nmfuncionario, 
            double horasextras, double dsrreceber)
        {

            bsSalario = bssalario;
            liqSalario = liqsalario;
            desSalario = dessalario;
            nmFuncionario = nmfuncionario;
            horasExtras = horasextras;
            dsrReceber = dsrreceber;

        }

        //Declarando os atributos

        public void setBsSalario(double bssalario)
        {
            this.bsSalario = bssalario;
        }

        public void setLiqSalario(double liqsalario)
        {
            this.liqSalario = liqsalario;
        }

        public void setDesSalario(double dessalario)
        {
            this.desSalario = dessalario;
        }
        public void setNmFuncionario(string nmfuncionario)
        {
            this.nmFuncionario = nmfuncionario;
        }
        public void setHorasExtras(double horasextras)
        {
            this.horasExtras = horasextras;
        }
        public void setDsrReceber(double dsrreceber) {
            this.dsrReceber = dsrreceber;
        }


        public string getNmFuncionario()
        {
            return this.nmFuncionario;
        }

        public double getBsSalario()
        {
            return this.bsSalario;
        }

        public double getLiqSalario()
        {
            return this.liqSalario;
        }

        public double getDesSalario()
        {
            return this.desSalario;
        }

        public double getHorasExtras()
        {
            return this.horasExtras;
        }
        public double getDsrReceber()
        {
            return this.dsrReceber;
        }

        //Cálculos para Folha de Pagamento


        public void calcLiqSalario() {
            liqSalario = (bsSalario - desSalario) + horasExtras + dsrReceber;
        
        }
        public void calcHorasExtras(int horasMensais, double percHExtra, int qtdHExtra) {

            double vlHoraNormal = bsSalario / horasMensais;
            double vlHoraExtra = vlHoraNormal + (vlHoraNormal * percHExtra / 100);
            horasExtras = Math.Round(vlHoraExtra * qtdHExtra,2);
            
        }

        public void calcDSR(int diasTrab, int diasNTrab)
        {
            dsrReceber = Math.Round((horasExtras / diasTrab) * diasNTrab, 2);

        }

        public void descIrrf()
        {

            switch (bsSalario)
            {

                case double bsSalario when (bsSalario <= 1908.98):
                    desSalario = 0;
                    break;

                case double bsSalario when (bsSalario > 1908.98 && bsSalario <= 2826.65):

                    desSalario = Math.Round((bsSalario * 7.5 / 100) - 142.8, 2);
                    break;

                case double bsSalario when (bsSalario > 2826.65 && bsSalario <= 3751.05):

                    desSalario = Math.Round((bsSalario * 15 / 100) - 354.8, 2);
                    break;

                case double bsSalario when (bsSalario > 3751.05 && bsSalario <= 4664.68):

                    desSalario = Math.Round((bsSalario * 22.5 / 100) - 636.13, 2);
                    break;

                case double bsSalario when (bsSalario > 4664.68):

                    desSalario = Math.Round((bsSalario * 27.5 / 100) - 869.36, 2);
                    break;

            }

            



        }


    }
}
