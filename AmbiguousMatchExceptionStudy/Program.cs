using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmbiguousMatchExceptionStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example3
            Type movieType = typeof(Movie);
            var movie = Activator.CreateInstance(movieType);

            MethodInfo DisplayCreditsInfoVoid = movieType.GetMethod("DisplayCredits", new Type[] { });
            DisplayCreditsInfoVoid.Invoke(movie, null);

            MethodInfo DisplayCreditsInfoParam = movieType.GetMethod("DisplayCredits", new Type[] { typeof(int) });
            DisplayCreditsInfoParam.Invoke(movie, new object[] {32});

            //Example2
            //Type movieType = typeof(Movie);
            //var movie = Activator.CreateInstance(movieType);
            //MethodInfo DisplayCreditsInfo = movieType.GetMethod("DisplayCredits");
            //DisplayCreditsInfo.Invoke(movie, null);


            //Example1
            //var movie = new Movie();
            //movie.DisplayCredits();
            //movie.DisplayCredits(4);

            Console.ReadKey();
        }
    }
}
