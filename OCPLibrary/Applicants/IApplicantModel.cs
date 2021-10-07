﻿namespace OCPLibrary
{
    public interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount AccountProcessor { get; set; } 

    }
}