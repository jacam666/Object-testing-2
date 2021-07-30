﻿using System;

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
            Console.WriteLine("Leg Workout");
            UI.LegExercisesToComplete();
           
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
}
