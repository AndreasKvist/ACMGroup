using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_04
{
    class Program
    {
        static void Main(string[] args)
        {Record w = new Record();
            w.Name = "Wings at the Speed of Sound";
            w.Group = "Wings";
            w.ReleasDate = "25 March 1976";
            w.Artist = "Paul McCartney, Linda McCartney, Denny Laine, Jimmy McCulloch, Joe English";

            Record r = new Record();
            r.Name = "Revolver";
            r.Group = "Beatles";
            r.ReleasDate = "5 August 1966";
            r.Artist = "John Lennon, Paul McCartney, George Harrison, Ringo Starr";

            Record s = new Record();
            s.Name = "SO";
            s.Group="Peter Gabriel";
            s.ReleasDate="25 April 1986";
            s.Artist="Peter Gabriel";

            Record i = new Record();
            i.Name = "Invisible Touch";
            i.Group="Genesis";
            i.ReleasDate="October 1986";
            i.Artist = "Mike Rutherford, Tony Banks, Phil Collins";

            Console.WriteLine("\nHit enter-key to stop the program.");
            Console.ReadKey();
        }

        }
    }

