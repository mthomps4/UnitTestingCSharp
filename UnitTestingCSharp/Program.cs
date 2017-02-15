using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace UnitTestingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer saySam = new SpeechSynthesizer();
            saySam.Speak("Hello, Welcome to the Grade Book Application"); 

            GradeBook book = new GradeBook();
            book.AddGrade(95);
            book.AddGrade(88);
            book.AddGrade(70.65f);

            GradeBookStats results = book.ComputeStatistics();

            Console.WriteLine(results.AverageGrade);
            saySam.Speak("The Average Grade is " + results.AverageGrade);
            Console.WriteLine(results.HighestGrade);
            saySam.Speak("The Highest Grade is " + results.HighestGrade);
            Console.WriteLine(results.LowestGrade);
            saySam.Speak("The Lowest Grade is " + results.LowestGrade);
            saySam.Speak("That completes this application, Thank You");

        }
    }
}
