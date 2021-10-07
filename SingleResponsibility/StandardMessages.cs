using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinsiple.SingleResponsibility
{
    public class StandardMessages
    {
        public static void WelcomeMessage() {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication() {
            Console.Write("Pres enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidatgionError(string fieldName) {
            Console.WriteLine($"You did not give us the valid {fieldName}!");
        
        }

    }
}
