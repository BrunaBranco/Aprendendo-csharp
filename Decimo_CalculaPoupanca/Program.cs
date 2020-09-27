using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimo_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Calcula poupanca");
            double valorInvestido = 2000.0;
            int mes = 1;
            valorInvestido = valorInvestido * 0.0036;
            //Console.WriteLine("Após 1 mês você terá o valor de: " + valorInvestido + "R$");

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;

            //Console.WriteLine("Valor após 2 meses investido é de : " + valorInvestido + "R$");

            while (mes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Valor após " + mes + " meses investido é de R$ : " + valorInvestido );

                mes++;
            }

            Console.ReadLine();

        }
    }
}
