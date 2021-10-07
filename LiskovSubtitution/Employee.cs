using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubtitution
{
    public class Employee : BaseEmployee, IManage
    {

         
        public IEmployee Manager { get; set; } = null;
        public virtual void AssignManager(IEmployee manager)
        {
            // Simulated doing other task - otherwise , this should be
            // a property set statement, not a method

            Manager = manager;
        }
         







    }
}
