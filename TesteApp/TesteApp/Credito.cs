using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApp
{
    public class Credito : ICredito
    {
        public decimal TaxaJuros { get; set; }


        public Credito()
        {

        }

        public string ValidarCredito(decimal ValorCredito, int TipoCredito, int QtParcelas, DateTime DataParcela)
        {

            string retorno = "";
            if (TipoCredito == 1 || TipoCredito == 2 || TipoCredito == 4 || TipoCredito == 5)
            {
                var vrm = ValidarValorMaximo(ValorCredito);
                var vp = ValidarParcelas(QtParcelas);
                var vdt = validarDataVencimento(DataParcela);
                var cal = CalculaJuros(TipoCredito, ValorCredito);
                var valorJuros = cal - ValorCredito;

                if (vrm == true && vp == true && vdt == true)
                {
                    retorno = "Emprestimo APROVADO, o valor total com juros é " + cal + ", o valor do juros é " + valorJuros;
                }
                else
                {
                    retorno = "Emprestimo REPROVADO, o valor total com juros é " + cal + ", o valor do juros é " + valorJuros;

                }
            }

            if (TipoCredito == 3)
            {
                var vrm = ValidarValorMaximo(ValorCredito);
                var vp = ValidarParcelas(QtParcelas);
                var vdt = validarDataVencimento(DataParcela);
                var vpj = ValidarCreditoMinimoPJ(ValorCredito);
                var cal = CalculaJuros(TipoCredito, ValorCredito);
                var valorJuros = cal - ValorCredito;

                if (vrm == true && vp == true && vdt == true && vpj == true)
                {
                    retorno = "Emprestimo APROVADO, o valor total com juros é " + cal + ", o valor do juros é " + valorJuros;
                }
                else
                {
                    retorno = "Emprestimo REPROVADO, o valor total com juros é " + cal + ", o valor do juros é " + valorJuros;

                }
            }


            return retorno;
        }
        public bool ValidarValorMaximo(decimal vl)
        {
            int vlMaximo = 100000000;
            bool flag = false;

            if (vl <= vlMaximo)
                flag = true;

            return flag;
        }

        public bool ValidarParcelas(int QtdParcela)
        {
            bool flag = false;

            if (QtdParcela >= 5 && QtdParcela <= 72)
                flag = true;

            return flag;
        }

        public bool ValidarCreditoMinimoPJ(decimal vl)
        {
            bool flag = true;

            if (vl < 15000)
            {
                flag = false;
            }
            return flag;
        }

        public bool validarDataVencimento(DateTime dv)
        {
            bool flag = true;

            if (dv.Equals(DateTime.Now.Day + DateTime.Now.Day > 15))
            {
                flag = false;
            }
            else
            {
                dv.Day.Equals(DateTime.Now.Day + DateTime.Now.Day < 40);
                flag = false;
            }
            return flag;

        }


        public decimal CalculaJuros(int tc, decimal vl)
        {
            decimal resultado = 1;
            decimal resultadoFinal = 1;

            if (tc == 1)
            {
                resultado = ((decimal)vl) * ((decimal)0.02);
                resultadoFinal = vl + resultado;
            }

            if (tc == 2)
            {
                resultado = ((decimal)vl) * ((decimal)0.01);
                resultadoFinal = vl + resultado;
            }

            if (tc == 3)
            {
                resultado = ((decimal)vl) * ((decimal)0.05);
                resultadoFinal = vl + resultado;
            }
            if (tc == 4)
            {
                resultado = ((decimal)vl) * ((decimal)0.03);
                resultadoFinal = vl + resultado;
            }
            if (tc == 5)
            {
                resultado = ((decimal)vl) * ((decimal)0.09);
                resultadoFinal = vl + resultado;
            }

            return resultadoFinal;
        }

    }

}
