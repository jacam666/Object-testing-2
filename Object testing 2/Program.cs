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

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise);
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise);
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise);
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise);
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise);

            
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
