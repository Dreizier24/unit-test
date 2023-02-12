using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            TriangleCheck trinagle = new TriangleCheck();
            Console.WriteLine(trinagle.Side(a, b, c));
            Console.WriteLine(trinagle.Angle(a, b, c));
        }
    }
}
