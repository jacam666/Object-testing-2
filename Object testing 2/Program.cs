using System;

namespace Object_testing_2
{
    class Program
    {
        //public static string InclineBench { get; set; }
        //public static string FlatBench { get; set; }
        //public static string CableFlyes { get; set; }
        //public static string InclineDumbbellFlyes { get; set; }
        //public static string PecDec { get; set; }

        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
                       
            UI.RequiredNumbersAndTimings();

            Exercises WorkoutExercises = new();
            
            WorkoutExercises.FirstExercise = 
            WorkoutExercises.SecondExercise = 
            WorkoutExercises.ThirdExercise = 
            WorkoutExercises.FourthExercise = 
            WorkoutExercises.FifthExercise = 

            //Console.WriteLine("Your first exercise is : " + WorkoutExercises.SecondExercise);
        }
    }
    public class ChestWorkout
    {
        public int NumberOfSets;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        

    }
    public class Exercises
    {
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;
    }
}
