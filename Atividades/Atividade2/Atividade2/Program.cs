using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("**********Calculadora**********");

            double valor1 = 0, valor2 = 0, resultado, numero;
            string operador, valorDigitado;
            bool isNumeroInteiro;
            Console.WriteLine("Digite o 1º valor:  ");
            valorDigitado = Console.ReadLine();
            if(isNumeroInteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 4);
            }
            else
            {
                Console.WriteLine("Digite um numero válido");
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}