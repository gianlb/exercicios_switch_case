using System;

namespace CategoriaDeFilme
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a classificação etária do filme (G, PG, PG-13, R):");
            string classificacao = Console.ReadLine()?.ToUpper(); 

            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Faixa etária: Livre para todos os públicos.");
                    break;

                case "PG":
                    Console.WriteLine("Faixa etária: Recomendado para maiores de 10 anos.");
                    break;

                case "PG-13":
                    Console.WriteLine("Faixa etária: Recomendado para maiores de 13 anos.");
                    break;

                case "R":
                    Console.WriteLine("Faixa etária: Permitido apenas para maiores de 18 anos.");
                    break;

                default:
                    Console.WriteLine("Classificação inválida. Use G, PG, PG-13 ou R.");
                    break;
            }
        }
    }
}
