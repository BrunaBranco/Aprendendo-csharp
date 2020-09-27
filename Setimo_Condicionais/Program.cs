using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setimo_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setimo projeto - Condicionais");

            int idade = 17;
            int quantidade = 2;

            if (idade >= 18)
            {
                Console.WriteLine("Você já pode tirar sua CNH");
            }
            else
            {
                if (quantidade >= 2)
                {
                    Console.WriteLine("Você esta acompanhado por " + quantidade + " pessoas");
                }
                else
                {
                    Console.WriteLine("Sua idade é: " + idade);
                }               
            }

            Console.ReadLine();
        }
    }
}
