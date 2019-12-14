namespace TwoFerExercise
{
    public static class TwoFer
    {
        public static string GetDisplayText(string name = null)
        {
            return $"One for {name ?? "you" }, one for me.";
        }
    }
}
