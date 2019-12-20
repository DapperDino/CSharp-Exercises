using System.Collections.Generic;
using System.Linq;

namespace Exercises.Easy.HighScoresExercise
{
    public class HighScores
    {
        private readonly List<int> scores;

        public HighScores(List<int> scores)
        {
            this.scores = scores;
        }

        public int TopScore => scores.Max();
        public int MostRecentScore => scores.Last();

        public List<int> GetTopScores(int count)
        {
            return scores.OrderByDescending(x => x).Take(count).ToList();
        }
    }
}
