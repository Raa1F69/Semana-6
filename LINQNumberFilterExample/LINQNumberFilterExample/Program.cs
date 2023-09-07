using System;
using System.Linq;

namespace LINQNumberFilterExample 
{
    class Program
    {
        static void Main(string[] args)
        {          
            int[] scores = { 97, 92, 81, 60 };

            var highScores = from score in scores
                             where score > 80
                             select score;
          
            foreach (var highScore in highScores)
            {
                Console.WriteLine(highScore);
            }
        }
    }
}

