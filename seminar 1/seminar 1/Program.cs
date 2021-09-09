using System;

namespace seminar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PERIMETERANDSQUARE();
            Meandrirh();
        }
        private static void Meandrirh()
        {
            Console.WriteLine("Введите число 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2: ");
            double b = double.Parse(Console.ReadLine());
            double mean = (a + b) / 2;
            Console.WriteLine($"Среднее арифметическое {mean}");
        }
        private static void PERIMETERANDSQUARE()
        {
            Console.WriteLine("Введите сторону квадрата: ");
            int a = int.Parse(Console.ReadLine());
            int P = 4 * a;
            int S = a * a;
            Console.WriteLine($"Периметр P = {P} Площадь S = {S}");
        }
    }
}
