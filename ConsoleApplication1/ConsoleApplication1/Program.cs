using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        public float sal = 763.73F;
    }
    public class person : Employee
    {
        public string name = "ramu";
    }
    public class Program
    {
       public static void Main(string[] args)
        {
            person p = new person();
            Console.WriteLine("name of the person :"+p.name);
            Console.WriteLine("salary :"+p.sal);

        }
    }
}
