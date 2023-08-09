using System;
using System.Collections.Generic;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao lançador de dados!");
            
            Console.Write("Quantos dados você gostaria de lançar? ");
            int numDice = int.Parse(Console.ReadLine());

            List<int> results = RollDice(numDice);

            Console.WriteLine("Os resultados dos lançamentos são:");
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"Dado {i + 1}: {results[i]}");
            }
        }

        static List<int> RollDice(int numDice)
        {
            Console.WriteLine("digite o numero do dado");
            int numeroDado = int.Parse(Console.ReadLine());
            List<int> results = new List<int>();
            Random random = new Random();

            for (int i = 0; i < numDice; i++)
            {
                int result = random.Next(1, numeroDado++);
                results.Add(result);
            }

            return results;
        }
    }
}
