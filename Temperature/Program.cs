using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    internal class Program
    {
        public static double CelsiusToFahrenheit(double c)
        {
            //c -> f = (c x9/5) +32
            double f = c * (9.0 / 5) + 32;
            return f;
        }
        public static double FahrenheitToCelsius (double f)
        {
            //f-> c = (f-32) x 5/9
            double c = (f - 32) * (5.0 / 9);
            return c;
        }
        static void Main(string[] args)
        {
            double f, c;

            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. chuyen doi tu F sang C");
                Console.WriteLine("2. Chuyen doi tu C sang F");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Nhap so ban muon chon");

                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Nhap nhiet do F:");
                        f = double.Parse(Console.ReadLine());
                        Console.WriteLine(f + "F = " + FahrenheitToCelsius(f) + "C");
                        break;
                    case 2:
                        Console.WriteLine("Nhap nhiet do C:");
                        c = double.Parse(Console.ReadLine());
                        Console.WriteLine(c + "C = " + CelsiusToFahrenheit(c) + "F");
                        break;
                    case 0: Environment.Exit(0);
                        break;
                }
            }
            while(choice != 0);
        }
    }
}
