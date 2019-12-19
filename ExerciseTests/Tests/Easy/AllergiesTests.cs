using AllergiesExercise;
using NUnit.Framework;

namespace ExerciseTests.Tests.Easy
{
    public class AllergiesTests
    {
        [Test]
        public void IsAllergicTo_HasNoAllergies_IsNotAllergicToAnything()
        {
            var allergies = new Allergies(0);

            Assert.False(allergies.IsAllergicTo(Allergens.Peanuts));
            Assert.False(allergies.IsAllergicTo(Allergens.Cats));
            Assert.False(allergies.IsAllergicTo(Allergens.Strawberries));
        }

        [Test]
        public void IsAllergicTo_HasEggsAllergy_IsAllergic()
        {
            var allergies = new Allergies(1);

            Assert.True(allergies.IsAllergicTo(Allergens.Eggs));
        }

        [Test]
        public void IsAllergicTo_HasAFewAllergies_IsAllergic()
        {
            var allergies = new Allergies(5);

            Assert.True(allergies.IsAllergicTo(Allergens.Eggs));
            Assert.True(allergies.IsAllergicTo(Allergens.Shellfish));
            Assert.False(allergies.IsAllergicTo(Allergens.Strawberries));
        }

        [Test]
        public void GetAllergens_HasNoAllergies_IsNotAllergic()
        {
            var allergies = new Allergies(0);

            Assert.AreEqual(Allergens.None, allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasEggsAllergy_IsAllergic()
        {
            var allergies = new Allergies(1);

            Assert.AreEqual(Allergens.Eggs, allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasPeanutsAllergy_IsAllergic()
        {
            var allergies = new Allergies(2);

            Assert.AreEqual(Allergens.Peanuts, allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasStrawberriesAllergy_IsAllergic()
        {
            var allergies = new Allergies(8);

            Assert.AreEqual(Allergens.Strawberries, allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasEggsAndPeanutsAllergy_IsAllergic()
        {
            var allergies = new Allergies(3);

            Assert.AreEqual(Allergens.Eggs | Allergens.Peanuts, allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasEggsAndShellfishAllergy_IsAllergic()
        {
            var allergies = new Allergies(5);

            Assert.AreEqual(Allergens.Eggs | Allergens.Shellfish, allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasManyAllergies_IsAllergic()
        {
            var allergies = new Allergies(248);
            Assert.AreEqual(
                Allergens.Strawberries | Allergens.Tomatoes | Allergens.Chocolate |
                Allergens.Pollen | Allergens.Cats,
                allergies.GetAllergens());
        }

        [Test]
        public void GetAllergens_HasAllAllergies_IsAllergic()
        {
            var allergies = new Allergies(255);
            Assert.AreEqual(
                Allergens.Eggs | Allergens.Peanuts | Allergens.Shellfish | Allergens.Strawberries |
                Allergens.Tomatoes | Allergens.Chocolate | Allergens.Pollen | Allergens.Cats,
                allergies.GetAllergens());
        }
    }
}
