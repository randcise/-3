using System;

namespace Task5_ThreeDOperator
{
    class ThreeD
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public ThreeD(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Перевизначення оператора +
        public static ThreeD operator +(ThreeD a, ThreeD b) => new ThreeD(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        public void Print() => Console.WriteLine($"({X}, {Y}, {Z})");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Перевизначення оператора + для ThreeD ===");
            Console.WriteLine("Час виконання: 12:14 PM CEST, 21.10.2025");
            try
            {
                var point1 = new ThreeD(1, 2, 3);
                var point2 = new ThreeD(4, 5, 6);
                var sum = point1 + point2;
                sum.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}