using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbiguousMatchExceptionStudy
{
    public class Movie
    {
        public void DisplayCredits()
        {
            Console.WriteLine("Showing All Credits");
        }

        public void DisplayCredits(int head)
        {
            Console.WriteLine($"Showing top {head} Credits");
        }
    }
}
