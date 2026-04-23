using System;
using System.Text;

namespace CCCLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування для коректного відображення української мови
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   ЛАБОРАТОРНА РОБОТА №1 | ВАРІАНТ 8   ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Завдання 1.8: Периметр трикутника (Виправлено)");
                Console.WriteLine("2. Завдання 2.8: Перевірка цифр числа");
                Console.WriteLine("3. Завдання 3.8: Точка в області");
                Console.WriteLine("4. Завдання 4.8: Місяць m місяців тому (Виправлено)");
                Console.WriteLine("5. Завдання 5.8: Функція частки");
                Console.WriteLine("6. Завдання 6.8: Обчислення виразу");
                Console.WriteLine("0. Вихід");
                Console.WriteLine("----------------------------------------");
                Console.Write("Оберіть номер завдання: ");

                string? choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1": Task1(); break;
                        case "2": Task2(); break;
                        case "3": Task3(); break;
                        case "4": Task4(); break;
                        case "5": Task5(); break;
                        case "6": Task6(); break;
                        case "0": return;
                        default: Console.WriteLine("Невірний вибір!"); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }

                Console.WriteLine("\nНатисніть Enter, щоб повернутися до меню...");
                Console.ReadLine();
            }
        }

        // --- ВИПРАВЛЕНЕ ЗАВДАННЯ 1.8 ---
        static void Task1()
        {
            Console.WriteLine("\n>>> Завдання 1.8: Периметр прямокутного трикутника");
            Console.Write("Введіть катет a: ");
            double a = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введіть катет b: ");
            double b = double.Parse(Console.ReadLine() ?? "0");

            double c = Math.Sqrt(a * a + b * b);
            double perimeter = a + b + c;

            Console.WriteLine($"Результати:");
            Console.WriteLine($"- Гіпотенуза (c): {c:F2}");
            Console.WriteLine($"- Периметр (P):   {perimeter:F2}");
        }

        static void Task2()
        {
            Console.WriteLine("\n>>> Завдання 2.8");
            Console.Write("Двозначне число: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            int absN = Math.Abs(n);
            if (absN >= 10 && absN <= 99)
                Console.WriteLine(absN / 10 == absN % 10 ? "Результат: Цифри однакові" : "Результат: Цифри різні");
            else Console.WriteLine("Помилка: Це не двозначне число!");
        }

        static void Task3()
        {
            Console.WriteLine("\n>>> Завдання 3.8");
            Console.Write("x: "); double x = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("y: "); double y = double.Parse(Console.ReadLine() ?? "0");
            double d2 = x * x + y * y;
            // Права частина кільця (x>=0) між радіусами 3 та 7
            Console.WriteLine(x >= 0 && d2 >= 9 && d2 <= 49 ? "Результат: В області" : "Результат: Поза областю");
        }

        // --- ВИПРАВЛЕНЕ ЗАВДАННЯ 4.8 ---
        static void Task4()
        {
            Console.WriteLine("\n>>> Завдання 4.8: Місяць m місяців тому");
            Console.Write("Введіть кількість місяців m: ");
            
            if (int.TryParse(Console.ReadLine(), out int m))
            {
                // Отримуємо поточний місяць
                int currentMonth = DateTime.Now.Month; 

                // Формула: переводимо місяці в індекси 0-11, 
                // віднімаємо m (з урахуванням циклічності через % 12), 
                // додаємо 12, щоб не було мінуса, і повертаємо до формату 1-12.
                int monthIndex = (currentMonth - 1 - (m % 12) + 12) % 12;
                int targetMonth = monthIndex + 1;

                // Використовуємо культуру для назви місяця (українська)
                var culture = new System.Globalization.CultureInfo("uk-UA");
                string monthName = culture.DateTimeFormat.GetMonthName(targetMonth);

                Console.WriteLine($"Поточний місяць: {currentMonth} ({culture.DateTimeFormat.GetMonthName(currentMonth)})");
                Console.WriteLine($"Результат: {m} місяців тому був {targetMonth}-й місяць ({monthName})");
            }
            else Console.WriteLine("Помилка: Введіть ціле число.");
        }

        static void Task5()
        {
            Console.WriteLine("\n>>> Завдання 5.8: Частка чисел");
            Console.Write("Число a: "); double a = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Число b: "); double b = double.Parse(Console.ReadLine() ?? "0");

            if (b != 0)
                Console.WriteLine($"Результат ділення a/b = {a / b:F4}");
            else
                Console.WriteLine("Помилка: Ділення на нуль!");
        }

        static void Task6()
        {
            Console.WriteLine("\n>>> Завдання 6.8: Обчислення виразу");
            Console.Write("Введіть a: "); double a = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Введіть b: "); double b = double.Parse(Console.ReadLine() ?? "0");

            double result = (a / (a * a + 1)) + (b / (b * b + 1));

            Console.WriteLine($"Результат: {result:F6}");
        }
    }
}
