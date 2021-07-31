﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_testing_2
{
    class UI
    {
        /// <summary>
        /// Asks user for name then welcomes user
        /// </summary>
        public static void DisplayWelcomeScreen()
        {
            Console.WriteLine("Please enter your name :");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + " and welcome to your personalised workout plan");
        }
        /// <summary>
        /// informs user of amount of sets and reps needed to complete and rest timings
        /// </summary>
        public static void RequiredNumbersAndTimings()
        {
            ChestWorkout workOutPlan = new();

            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.RestBetweenSets = 60;

            Console.WriteLine("The number of sets that are required are " + workOutPlan.NumberOfSets + " sets per workout");
            Console.WriteLine("The amount of Reps per set are " + workOutPlan.NumberOfRepsPerSets);
            Console.WriteLine("You are allowed " + workOutPlan.RestBetweenSets + " seconds rest between sets.");
        }
        /// <summary>
        /// informs user of what chest exercise they need to compete and in what order
        /// </summary>
        public static void ChestExercisesToComplete()
        {
            ChestWorkout workOutPlan = new();

            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.FirstExercise = "Bench Press";
            workOutPlan.SecondExercise = "Incline Bench";
            workOutPlan.ThirdExercise = " Cable Flyes";
            workOutPlan.FourthExercise = " Incline Dumbbell Flyes";
            workOutPlan.FifthExercise = " Pec Dec";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// informs user what leg exercise to complete and in what order
        /// </summary>
        public static void LegExercisesToComplete()
        {
            LegWorkout workOutPlan = new();

            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.FirstExercise = " Barbell Squat";
            workOutPlan.SecondExercise = " Leg Extensions";
            workOutPlan.ThirdExercise = " Leg Press";
            workOutPlan.FourthExercise = " Lying Leg Curls";
            workOutPlan.FifthExercise = " Walking Lunges";
        
            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// Informs user of what shoulder exercises to complete
        /// </summary>
        public static void ShoulderExercisesToComplete()
        {
            ShoulderWorkout workOutPlan = new();
            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.FirstExercise = " Barbell Shoulder Press";
            workOutPlan.SecondExercise = " Side Dumbbell raise";
            workOutPlan.ThirdExercise = " Front Dumbbell Raises";
            workOutPlan.FourthExercise = " Rear Pec Dec";
            workOutPlan.FifthExercise = " Dumbbell Shrugs";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        public static void BackExercisesToComplete()
        {
            BackWorkout workOutPlan = new();
            workOutPlan.NumberOfSets = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.FirstExercise = " Barbell BentOver Rows";
            workOutPlan.SecondExercise = " Cable Lat Pulldowns";
            workOutPlan.ThirdExercise = " Cable Close Grip Pulldowns";
            workOutPlan.FourthExercise = " Seated Cable Rows";
            workOutPlan.FifthExercise = " BodyWeight Pull Ups";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSets + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
            

        
       

    }

    
}
