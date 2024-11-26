using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Switch_Case
{
    internal class Exercicio2
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite um numero ");
            int numero = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite um número (+, -, *, /): ");
            char operador = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt16(Console.ReadLine());
            int resultado;
            switch (operador)
            {
                case '+':
                    resultado = numero + numero2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case '-':
                    resultado = numero - numero2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case '*':
                    resultado = numero * numero2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case '/':
                    if (numero2 != 0)
                    {
                        resultado = numero / numero2;
                        Console.WriteLine($"Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Erro! Divisão por zero não é permitida.");
                    }
                    break;


                default:
                    Console.WriteLine("Operador inválido! Por favor, use +, -, * ou /.");
                    break;

            }





        }
    }

}

