namespace LeapExercise
{
    public static class Leap
    {
        public static bool IsLeapYear(int year)
        {
            // Leap years are every 4th
            // except when they are divisible by 100 and not divisible by 400

            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}
