using System;
using System.Collections.Generic;
using System.Linq;

namespace NucleotideCountExercise
{
    public static class NucleotideCount
    {
        private const string AllowedNucleotides = "ACGT";

        public static Dictionary<char, int> Count(string sequence)
        {
            if (!sequence.All(AllowedNucleotides.Contains))
            {
                throw new ArgumentException("Sequence must only contain the characters: 'A', 'C', 'G' or 'T'");
            }

            return (sequence + AllowedNucleotides)
                .GroupBy(x => x)
                .ToDictionary(y => y.Key, y => y.Count() - 1);
        }
    }
}
