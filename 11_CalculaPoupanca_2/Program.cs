using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CalculaPoupanca_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Calcula poupanca");
            int mes;
            double valorInvestido = 2045.00;
            for (mes = 1; mes <= 12; mes++)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Valor após " + mes + " meses investido é de R$ : " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
