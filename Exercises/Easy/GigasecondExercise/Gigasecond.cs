using System;

namespace Exercises.Easy.GigasecondExercise
{
    public static class Gigasecond
    {
        public static DateTime InOneGigasecond(DateTime time)
        {
            return time.AddSeconds(1E9);
        }
    }
}
