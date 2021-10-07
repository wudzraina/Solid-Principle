using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubtitution
{
    public class CEO : BaseEmployee, IManager
    {

        public override void CalculatePerHoursRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }
 

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm reviewing a direct report's performance!");
        }

        public void FireSomeone() {
            Console.WriteLine("Your're Fired!");
        }
       




    }
}
