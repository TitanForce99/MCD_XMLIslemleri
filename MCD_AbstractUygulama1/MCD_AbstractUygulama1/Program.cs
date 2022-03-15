using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstractUygulama1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(5, 4);
            R1.CalculateArea();
            R1.CalculatePerimeter();

            Square S1 = new Square(8);
            S1.CalculateArea();
            S1.CalculatePerimeter();

            Circle C1 = new Circle(7);
            C1.CalculateArea();
            C1.CalculatePerimeter();


            Console.ReadKey();
        }
    }
}
