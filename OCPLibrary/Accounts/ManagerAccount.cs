﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class ManagerAccount : IAccount
    {
        public EmployeeModel Create(IApplicantModel person)
        {

            EmployeeModel output = new EmployeeModel();
            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acmecor.com";

            output.IsManager = true;

            return output;
        }
    }
}
