using System;

namespace seminar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PERIMETERANDSQUARE();
            //Meandrirh();
            //SwapAB();
            ZADANIE();
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
        private static void SwapAB()
        {
            Console.WriteLine("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            double c = a;

        }
        private static void ZADANIE()
        {
            Console.WriteLine("Введите число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину отрезка: ");
            int L = int.Parse(Console.ReadLine());
            int n = ((b - a) / L);
            Console.WriteLine($"Отрезрк уместится {n} раз");
        }

    }
    
}
