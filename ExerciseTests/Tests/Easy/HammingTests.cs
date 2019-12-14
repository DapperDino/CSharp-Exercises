using HammingExercise;
using NUnit.Framework;

namespace ExerciseTests.Tests.Easy
{
    public class HammingTests
    {
        [Test]
        public void GetHammingDistance_EmptyStrands_DistanceIsZero()
        {
            Assert.AreEqual(0, Hamming.GetDistance(string.Empty, string.Empty));
        }

        [Test]
        [TestCase("A")]
        [TestCase("BPHV")]
        [TestCase("GGACTGA")]
        public void GetHammingDistance_IdenticalStrands_DistanceIsZero(string strand)
        {
            Assert.AreEqual(0, Hamming.GetDistance(strand, strand));
        }

        [Test]
        public void GetHammingDistance_OneDifference_DistanceOne()
        {
            Assert.AreEqual(1, Hamming.GetDistance("A", "G"));
        }

        [Test]
        public void GetHammingDistance_SmallStrandsWithOneDifference_DistanceIsOne()
        {
            Assert.AreEqual(1, Hamming.GetDistance("AT", "CT"));
        }

        [Test]
        public void GetHammingDistance_SmallStrandsWithTwoDifference_DistanceIsTwo()
        {
            Assert.AreEqual(2, Hamming.GetDistance("AG", "CT"));
        }

        [Test]
        public void GetHammingDistance_LongStrandsWithTwoDifference_DistanceIsTwo()
        {
            Assert.AreEqual(2, Hamming.GetDistance("ACCAGGG", "ACTATGG"));
        }

        [Test]
        public void GetHammingDistance_OneNonUniqueCharacterInStrand_DistanceIsOne()
        {
            Assert.AreEqual(1, Hamming.GetDistance("AAA", "AAG"));
        }

        [Test]
        public void GetHammingDistance_FirstStrandLonger_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Hamming.GetDistance("AATG", "AAA"));
        }

        [Test]
        public void GetHammingDistance_SecondStrandLonger_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Hamming.GetDistance("ATA", "AGTG"));
        }
    }
}
