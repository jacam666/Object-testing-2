using System;

namespace Object_testing_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.DisplayWelcomeScreen();
                       
            UI.RequiredNumbersAndTimings();
                     
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
