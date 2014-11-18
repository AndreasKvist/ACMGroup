using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41exercise01
{
    class Program
    {
        List<RightTriangle> righttriangle;
        List<Square> square;
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.run();

                
        }
        public void run()
        {
            righttriangle = new List<RightTriangle>();
            square = new List<Square>();

         


            int intAnswer = 0;
            do
            {
                Console.WriteLine("- MENU SYSTEM -");
                Console.WriteLine("   1 : do this");
                Console.WriteLine("   2 : do that");
                Console.WriteLine("     .... and so on ...");
                Console.WriteLine("   0 : Exit");
                Console.Write("Enter the value for the choice : ");
                intAnswer = int.Parse(Console.ReadLine());

                if (intAnswer == 1)
                {
                    Console.WriteLine("Enter height");
                    double Height = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width");
                    double Width = double.Parse(Console.ReadLine());

                    Square Firkant1 = new Square(Height, Width);
                    square.Add(Firkant1);
                    
                }
                else
                    if (intAnswer == 2)
                    {
                        Console.WriteLine("Enter height");
                        double Height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter width");
                        double Width = double.Parse(Console.ReadLine());

                        RightTriangle Trekant1 = new RightTriangle(Height, Width);
                        righttriangle.Add(Trekant1);
                    }
                        else
                        if (intAnswer == 3)
                        {
                            int i;
                            for (i = 0)

                            {
                           
                            {

                            }
                            }
                        }
                    else
                        if (intAnswer == 0)
                        {
                            Console.WriteLine("Bye - press Enter to exit");
                            Console.ReadKey();
                        }
            } while (intAnswer != 0);
        }
    }
}
