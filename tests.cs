using System;

namespace CCCLab1
{
    class Tests
    {
        public static void RunTest()
        {
            double a = 3;
            double b = 4;

            double expected = 12;

            double actual = Program.CalculatePerimeter(a, b);

            if (actual == expected)
            {
                Console.WriteLine("Тест пройдено успішно");
            }
            else
            {
                Console.WriteLine("Тест НЕ пройдено");
                Console.WriteLine($"Очікувалось: {expected}");
                Console.WriteLine($"Отримано: {actual}");
            }
        }
    }
}
