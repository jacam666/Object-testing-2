using System;
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

            workOutPlan.NumberOfSetsPerWOrkout = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.RestBetweenSets = 60;

            Console.WriteLine("The number of sets that are required are " + workOutPlan.NumberOfSetsPerWOrkout + " sets per workout");
            Console.WriteLine("The amount of Reps per set are " + workOutPlan.NumberOfRepsPerSets);
            Console.WriteLine("You are allowed " + workOutPlan.RestBetweenSets + " seconds rest between sets.");
        }
        /// <summary>
        /// informs user of what chest exercise they need to compete and in what order
        /// </summary>
        public static void ChestExercisesToComplete()
        {
            ChestWorkout workOutPlan = new();

            workOutPlan.NumberOfSetsPerWOrkout = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.NumberOfSetsPerExercise = 4;
            workOutPlan.FirstExercise = "Bench Press";
            workOutPlan.SecondExercise = "Incline Bench";
            workOutPlan.ThirdExercise = " Cable Flyes";
            workOutPlan.FourthExercise = " Incline Dumbbell Flyes";
            workOutPlan.FifthExercise = " Pec Dec";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// informs user what leg exercise to complete and in what order
        /// </summary>
        public static void LegExercisesToComplete()
        {
            LegWorkout workOutPlan = new();

            workOutPlan.NumberOfSetsPerWOrkout = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.NumberOfSetsPerExercise = 4;
            workOutPlan.FirstExercise = " Barbell Squat";
            workOutPlan.SecondExercise = " Leg Extensions";
            workOutPlan.ThirdExercise = " Leg Press";
            workOutPlan.FourthExercise = " Lying Leg Curls";
            workOutPlan.FifthExercise = " Walking Lunges";
        
            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// Informs user of what shoulder exercises to complete
        /// </summary>
        public static void ShoulderExercisesToComplete()
        {
            ShoulderWorkout workOutPlan = new();
            workOutPlan.NumberOfSetsPerWOrkout = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.NumberOfSetsPerExercise = 4;
            workOutPlan.FirstExercise = " Barbell Shoulder Press";
            workOutPlan.SecondExercise = " Side Dumbbell raise";
            workOutPlan.ThirdExercise = " Front Dumbbell Raises";
            workOutPlan.FourthExercise = " Rear Pec Dec";
            workOutPlan.FifthExercise = " Dumbbell Shrugs";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// Informs user of what back exercises to complete
        /// </summary>
        public static void BackExercisesToComplete()
        {
            BackWorkout workOutPlan = new();
            workOutPlan.NumberOfSetsPerWOrkout = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.NumberOfSetsPerExercise = 4;
            workOutPlan.FirstExercise = " Barbell BentOver Rows";
            workOutPlan.SecondExercise = " Cable Lat Pulldowns";
            workOutPlan.ThirdExercise = " Cable Close Grip Pulldowns";
            workOutPlan.FourthExercise = " Seated Cable Rows";
            workOutPlan.FifthExercise = " BodyWeight Pull Ups";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// Informs user of what arm exercises to complete
        /// </summary>
        public static void ArmExercisesToComplete()
        {
            ArmWorkout workOutPlan = new();
            workOutPlan.NumberOfSetsPerWOrkout = 20;
            workOutPlan.NumberOfRepsPerSets = 10;
            workOutPlan.NumberOfSetsPerExercise = 4;
            workOutPlan.FirstExercise = " Dumbbell Curls";
            workOutPlan.SecondExercise = " Close Grip Bench";
            workOutPlan.ThirdExercise = " Preacher Curls";
            workOutPlan.FourthExercise = " Cable Tricep Pushdown";
            workOutPlan.FifthExercise = " Barbell Curls";

            Console.WriteLine("First exercise to complete : " + workOutPlan.FirstExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Second exercise to complete : " + workOutPlan.SecondExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Third exercise to complete : " + workOutPlan.ThirdExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fourth exercise to complete : " + workOutPlan.FourthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
            Console.WriteLine("Fifth exercise to complete : " + workOutPlan.FifthExercise + " : " + workOutPlan.NumberOfSetsPerExercise + " sets of " + workOutPlan.NumberOfRepsPerSets + " reps per set.");
        }
        /// <summary>
        /// informs user of what bodypart Workout they are to complete
        /// </summary>
        public static void ChesWorkouttHeadline()
        {
            Console.WriteLine("CHEST WORKOUT :");
        }
        /// <summary>
        /// Informs user of what  bodypart workout they are to complete
        /// </summary>
        public static void LegWorkoutHeadline()
        {
            Console.WriteLine("LEG WORKOUT :");
        }
        /// <summary>
        /// Informs user of what bodypart they are to complete
        /// </summary>
        public static void ShoulderWorkoutHeadline()
        {
            Console.WriteLine("SHOULDER WORKOUT");
        }
        /// <summary>
        ///  Informs user of what bodypart they are to complete
        /// </summary>
        public static void BackWorkoutHeadline()
        {
            Console.WriteLine("BACK WORKOUT");
        }
        /// <summary>
        ///  Informs user of what bodypart they are to complete
        /// </summary>
        public static void ArmWorkOutHeadline()
        {
            Console.WriteLine("ARM WORKOUT");
        }                   
    }    
}
