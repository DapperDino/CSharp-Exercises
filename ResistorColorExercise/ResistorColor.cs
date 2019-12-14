using System;

namespace ResistorColorExercise
{
    public static class ResistorColor
    {
        private static readonly string[] Colors = new[]
        {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
        };

        public static int CodeForColor(string color)
        {
            return Array.FindIndex(Colors, t => t.Equals(color, StringComparison.OrdinalIgnoreCase));
        }
    }
}
