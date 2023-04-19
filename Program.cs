using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ConsoleStars
{
    class Program
    {      
        static void Main(string[] args)
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            


            var stars = new List<IStarShowAndUpdate>()
            {
          /*      new PhasesStar(random),
                new PhasesStar(random),
                new PhasesStar(random),*/
           /*     new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),*/
            };
            for (int i = 3; i > 0; i--)
            {
                stars.Add(new PhasesStar(random));
                stars.Add(new MovableStar(random));
            }
            
            ;
            while (true)
            {
                Console.Clear();     
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}
