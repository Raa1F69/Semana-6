using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] scores = { 90, 71, 82, 93, 75, 82 };

        var filteredAndSortedScores = from score in scores
                                      where score > 80
                                      orderby score descending
                                      select score;

        foreach (var score in filteredAndSortedScores)
        {
            Console.WriteLine(score);
        }
    }
}
