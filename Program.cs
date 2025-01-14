using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вітаємо у програмі створення текстового звіту!");

            // Створюємо StringBuilder для зберігання звіту
            StringBuilder report = new StringBuilder();

            // Додаємо заголовок
            report.AppendLine("Текстовий звіт");
            report.AppendLine($"Дата створення: {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}");
            report.AppendLine(new string('-', 30));
            report.AppendLine("Список подій:");

            // Цикл для введення подій
            while (true)
            {
                Console.WriteLine("Введіть подію (або введіть 'завершити', щоб закінчити):");
                string input = Console.ReadLine();

                // Перевірка на вихід
                if (input.Equals("завершити", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(input))
                {
                    // Додаємо подію до звіту
                    report.AppendLine($"- {input}");
                }
                else
                {
                    Console.WriteLine("Подія не може бути порожньою. Спробуйте ще раз.");
                }
            }

            // Виводимо звіт
            report.AppendLine(new string('-', 30));
            Console.WriteLine("\nВаш звіт:\n");
            Console.WriteLine(report.ToString());

            // Опціонально: збереження звіту у файл
            Console.WriteLine("Чи бажаєте зберегти звіт у файл? (так/ні):");
            string saveOption = Console.ReadLine();
            if (saveOption.Equals("так", StringComparison.OrdinalIgnoreCase))
            {
                try
                {
                    System.IO.File.WriteAllText("TextReport.txt", report.ToString());
                    Console.WriteLine("Звіт успішно збережено у файл 'TextReport.txt'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка при збереженні файлу: {ex.Message}");
                }
            }

            Console.WriteLine("Дякуємо за використання програми!");
            Console.ReadLine();
        }
    }
}
