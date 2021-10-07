using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubtitution
{
    public class Manager : Employee
    {
        public override void CalculatePerHoursRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview() {
            Console.WriteLine("I'm reviewing a direct report's perfomance!");
        }
    }
}
