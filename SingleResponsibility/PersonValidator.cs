using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinsiple.SingleResponsibility
{
    public class PersonValidator
    {

        public static bool Validate(Person person) {

            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidatgionError("first Name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidatgionError("last Name");
                return false;
            }

            return true;

        }
    }
}
