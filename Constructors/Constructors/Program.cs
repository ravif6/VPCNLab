using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Programs
    {
        public Programs()
        {
            Console.WriteLine("an Instance created");
        }
        ~Programs()
        {
            Console.WriteLine("an Instance deleted");
        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Programs p = new Programs();
            GC.Collect();
            Console.Read();
        }
    }
}
