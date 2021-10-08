using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Logger
    {
        public void Log(string message) {
            Console.WriteLine($"White to Console: { message }");
        }
    }
}
