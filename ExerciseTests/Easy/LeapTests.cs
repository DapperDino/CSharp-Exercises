using Exercises.Easy.LeapExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Easy
{
    public class LeapTests
    {
        [Test]
        [TestCase(1996)]
        [TestCase(2000)]
        public void IsLeapYear_GivenALeapYear_ReturnsTrue(int year)
        {
            Assert.IsTrue(Leap.IsLeapYear(year));
        }

        [Test]
        [TestCase(1997)]
        [TestCase(1900)]
        public void IsLeapYear_NotGivenALeapYear_ReturnsFalse(int year)
        {
            Assert.IsFalse(Leap.IsLeapYear(year));
        }
    }
}
