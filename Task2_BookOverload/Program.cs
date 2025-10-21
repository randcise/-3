using System;

namespace Task2_BookOverload
{
    class BookPublication
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        // Перевизначені методи для відображення інформації
        public void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Name ?? "Невідомо"}, Тип: {Type ?? "Невідомо"}, Ціна: {Price}, Кількість: {Stock}");
        }

        public void DisplayInfo(bool shortFormat)
        {
            if (shortFormat)
            {
                Console.WriteLine($"Книга: {Name ?? "Невідомо"}, Ціна: {Price}");
            }
            else
            {
                DisplayInfo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Клас Друкарське Видання з перевизначеними методами ===");
            Console.WriteLine("Час виконання: 12:17 PM CEST, 21.10.2025");
            try
            {
                var book = new BookPublication
                {
                    Name = "C# Basics",
                    Type = "Навчальна",
                    Price = 500.0,
                    Stock = 10
                };
                book.DisplayInfo();
                Console.WriteLine();
                book.DisplayInfo(true);
                Console.WriteLine();
                book.DisplayInfo(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}