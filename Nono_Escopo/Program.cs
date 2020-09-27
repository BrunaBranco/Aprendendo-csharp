using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nono_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Setimo projeto - Condicionais");

            int idade = 17;
            int quantidade = 2;

            bool acompanhado = quantidade >= 2;
            string mensagem;

            if (acompanhado == true)
            {
                mensagem = "joao esta acompanhado";
            }
            else
            {
                mensagem = "Joao não esta acompanhado";
            }

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar na festa" + mensagem);
            }
            else
            {
                Console.WriteLine("Voce não pode entrar na festa: " + idade);
            }

            Console.ReadLine();
        }
    }
}
