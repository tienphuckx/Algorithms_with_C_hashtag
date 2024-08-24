using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Factorial
    {
        public int factorialiterative(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        public int factorialrecursive(int n)
        {
            if (n == 0)
                return 1;
            return factorialrecursive(n - 1) * n;
        }

        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            Console.WriteLine("Factorial: " + f.factorialiterative(5));
            Console.WriteLine("Factorial: " + f.factorialrecursive(5));
            Console.ReadKey();
        }
    }
}
