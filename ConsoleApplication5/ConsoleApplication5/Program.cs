using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myNameList = new List<string>();

            Console.Write("Write a name (Write STOP to end) ");
            string newName = Console.ReadLine();

            while (!newName.Equals("STOP"))
            {
                myNameList.Add(newName);
                Console.Write("Write a name (Write STOP to end) ");
                newName = Console.ReadLine();
            }

            int i = 0;
            while (i < myNameList.Count)
            {
                Console.WriteLine(myNameList[i]);
                i = i + 1; //Equals i++;
            }
            Console.ReadKey();
        }
    }
}