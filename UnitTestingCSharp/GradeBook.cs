using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
    public class GradeBook
    {
        public List<float> grades;

        public GradeBook()
        {
            grades = new List<float>(); 
        }

        public GradeBookStats ComputeStatistics()
        {
            GradeBookStats stats = new GradeBookStats();
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade; 
            }

            stats.AverageGrade = sum / grades.Count;
            return stats; 
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade); 
        }
       
    }
}
