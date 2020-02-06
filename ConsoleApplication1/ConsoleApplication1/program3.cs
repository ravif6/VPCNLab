using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Detail : Names
    {
        public String dept = "ComputerScienceEngineering";
    }
    public class Names : SirName
    {
        public String name = "raviKIran";
    }
    public class SirName
    {
        public string sirname = "yasa";
    }

    class program3
    {
        public static void Main(string[] args)
        {
            Detail d = new Detail();
            Console.WriteLine("name of department " + d.dept);
            Console.WriteLine("name of the employee " + d.name);
            Console.WriteLine("sirName of the employee " + d.sirname);
        }
    }
}
