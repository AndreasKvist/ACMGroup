using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x > 0)
            {
                x = x + (x / 2);
                if (x == 1)
                {
                    x++;
                }
                x = x / 2;
                Console.WriteLine(x);
                
            }
        }
    }
}
