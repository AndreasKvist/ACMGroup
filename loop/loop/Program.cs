using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            while (i > 0)
            {
                 Console.WriteLine(i);
                 i--; //corresponds to i = i - 1;
           }
            Console.ReadKey();
}
    }
}