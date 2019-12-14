using NUnit.Framework;
using ResistorColorExercise;

namespace ExerciseTests.Tests.Easy
{
    public class ResistorColorTests
    {
        [Test]
        [TestCase("Black", 0)]
        [TestCase("White", 9)]
        [TestCase("Orange", 3)]
        public void CodeForColor_GivenColor_ReturnsCodeForColor(string color, int code)
        {
            Assert.AreEqual(code, ResistorColor.CodeForColor(color));
        }
    }
}
