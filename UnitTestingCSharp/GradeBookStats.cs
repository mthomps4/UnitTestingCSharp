using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
  public class GradeBookStats
    {
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade; 
    
        public GradeBookStats()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue; 
        }
    }
}
