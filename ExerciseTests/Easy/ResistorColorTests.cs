﻿using Exercises.Easy.ResistorColorExercise;
using NUnit.Framework;

namespace Exercises.ExerciseTests.Easy
{
    public class ResistorColorTests
    {
        [Test]
        [TestCase(BandColors.Black, 0)]
        [TestCase(BandColors.White, 9)]
        [TestCase(BandColors.Orange, 3)]
        public void CodeForColor_GivenColor_ReturnsCodeForColor(BandColors color, int code)
        {
            Assert.AreEqual(code, ResistorColor.CodeForColor(color));
        }
    }
}
