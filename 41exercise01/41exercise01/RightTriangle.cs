using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41exercise01
{
    class RightTriangle
    {
        double Height;
        double Width;
        public RightTriangle(double newHeight, double newWidth)
        {
            Height = newHeight;
            Width = newWidth;

        }

        private double areaValue;
        private double circumferenceValue;

        public double Area()
        {
            areaValue = Height * Width;

            return areaValue;
        }
        public double Circumference()
        {
            circumferenceValue = Height * 2 + Width * 2;

            return circumferenceValue;
        }
      
           
        }
 
    }



