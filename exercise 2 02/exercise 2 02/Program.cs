using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer odense = new Soccer();
          odense.HomeField = "OB";
          odense.goalscore = new List<GoalScore>();

          GoalScore first = new GoalScore();
          first.Name = "Benny";
          odense.goalscore.Add(first);

          Console.WriteLine("Hit enter-key to stop the program.");
          Console.ReadKey();
        }
    }
}
