using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] str = s.ToCharArray();
            Array.Sort(str);
            char k = str[0];
            
            for (int i = 0; i < str.Length; )
            {
                int count = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i]==str[j])
                    {
                        count++;
                    }
                    

                }
                Console.WriteLine("{0},{1}", str[i], count);
                i = i + count;
            }
            Console.ReadKey();
        }
    }
}
