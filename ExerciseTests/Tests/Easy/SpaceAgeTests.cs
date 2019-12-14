using NUnit.Framework;
using SpaceAgeExercise;

namespace ExerciseTests.Tests.Easy
{
    public class SpaceAgeTests
    {
        [Test]
        public void CalculateAge_OnEarth_IsCorrect()
        {
            Assert.AreEqual(31.69, SpaceAge.CalculateAge(1000000000, Planets.Earth));
        }

        [Test]
        public void CalculateAge_OnMercury_IsCorrect()
        {
            Assert.AreEqual(280.88, SpaceAge.CalculateAge(2134835688, Planets.Mercury));
        }

        [Test]
        public void CalculateAge_OnVenus_IsCorrect()
        {
            Assert.AreEqual(9.78, SpaceAge.CalculateAge(189839836, Planets.Venus));
        }

        [Test]
        public void CalculateAge_OnMars_IsCorrect()
        {
            Assert.AreEqual(39.25, SpaceAge.CalculateAge(2329871239, Planets.Mars));
        }

        [Test]
        public void CalculateAge_OnJupiter_IsCorrect()
        {
            Assert.AreEqual(2.41, SpaceAge.CalculateAge(901876382, Planets.Jupiter));
        }

        [Test]
        public void CalculateAge_OnSaturn_IsCorrect()
        {
            Assert.AreEqual(3.23, SpaceAge.CalculateAge(3000000000, Planets.Saturn));
        }

        [Test]
        public void CalculateAge_OnUranus_IsCorrect()
        {
            Assert.AreEqual(1.21, SpaceAge.CalculateAge(3210123456, Planets.Uranus));
        }

        [Test]
        public void CalculateAge_OnNeptune_IsCorrect()
        {
            Assert.AreEqual(1.58, SpaceAge.CalculateAge(8210123456, Planets.Neptune));
        }
    }
}
