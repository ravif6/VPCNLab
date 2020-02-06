using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] s = str.ToCharArray();
            int i = 0;
            while(i < s.Length)
            {
                if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
                {
                    Console.Write(s[i]);
                    
                }
                i++; 
            
            }
         
            Console.ReadKey();
        }
    }
}
