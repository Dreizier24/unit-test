using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    public class TriangleCheck
    {

        bool Zero(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            else return true;
        }
        public string Side(double a, double b, double c)
        {
            if (Zero(a, b, c))
            {
                if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                    return "Треугольник не существует";
                else if (a == b && b == c)
                    return "Треугольник равносторонний";
                else if ((a == b && b != c) || (a == c && c != b) || (b == c && c != a))
                    return "Треугольник равнобедренный";
                else return "Треугольник произвольный";
            }
            else return "Сторона не может быть <= 0!";
        }
        public string Angle(double a, double b, double c)
        {
            if (Zero(a, b, c))
            {
                if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                    return "Треугольник не существует";
                else if (c * c > (a * a + b * b) || b * b > (a * a + c * c) || a * a > (b * b + c * c))
                    return "Треугольник тупоугольный";
                else if (c * c == (a * a + b * b) || b * b == (a * a + c * c) || a * a == (b * b + c * c))
                    return "Треугольник прямоугольный";
                else return "Треугольник остроугольный";
            }
            else return "Сторона не может быть <= 0!";
        }
    }
}
