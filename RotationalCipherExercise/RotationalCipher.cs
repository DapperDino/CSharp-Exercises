using System.Linq;

namespace Exercises.Medium.RotationalCipherExercise
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int key)
        {
            char Rotate(char character)
            {
                if (!char.IsLetter(character)) { return character; }

                int caseId = char.IsLower(character) ? 'a' : 'A';

                return (char)(caseId + ((character - caseId + key) % 26));
            }

            return new string(text.Select(Rotate).ToArray());
        }
    }
}
