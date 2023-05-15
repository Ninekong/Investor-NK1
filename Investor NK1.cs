using System;
using System.Linq;

namespace InvestorShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the values of N and K (N K): ");
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];

            Console.WriteLine("Enter the population of each section of the road:");
            int[] populations = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxPopulation = MaxCustomers(populations, N, K);
            Console.WriteLine("The maximum possible number of population: " + maxPopulation);
        }

        static int MaxCustomers(int[] populations, int N, int K)
        {
            int maxPopulation = 0;

            for (int i = 0; i < N; i++)
            {
                int totalPopulation = 0;

                for (int j = Math.Max(0, i - K); j <= Math.Min(N - 1, i + K); j++)
                {
                    totalPopulation += populations[j];
                }

                maxPopulation = Math.Max(maxPopulation, totalPopulation);
            }

            return maxPopulation;
        }
    }
}
