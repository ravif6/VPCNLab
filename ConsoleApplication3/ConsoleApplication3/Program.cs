using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            
            int[,] arr=new int[m,n];
            k = arr[0, 0];
            for (int i=0;i< m; i++)
            {
                for(int j=0;j< n; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (k > arr[i, j])
                    {
                        k = arr[i, j];
                    }
                }
            }
            Console.WriteLine(k);
            Console.ReadKey();
                }
    }
}
