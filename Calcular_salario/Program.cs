using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            int CODIGO, NUMERO ;
            Console.WriteLine("DIGITE CODIGO DA ROUPA: ");
            CODIGO = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE QUANTAS ROUPAS SÃO: ");
            NUMERO = int.Parse(Console.ReadLine());
            
            Console.WriteLine("DIGITE O VALOR UNITARIO:");
            double VALOR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagamento = VALOR * NUMERO;
            Console.WriteLine("VALOR:" + pagamento.ToString("F2", CultureInfo.InvariantCulture));
            int CODIGO2, NUMERO2;
            Console.WriteLine("DIGITE CODIGO DA ROUPA: ");
            CODIGO2 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE QUANTAS ROUPAS SÃO: ");
            NUMERO2 = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O VALOR UNITARIO:");
            double VALOR2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double pagamento2 = VALOR2 * NUMERO2;


            double pagamentoFinal = pagamento + pagamento2;
            Console.WriteLine("VALOR A PAGAR:" + pagamentoFinal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("CODIGO DA ROUPA:" + CODIGO);
            Console.Write("CODIGO DA ROUPA:" + CODIGO2);

        }

    }
}