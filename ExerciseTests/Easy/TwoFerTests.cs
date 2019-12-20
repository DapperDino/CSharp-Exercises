using Exercises.Easy.TwoFerExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Easy
{
    public class TwoFerTests
    {
        [Test]
        public void GetDisplayText_NoNameGiven_IsForYou()
        {
            Assert.AreEqual("One for you, one for me.", TwoFer.GetDisplayText());
        }

        [Test]
        [TestCase("Bob")]
        [TestCase("Alice")]
        public void GetDisplayText_ANameIsGiven_IsForName(string name)
        {
            Assert.AreEqual($"One for {name}, one for me.", TwoFer.GetDisplayText(name));
        }
    }
}
