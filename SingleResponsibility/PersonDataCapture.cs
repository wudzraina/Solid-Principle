using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinsiple.SingleResponsibility
{
   public class PersonDataCapture
    {
        public static Person Capture() {

            Person output = new Person();

            Console.Write("What is your First Name:");
            output.FirstName = Console.ReadLine();

            Console.Write("What is you last name");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
