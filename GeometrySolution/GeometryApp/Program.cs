using System;
using System.Text;
using GeometryLibrary;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
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

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть довжину сторони: ");
                        double side = GetPositiveNumber();
                        Console.Write("Введіть висоту: ");
                        double height = GetPositiveNumber();
                        Console.WriteLine($"Площа паралелограма: {GeometryCalculator.CalculateParallelogramArea(side, height):F2}");
                        break;

                    case 2:
                        Console.Write("Введіть довжину першої сторони: ");
                        double a = GetPositiveNumber();
                        Console.Write("Введіть довжину другої сторони: ");
                        double b = GetPositiveNumber();
                        Console.Write("Введіть довжину третьої сторони: ");
                        double c = GetPositiveNumber();
                        Console.WriteLine($"Площа трикутника: {GeometryCalculator.CalculateTriangleArea(a, b, c):F2}");
                        break;

                    case 3:
                        Console.Write("Введіть периметр основи: ");
                        double perimeter = GetPositiveNumber();
                        Console.Write("Введіть апофему: ");
                        double apothem = GetPositiveNumber();
                        Console.WriteLine($"Площа бічної поверхні піраміди: {GeometryCalculator.CalculatePyramidLateralArea(perimeter, apothem):F2}");
                        break;

                    case 4:
                        Console.Write("Введіть площу основи: ");
                        double baseArea = GetPositiveNumber();
                        Console.Write("Введіть висоту: ");
                        double h = GetPositiveNumber();
                        Console.WriteLine($"Об'єм піраміди: {GeometryCalculator.CalculatePyramidVolume(baseArea, h):F2}");
                        break;

                    case 5:
                        Console.Write("Введіть радіус: ");
                        double radius = GetPositiveNumber();
                        Console.WriteLine($"Об'єм сфери: {GeometryCalculator.CalculateSphereVolume(radius):F2}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine("
Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
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
