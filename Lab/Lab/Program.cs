using System;
using System.Text;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Налаштування кодування для підтримки українських символів
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Програму створила: Щеголь A.A");
            Console.WriteLine("Група: 42ІПЗ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Геометричний калькулятор");
            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("1. Обчислити площу паралелограма");
            Console.WriteLine("2. Обчислити площу трикутника за формулою Герона");
            Console.WriteLine("3. Обчислити площу бічної поверхні піраміди");
            Console.WriteLine("4. Обчислити об'єм піраміди");
            Console.WriteLine("5. Обчислити об'єм сфери");
            Console.Write("Ваш вибір (1-5): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.Write("Будь ласка, введіть число від 1 до 5: ");
            }

            switch (choice)
            {
                case 1:
                    CalculateParallelogramArea();
                    break;
                case 2:
                    CalculateTriangleArea();
                    break;
                case 3:
                    CalculatePyramidLateralArea();
                    break;
                case 4:
                    CalculatePyramidVolume();
                    break;
                case 5:
                    CalculateSphereVolume();
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }

        static void CalculateParallelogramArea()
        {
            Console.WriteLine("\nОбчислення площі паралелограма");
            Console.Write("Введіть довжину сторони: ");
            double side = GetPositiveNumber();
            Console.Write("Введіть висоту, проведену до цієї сторони: ");
            double height = GetPositiveNumber();

            double area = side * height;
            Console.WriteLine($"Площа паралелограма: {area:F2}");
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("\nОбчислення площі трикутника за формулою Герона");
            Console.Write("Введіть довжину першої сторони: ");
            double a = GetPositiveNumber();
            Console.Write("Введіть довжину другої сторони: ");
            double b = GetPositiveNumber();
            Console.Write("Введіть довжину третьої сторони: ");
            double c = GetPositiveNumber();

            // Перевірка на існування трикутника
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Трикутник з такими сторонами не існує!");
                return;
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площа трикутника: {area:F2}");
        }

        static void CalculatePyramidLateralArea()
        {
            Console.WriteLine("\nОбчислення площі бічної поверхні піраміди");
            Console.Write("Введіть периметр основи піраміди: ");
            double perimeter = GetPositiveNumber();
            Console.Write("Введіть апофему піраміди: ");
            double apothem = GetPositiveNumber();

            double lateralArea = 0.5 * perimeter * apothem;
            Console.WriteLine($"Площа бічної поверхні піраміди: {lateralArea:F2}");
        }

        static void CalculatePyramidVolume()
        {
            Console.WriteLine("\nОбчислення об'єму піраміди");
            Console.Write("Введіть площу основи піраміди: ");
            double baseArea = GetPositiveNumber();
            Console.Write("Введіть висоту піраміди: ");
            double height = GetPositiveNumber();

            double volume = (baseArea * height) / 3;
            Console.WriteLine($"Об'єм піраміди: {volume:F2}");
        }

        static void CalculateSphereVolume()
        {
            Console.WriteLine("\nОбчислення об'єму сфери");
            Console.Write("Введіть радіус сфери: ");
            double radius = GetPositiveNumber();

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            Console.WriteLine($"Об'єм сфери: {volume:F2}");
        }

        static double GetPositiveNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.Write("Будь ласка, введіть додатне число: ");
            }
            return number;
        }
    }
}