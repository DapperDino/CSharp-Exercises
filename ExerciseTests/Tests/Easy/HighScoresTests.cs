using HighScoresExercise;
using NUnit.Framework;
using System.Collections.Generic;

namespace ExerciseTests.Tests.Easy
{
    public class HighScoresTests
    {
        [Test]
        public void TopScore_TopScoreIsReturned()
        {
            var highScores = new HighScores(new List<int> { 40, 100, 70 });

            Assert.AreEqual(100, highScores.TopScore);
        }

        [Test]
        public void MostRecentScore_MostRecentScoreIsReturned()
        {
            var highScores = new HighScores(new List<int> { 100, 0, 90, 30 });

            Assert.AreEqual(30, highScores.MostRecentScore);
        }

        [Test]
        public void GetTopScores_GivenCount_TopCountScoresAreReturned()
        {
            var highScores = new HighScores(new List<int> { 10, 30, 90, 30, 100, 20, 10, 0, 30, 40, 40, 70, 70 });

            Assert.AreEqual(new List<int> { 100, 90, 70 }, highScores.GetTopScores(3));
        }
    }
}
