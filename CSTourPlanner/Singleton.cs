using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTourPlanner
{
    public class Singleton
    {

        public M.Tour Tour { get; set; }

        private static Singleton singletonObject = new Singleton();
        
        private Singleton() { }//Not Constructable...

        public static Singleton GetLastObject()
        {
            return singletonObject;
        }

    }
}
