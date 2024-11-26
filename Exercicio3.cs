using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Switch_Case
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            switch (idade)
            {
                case <= 12:
                    Console.WriteLine("Criança (0-12 anos)");
                    break;
                case >= 13 and <= 17:
                    Console.WriteLine("Adolescente (13-17 anos)");
                    break;
                case >= 18 and <= 59:
                    Console.WriteLine("Adulto (18-59 anos)");
                    break;
                default:
                    Console.WriteLine("Idoso (60 anos ou mais)");
                    break;
            }
        }
    }
}

