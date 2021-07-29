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
    }
}
