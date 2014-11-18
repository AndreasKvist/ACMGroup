using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercise02
{
    class Person
    {
        public static double calculateBMI(string name, double weight, double height)
        {
            double calculateBMI = weight / (height * height);

            return calculateBMI;
        }
    }
}