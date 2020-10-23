using System;
using System.Collections.Generic;
using System.Linq;

namespace SportLibrary
{
    public class BookOfSport
    {
        public HashSet<Exercise> Exercises;
        public BookOfSport()
        {
            this.Exercises = GetDefaultPack();
        }

        public void AddExercise(Exercise exercise)
        {
            Exercises.Add(exercise);
        }

        public HashSet<Exercise> GetDefaultPack()
        {
            var ex = new HashSet<Exercise>();
            ex.Add(new Exercise(ExerciseCategory.Chest, "Pushups", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Chest, "Bench Press", 4, 20));
            ex.Add(new Exercise(ExerciseCategory.Chest, "Chest fly", 5, 15));
            ex.Add(new Exercise(ExerciseCategory.Chest, "Dumbbell Floor Press", 5, 10));
            ex.Add(new Exercise(ExerciseCategory.Chest, "Band Chest Fly", 10, 10));
            ex.Add(new Exercise(ExerciseCategory.Chest, "Batwing Fly", 10, 20));

            ex.Add(new Exercise(ExerciseCategory.Arms, "Chin-up", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Arms, "Dip", 4, 20));
            ex.Add(new Exercise(ExerciseCategory.Arms, "Hammer Curl", 5, 15));
            ex.Add(new Exercise(ExerciseCategory.Arms, "Close-Grip Curl", 5, 10));
            ex.Add(new Exercise(ExerciseCategory.Arms, "Suspension Trainer Triceps Extension", 10, 10));
            ex.Add(new Exercise(ExerciseCategory.Arms, "Diamond Pushup", 10, 20));

            ex.Add(new Exercise(ExerciseCategory.Legs, "Front Squat", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Legs, "Bulgarian Split Squat", 4, 20));
            ex.Add(new Exercise(ExerciseCategory.Legs, "Romanian Deadlift", 5, 15));
            ex.Add(new Exercise(ExerciseCategory.Legs, "Squat", 5, 10));
            ex.Add(new Exercise(ExerciseCategory.Legs, "Dumbbell Stepup", 10, 10));
            ex.Add(new Exercise(ExerciseCategory.Legs, "Deadlift", 10, 20));

            ex.Add(new Exercise(ExerciseCategory.Butt, "Single-Leg Glute Bridge", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Butt, "Hydrants With Leg Extension", 4, 20));
            ex.Add(new Exercise(ExerciseCategory.Butt, "Rainbows", 5, 15));
            ex.Add(new Exercise(ExerciseCategory.Butt, "Curtsy Lunges", 5, 10));
            ex.Add(new Exercise(ExerciseCategory.Butt, "Heel-Lifted Sumo Squat", 10, 10));
            ex.Add(new Exercise(ExerciseCategory.Butt, "Bear Plank Leg Lifts", 10, 20));

            ex.Add(new Exercise(ExerciseCategory.Back, "Band Bent-Over Row", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Back, "Renegade Row", 4, 20));
            ex.Add(new Exercise(ExerciseCategory.Back, "Dumbbell Single-Arm Row", 5, 15));
            ex.Add(new Exercise(ExerciseCategory.Back, "Chest-Supported Dumbbell Row", 5, 10));
            ex.Add(new Exercise(ExerciseCategory.Back, "Inverted Row", 10, 10));
            ex.Add(new Exercise(ExerciseCategory.Back, "Bent-Over Dumbbell Alternating Row", 10, 20));

            ex.Add(new Exercise(ExerciseCategory.Neck, "Neck Bridges", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Neck, "Back Extensions", 4, 20));

            ex.Add(new Exercise(ExerciseCategory.Press, "Pull-up", 5, 20));
            ex.Add(new Exercise(ExerciseCategory.Press, "Barbell curl", 4, 20));
            ex.Add(new Exercise(ExerciseCategory.Press, "Cable row", 5, 15));
            ex.Add(new Exercise(ExerciseCategory.Press, "Lat pull-down", 5, 10));
            ex.Add(new Exercise(ExerciseCategory.Press, "Bench press", 10, 10));
            ex.Add(new Exercise(ExerciseCategory.Press, "Incline bench press", 10, 20));

            return ex;
        }
        public List<Exercise> FindByCategory(ExerciseCategory category)
        {
            List<Exercise> res = Exercises.Where(ex => ex.category == category).ToList();
            return res;
        }

        public Exercise FindByName(string name)
        {
            return Exercises.Where(ex => ex.NameOfExercise == name).FirstOrDefault();
        }

    }
}
