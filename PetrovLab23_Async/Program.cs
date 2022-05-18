using System;
using System.Threading.Tasks;

namespace PetrovLab23_Async
{
	// Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода
	class Program
	{
		static async Task Main(string[] args)
		{
            Console.WriteLine("Введите число:");
            int n = int.Parse(Console.ReadLine());

            Task<int> factorialTask = FactorialAsync(n);
            Console.WriteLine($"Факториал числа: ");
            int factorial = await factorialTask;
            Console.Write($"{factorial}");
            
            Console.ReadKey();
		}

        static int Factorial(int n)
        {
            int result = 1;
            for(int i = 1; i <= n; i++)
                result *= i;
            System.Threading.Thread.Sleep(2000);
            return result;
        }

        // определение асинхронного метода
        static async Task<int> FactorialAsync(int n)
        {
            return await Task.Run(() => Factorial(n)); // выполняется асинхронно
        }
	}
}
