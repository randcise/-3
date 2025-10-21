using System;
using System.Linq; // Необхідно для методу Max()

namespace Task1_Lecture4
{
    class Program
    {
        // Перевизначення методу Max для різних типів і кількості аргументів
        static int Max(int a, int b) => a > b ? a : b;
        static int Max(int a, int b, int c) => Max(Max(a, b), c);
        static double Max(double a, double b) => a > b ? a : b;
        static int Max(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) throw new ArgumentException("Масив не може бути порожнім або null");
            return numbers.Max();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Перевизначення методів Max (з лекції 4) ===");
            Console.WriteLine("Час виконання: 12:14 PM CEST, 21.10.2025");
            try
            {
                Console.WriteLine("Max(5, 10) = " + Max(5, 10));
                Console.WriteLine("Max(5, 10, 15) = " + Max(5, 10, 15));
                Console.WriteLine("Max(3.5, 2.7) = " + Max(3.5, 2.7));
                Console.WriteLine("Max(1, 2, 3, 4) = " + Max(1, 2, 3, 4));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}