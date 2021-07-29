using System;

namespace Object_testing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
            
            ChestWorkout workOutPlan = new();
            
            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.RestBetweenSets = 60;
           

            Console.WriteLine("The number of sets that are required are " + workOutPlan.NumberOfSets + " sets per workout");
            Console.WriteLine("The amount of Reps per set are " + workOutPlan.NumberOfRepsPerSets);
            Console.WriteLine("You are allowed " + workOutPlan.RestBetweenSets + " seconds rest between sets.");
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
 
        public string FlatBench;
        public string InclineBench;
        public string CableFlyes;
        public string InclineDumbbellPress;
        public string PecDec;
    }
}
