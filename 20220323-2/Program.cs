using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220323_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[20];
            fib[0] = 1;
            fib[1] = 1;
            for (int i = 2; i < fib.Length; i++)
                fib[i] = fib[i-1] +　fib[i-2];
            for (int i = 0; i < fib.Length; i++)
                Console.WriteLine(fib[i]);
            Console.ReadLine();
        }
    }
}
