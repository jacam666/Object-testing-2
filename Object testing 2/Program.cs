using System;

namespace Object_testing_2
{
    class Program
    {

        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
            UI.RequiredNumbersAndTimings();
            Console.WriteLine("CHEST WORKOUT :");
            UI.ChestExercisesToComplete();
            Console.WriteLine("Leg Workout :");
            UI.LegExercisesToComplete();
            Console.WriteLine("Shoulder Workout");
            UI.ShoulderExercisesToComplete();
            Console.WriteLine("Back Workout");
            UI.BackExercisesToComplete();
            ArmWorkout workOutPlan = new();
            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.FirstExercise = " Dumbbell Curls";
            workOutPlan.SecondExercise = " Close Grip Bench";
            workOutPlan.ThirdExercise = " Preacher Curls";
            workOutPlan.FourthExercise = " Cable Tricep Pushdown";
            workOutPlan.FifthExercise = " Barbell Curls";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");


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
    public class LegWorkout
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
    public class ShoulderWorkout
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
    public class BackWorkout
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
    public class ArmWorkout
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
