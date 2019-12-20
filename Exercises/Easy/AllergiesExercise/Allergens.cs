using System;

namespace Exercises.Easy.AllergiesExercise
{
    [Flags]
    public enum Allergens
    {
        None = 0,
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }
}
