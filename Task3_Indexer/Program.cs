using System;
using System.Collections.Generic;

namespace Task3_Indexer
{
    class IndexedBook
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>
        {
            ["Name"] = "",
            ["Type"] = "",
            ["Price"] = 0.0,
            ["PageCount"] = 0
        };

        // Індексатор для доступу до властивостей
        public object this[string key]
        {
            get
            {
                if (properties.ContainsKey(key)) return properties[key];
                throw new KeyNotFoundException($"Ключ '{key}' не знайдено");
            }
            set
            {
                if (properties.ContainsKey(key)) properties[key] = value;
                else throw new KeyNotFoundException($"Ключ '{key}' не знайдено");
            }
        }

        public void Print() => Console.WriteLine($"Назва: {this["Name"]}, Тип: {this["Type"]}, Ціна: {this["Price"]}, Кількість сторінок: {this["PageCount"]}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Індексація без базового масиву ===");
            Console.WriteLine("Час виконання: 12:14 PM CEST, 21.10.2025");
            try
            {
                var book = new IndexedBook();
                book["Name"] = "Advanced C#";
                book["Type"] = "Технічна";
                book["Price"] = 600.0;
                book["PageCount"] = 300;
                book.Print();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}