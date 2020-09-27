using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto_ConversoesEOutroTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceutando o Quarto projeto");

            double salario;
            salario = 2045.80;
            Console.WriteLine("Seu sálario é de: " + salario);

            int novoSalario;
            novoSalario = (int)salario + 400;
            Console.WriteLine("Seu novo sálario é de: " + novoSalario);

            long numeroNovo;
            numeroNovo = 130000000000000;
            Console.WriteLine("Numero: " + numeroNovo);

            short quantidadeProduto;
            quantidadeProduto = 50;
            Console.WriteLine("quantidade produto: " + quantidadeProduto );

            float altura;
            //o f indica que é float
            altura = 1.57f;
            Console.WriteLine("altura é: " + altura);

            Console.ReadLine();
        }
    }
}
