﻿namespace ClockExercise
{
    public struct Clock
    {
        public Clock(int hours, int minutes = 0)
        {
            Hours = Mod((hours * 60 + minutes) / 60.0, 24);
            Minutes = Mod(minutes, 60);
        }

        public int Hours { get; }

        public int Minutes { get; }

        public Clock Add(int minutesToAdd) => new Clock(Hours, Minutes + minutesToAdd);
        public Clock Subtract(int minutesToSubtract) => new Clock(Hours, Minutes - minutesToSubtract);

        public override string ToString() => $"{Hours:00}:{Minutes:00}";

        private static int Mod(double x, double y) => (int)((x % y + y) % y);
    }
}
