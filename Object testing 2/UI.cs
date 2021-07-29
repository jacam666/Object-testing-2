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
            Console.WriteLine("Please enter your name.");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + " and welcome to your personalised workout plan");
        }
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


    }

    
}
