using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_and_triangle
{
    class Square
    {
        public Square()
        { }
        public double Height { get; set; }

        public double Width { get; set; }

        private double areaValue;
        private double circumferenceValue;

        public double Area()
        {
            areaValue = Height * Width;

            return areaValue;

            }
        public double Circumference()
    {
        circumferenceValue = Height * Width * 2;

        return circumferenceValue;
    }

       


        
    }
}

