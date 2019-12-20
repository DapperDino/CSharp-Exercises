using System;
using System.Linq;

namespace Exercises.Easy.HammingExercise
{
    public static class Hamming
    {
        public static int GetDistance(string strandOne, string strandTwo)
        {
            if (strandOne.Length != strandTwo.Length)
            {
                throw new ArgumentException("Strands must be the same length");
            }

            return strandOne.Where((x, y) => x != strandTwo[y]).Count();
        }
    }
}
