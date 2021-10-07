using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinsiple.SingleResponsibility
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person) {
            Console.WriteLine($"Your name is {person.FirstName.Substring(0, 1)} {person.LastName}");
        }
    }
}
