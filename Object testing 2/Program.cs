using System;

namespace Object_testing_2
{
    class Program
    {

        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
            UI.RequiredNumbersAndTimings();
            UI.ChesWorkouttHeadline();
            UI.ChestExercisesToComplete();
            UI.LegWorkoutHeadline();
            UI.LegExercisesToComplete();
            UI.ShoulderWorkoutHeadline();
            UI.ShoulderExercisesToComplete();
            UI.BackWorkoutHeadline();
            UI.BackExercisesToComplete();
            UI.ArmWorkOutHeadline();
            UI.ArmExercisesToComplete();
        }
    }

    public class ChestWorkout
    {
        public int NumberOfSetsPerWOrkout;
        public int NumberOfSetsPerExercise;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;
    }
    public class LegWorkout
    {
        public int NumberOfSetsPerWOrkout;
        public int NumberOfSetsPerExercise;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;
    }
    public class ShoulderWorkout
    {
        public int NumberOfSetsPerWOrkout;
        public int NumberOfSetsPerExercise;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;
    }
    public class BackWorkout
    {
        public int NumberOfSetsPerWOrkout;
        public int NumberOfSetsPerExercise;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;
    }
    public class ArmWorkout
    {
        public int NumberOfSetsPerWOrkout;
        public int NumberOfSetsPerExercise;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;
    }
        
}
