using OCPLibrary;
using SolidPrinsiple.SingleResponsibility;
using System;
using System.Collections.Generic;
 
using LiskovSubtitution;
using InterfaceSegregation;

namespace SolidPrinsiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice = 2;

            //Single Responsibility
            if (Choice == 0) {
                StandardMessages.WelcomeMessage();

                Person user = PersonDataCapture.Capture();

                if (!PersonValidator.Validate(user))
                {
                    StandardMessages.EndApplication();
                    return;
                }

                AccountGenerator.CreateAccount(user);
                StandardMessages.EndApplication();

            }

            //Open close
            if (Choice == 1) {

                List<IApplicantModel> application = new List<IApplicantModel> {
                    new PersonModel { FirstName = "Muhallidin", LastName = "Wali" },
                    new ManagerModel { FirstName = "Udzraina", LastName = "Wali" },
                    new ExecutiveModel { FirstName = "Erika", LastName = "Wali" }
                };

                List<EmployeeModel> employees = new  List<EmployeeModel>();
                //Account accountProcessore = new Account();

                foreach (var person in application) {
                    employees.Add(person.AccountProcessor.Create(person));
                }

                foreach (var emp in employees) {
                    Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } Is Manager { emp.IsManager } Is Executive { emp.IsExecutive }");
                }

                Console.ReadLine();


            }

            //Liskov Substitution
            if (Choice == 2) {

                Manager accountingVP = new Manager();
                accountingVP.FirstName = "Muhallidin";
                accountingVP.LastName = " Wali";
                accountingVP.CalculatePerHoursRate(4);

                Employee emp = new Manager();
                emp.FirstName = "Udzraina";
                emp.LastName = "Wali";
                emp.AssignManager(accountingVP);
                emp.CalculatePerHoursRate(2);

                Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hours.");
                Console.ReadLine();




            }

            //Interface Segregation
            if (Choice == 3) {
                IDVD  dvd = new DVD();
            }

            //Dependency Inversion
            if (Choice == 4)
            {
               Person owner = new Person { 
                    
               }
            }

        }
    }
}
