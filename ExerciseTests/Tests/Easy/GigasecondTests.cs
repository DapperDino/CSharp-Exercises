using GigasecondExercise;
using NUnit.Framework;
using System;

namespace ExerciseTests.Tests.Easy
{
    public class GigasecondTests
    {
        [Test]
        public void InOneGigasecond_SpecifyOnlyTime_TimeIsCorrect()
        {
            Assert.AreEqual(
                new DateTime(2043, 1, 1, 1, 46, 40),
                Gigasecond.InOneGigasecond(new DateTime(2011, 4, 25)));
        }

        [Test]
        public void InOneGigasecond_SpecifyFullTime_TimeIsCorrect()
        {
            Assert.AreEqual(
                new DateTime(2046, 10, 2, 23, 46, 40),
                Gigasecond.InOneGigasecond(new DateTime(2015, 1, 24, 22, 0, 0)));
        }
    }
}
