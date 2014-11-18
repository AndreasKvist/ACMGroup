using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45Exercise02
{
    class Calculations
    {
        public static double BMI (double weight, double height)
    {
        double BMI = weight / (height * height);

        return BMI;
    }
    }
}
