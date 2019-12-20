using System;
using System.Collections.Generic;

namespace Exercises.Easy.SpaceAgeExercise
{
    public static class SpaceAge
    {
        private const decimal EarthOrbitInSeconds = 31557600;

        private static readonly Dictionary<Planets, decimal> earthYearToPlanetYear = new Dictionary<Planets, decimal>
        {
            { Planets.Earth, 1 },
            { Planets.Mercury, 0.2408467m },
            { Planets.Venus, 0.61519726m },
            { Planets.Mars, 1.8808158m },
            { Planets.Jupiter, 11.862615m },
            { Planets.Saturn, 29.447498m },
            { Planets.Uranus, 84.016846m },
            { Planets.Neptune, 164.79132m },
        };

        public static decimal CalculateAge(long seconds, Planets planet)
        {
            return Math.Round(seconds / (EarthOrbitInSeconds * earthYearToPlanetYear[planet]), 2);
        }
    }
}
