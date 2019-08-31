using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("NOTA: Para Crédito Direto, Digite 1, " +
            //    "para Credito consignado, digite 2, " +
            //    "para crédito pessoa jurídica, digite 3," +
            //    "para crédito pessoa fisica, digite 4, " +
            //    "para crédito Imobiliário, digite 5");
            Console.WriteLine("NOTA: Para preenchimento do campo Tipo do credito, siga as instruçoes abaixo");
            Console.WriteLine("Para Crédito Direto, Digite 1");
            Console.WriteLine("para Credito consignado, digite 2");
            Console.WriteLine("para crédito pessoa jurídica, digite 3");
            Console.WriteLine("para crédito pessoa fisica, digite 4");
            Console.WriteLine("para crédito Imobiliário, digite 5");

            Console.WriteLine("informe o tipo de crédito que deseja");
            int tc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe o valor que deseja");
            decimal vl = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("informe o numero de parcelas");
            int qp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a data de vencimento da primeira parcela");
            DateTime dp = Convert.ToDateTime(Console.ReadLine());
           


            Credito cred = new Credito();
            var retorno = cred.ValidarCredito(vl, tc, qp, dp);
            Console.WriteLine(retorno);
            Console.ReadKey();
        }
    }
}
