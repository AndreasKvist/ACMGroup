using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2_02
{
    class Soccer
    {
        public Soccer( string homefield, List<GoalScore> gs )
        {
            HomeField = homefield;
            goalscore = gs;

        }
        public string HomeField { get; set; }

        public List<GoalScore> goalscore { get; set; }
    }
}
