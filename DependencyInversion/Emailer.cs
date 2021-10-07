﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Emailer
    {

        public void SendEmail(Person person, string message) {

            Console.WriteLine($"Simulating sending an email to { person.EmailAddress }");
        }

    }
}
