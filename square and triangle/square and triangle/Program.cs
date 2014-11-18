using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_and_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter height: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double b = double.Parse(Console.ReadLine());

            Square sq = new Square();
            sq.Height = a;
            sq.Width = b;

            


            
            Console.WriteLine("Area: " + sq.Area());
            Console.WriteLine("Circumference: " + sq.Circumference());

            Console.WriteLine("Hit enter-key to stop the program.");
            Console.ReadKey();

            

            Console.Write("Enter height: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double d = double.Parse(Console.ReadLine());

            RightTriangle rt = new RightTriangle();
            rt.Height = a;
            rt.Width = b;
            Console.WriteLine("Area: " + rt.Area());
            Console.WriteLine("Circumference: " + rt.Circumference());

            Console.WriteLine("Hit key to stop program.");
            Console.ReadKey();

        }
    }
}
