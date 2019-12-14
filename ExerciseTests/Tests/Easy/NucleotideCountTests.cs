using NucleotideCountExercise;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ExerciseTests.Tests.Easy
{
    public class NucleotideCountTests
    {
        [Test]
        public void Count_EmptyStrand_CorrectResults()
        {
            var expected = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 0,
                ['T'] = 0
            };

            Assert.AreEqual(expected, NucleotideCount.Count(string.Empty));
        }

        [Test]
        public void Count_OneNucleotide_CountsCorrectNucleotide()
        {
            var expected = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 1,
                ['T'] = 0
            };

            Assert.AreEqual(expected, NucleotideCount.Count("G"));
        }

        [Test]
        public void Count_MultipleRepeatNucleotides_CountsCorrectNucleotides()
        {
            var expected = new Dictionary<char, int>
            {
                ['A'] = 0,
                ['C'] = 0,
                ['G'] = 7,
                ['T'] = 0
            };

            Assert.AreEqual(expected, NucleotideCount.Count("GGGGGGG"));
        }

        [Test]
        public void Count_MultipleDifferentNucleotides_CountsCorrectNucleotides()
        {
            var expected = new Dictionary<char, int>
            {
                ['A'] = 20,
                ['C'] = 12,
                ['G'] = 17,
                ['T'] = 21
            };

            Assert.AreEqual(expected, NucleotideCount.Count("AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"));
        }

        [Test]
        public void Count_InvalidNucleotides_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => NucleotideCount.Count("AGXXACT"));
        }
    }
}
