using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Recursion
    {
        public void calculateiterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }

        public void calculaterecursive(int n)
        {
            if (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                calculaterecursive(n - 1);
            }
        }

        
        static void Main(string[] args)
        {
            Recursion r = new Recursion();
            //r.calculateiterative(4);
            r.calculaterecursive(4);
            Console.ReadKey();
        }
    }
}
