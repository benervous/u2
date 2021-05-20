using System;
using System.IO;
using System.Linq;
using System.Text;

namespace u2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            Console.WriteLine(facade.Transform(1, "RED House")); 
        }
    }

    
}

