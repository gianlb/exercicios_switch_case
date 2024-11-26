using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Switch_Case
{
    internal class Exercicio8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número da conversão deseja:");
            Console.WriteLine("1 - Fahrenheit ");
            Console.WriteLine("2 - Celsius");
            int temperatura = Convert.ToInt16(Console.ReadLine());

            switch (temperatura)
            {
                case 1:
                    Console.WriteLine("Informe o valor da temperatura em Celsius que deseja converter para Fahrenheit: ");
                    float valor = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("A temperatura em Fahrenheit é de: " + (valor * (9.0f / 5.0f) + 32) + " Fahrenheit");
                    break;

                case 2:
                    Console.WriteLine("Informe o valor da temperatura em Fahrenheit que deseja converter para Celsius: ");
                    float valor2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("A temperatura em Celsius é de: " + ((valor2 - 32) * (5.0f / 9.0f)) + " Celsius");
                    break;

                default:
                    Console.WriteLine("Opção invalida.");
                    break;
            }
        }
    }
}

