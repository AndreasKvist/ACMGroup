using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4405
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Rob";
            string s2 = s1;
            s2 = "different";
            Console.WriteLine(s1 + " " + s2);
            Console.ReadKey();
            //String is immutable. When the system sees the line: s2 = "different"; it refers to that line
        }
    }
}
