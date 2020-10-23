using System;
using System.Collections.Generic;
using System.Text;

namespace SportLibrary
{
    public class Exercise
    {
        public ExerciseCategory category;
        public string NameOfExercise;
        public string Description;
        public int sets = 5;
        public int timesInSet = 5;
        public Exercise() { }
        public Exercise(ExerciseCategory category, string name)
        {
            this.category = category;
            this.NameOfExercise = name;
            this.Description = "No description yet";
        }
        public Exercise(ExerciseCategory category, string name, int sets, int timesInSet): this(category, name)
        {
            this.sets = sets;
            this.timesInSet = timesInSet;
        }

        public override bool Equals(object obj)
        {
            return obj is Exercise exercise &&
                   NameOfExercise == exercise.NameOfExercise;
        }

        public override int GetHashCode()
        {
            return 489944025 + EqualityComparer<string>.Default.GetHashCode(NameOfExercise);
        }
    }
}
