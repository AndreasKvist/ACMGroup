using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            double myBMI = Calculations.BMI(72, 1.80);
            
            Console.WriteLine(myBMI);

            //Person benny = new Person("Benny", 72, 1.80);
            //double bennyBMI = benny.CalcualteBMI();

            Console.ReadKey();
        }

        
    }
}
