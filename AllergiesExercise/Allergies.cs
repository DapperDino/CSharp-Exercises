namespace AllergiesExercise
{
    public class Allergies
    {
        private readonly int allergyScore;

        public Allergies(int allergyScore)
        {
            this.allergyScore = allergyScore;
        }

        public bool IsAllergicTo(Allergens allergen)
        {
            return (GetAllergens() & allergen) != 0;
        }

        public Allergens GetAllergens()
        {
            return (Allergens)allergyScore;
        }
    }
}
