using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
namespace modu_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = double.Parse(Console.ReadLine());
            Count(a, b, c, out double x1, out double x2, out int v);
            switch (v)
            {
                case 1:
                    Console.WriteLine($"Корни уравнения с коэффициентами a={a} b={b} c={c} x1={x1}, x2={x2}"); break;
                case 0:
                    Console.WriteLine($"Корень уравнения с коэффициентами a={a} b={b} c={c} x1=x2={x1}"); break;
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a={a} b={b} c={c} нет."); break;
            }
        }
        static double Count(double a, double b, double c, out double x1, out double x2, out int v)
        {
            x1 = 0;
            x2 = 0;
            double d = Math.Sqrt(b * b - 4 * a * c);
            if (d > 0)
            {
                v = 1;
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
            }
            else if (d == 0)
            {
                v = 0;
                x1 = -b / (2 * a);
            }
            else
            {
                v = -1;
            }
            return v;
        }
    }
}