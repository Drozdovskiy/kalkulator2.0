using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulytor
{ 
    internal class CL
    {

        double a;
        double b;

        public void minus(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        public void plus(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        
        public void multiplication(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        public void division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("На 0 делить нельзя");
            }
            else
            {
                Console.WriteLine(a / b);
            }

        }

        public void degree(double a, double b) // степень
        {
            Console.WriteLine(Math.Pow(a, b));
        }

        public void square(double a, double b) // квадрат
        {
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(Math.Sqrt(b));
        }
        
        public void rounding(double a, double b) //округление
        {
            Console.WriteLine(Math.Round(a));
            Console.WriteLine(Math.Round(b));
        }

        public void arksin(double a, double b) //arksin
        {
            Console.WriteLine(Math.Atan(a));
            Console.WriteLine(Math.Atan(b));
        }

        public void sin(double a, double b) //sinus
        {
            Console.WriteLine(Math.Sin(a));
            Console.WriteLine(Math.Sin(b));
        }

        public void cos(double a, double b) //cosinus
        {
            Console.WriteLine(Math.Cos(a));
            Console.WriteLine(Math.Cos(b));
        }


        public void squarePerimeter(double a, double b) //периметр
        {
            Console.WriteLine(4 * a);
            Console.WriteLine(4 * b);
        }

        public void squreArea(double a, double b) //площадь
        {
            Console.WriteLine(Math.Pow(a, 2));
            Console.WriteLine(Math.Pow(b, 2));
        }

        public void circleRadius(double a, double b) //радиус круга
        {
            Console.WriteLine(a / 2);
            Console.WriteLine(b / 2);
        }

        public void circleDiameter(double a, double b) // диаметр круга
        {
            Console.WriteLine(2 * a);
            Console.WriteLine(2 * b);
        }
    }
}