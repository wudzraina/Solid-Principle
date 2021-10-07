﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OCPLibrary
{
    public class PersonModel : IApplicantModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount AccountProcessor { get; set; } = new Account();

    }
}
