using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Exercise03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 8; i <= 16; i++)
            {

                if (i == 12)
                {
                    Console.WriteLine("Lunch Break");
                }
                else
                {
                    Console.WriteLine(i);
                    if (i == 8)
                    {
                        
                        Console.WriteLine(" - Start of the day");
                    }
                    else if (i == 16)
                    {

                        Console.WriteLine("Going home at 16");
                    }
                }



            }
            Console.ReadKey();
        }
    }
}