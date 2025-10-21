using System;

namespace Task4_StudentIndexer
{
    class Student
    {
        private int[] grades = new int[10];

        // Індексатор для доступу до оцінок
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < 10) return grades[index];
                throw new IndexOutOfRangeException("Індекс поза межами 0-9");
            }
            set
            {
                if (index >= 0 && index < 10) grades[index] = value;
                else throw new IndexOutOfRangeException("Індекс поза межами 0-9");
            }
        }

        public void PrintGrades() => Console.WriteLine("Оцінки: " + string.Join(" ", grades));
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Клас Student з індексацією масиву оцінок ===");
            Console.WriteLine("Час виконання: 12:14 PM CEST, 21.10.2025");
            try
            {
                var student = new Student();
                for (int i = 0; i < 10; i++) student[i] = 80 + i;
                student.PrintGrades();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}