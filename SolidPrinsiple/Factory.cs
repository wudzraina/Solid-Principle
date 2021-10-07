using System;
using System.Collections.Generic;
using System.Text;
using f = DependencyInversion;
namespace SolidPrinsiple
{
    public class Factory
    {
        public static f.Person CreatePerson() {
            return new f.Person();
        }
    }
}
