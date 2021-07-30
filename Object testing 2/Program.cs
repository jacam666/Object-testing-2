using System;

namespace Object_testing_2
{
    class Program
    {

        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
                       
            UI.RequiredNumbersAndTimings();
            ChestWorkout workOutPlan = new();
            
            workOutPlan.FirstExercise = "Bench Press";
            workOutPlan.SecondExercise = "Incline Bench";
            workOutPlan.ThirdExercise = " Cable Flyes";
            workOutPlan.FourthExercise = " Incline Dumbbell Flyes";
            workOutPlan.FifthExercise = " Pec Dec";

            Console.WriteLine(workOutPlan.FirstExercise);

            
            //Console.WriteLine("Your first exercise is : " + WorkoutExercises.SecondExercise);
        }
    }
    public class ChestWorkout
    {
        public int NumberOfSets;
        public int NumberOfRepsPerSets;
        public int RestBetweenSets;
        public string FirstExercise;
        public string SecondExercise;
        public string ThirdExercise;
        public string FourthExercise;
        public string FifthExercise;

    }
   
}
