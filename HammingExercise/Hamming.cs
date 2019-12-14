using System.Linq;

namespace HammingExercise
{
    public static class Hamming
    {
        public static int GetDistance(string strandOne, string strandTwo)
        {
            if (strandOne.Length != strandTwo.Length)
            {
                return -1;
            }

            return strandOne.Where((x, y) => x != strandTwo[y]).Count();
        }
    }
}
