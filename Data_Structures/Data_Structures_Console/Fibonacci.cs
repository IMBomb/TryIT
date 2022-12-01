using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Console
{
    class Fibonacci
    {
        public int FibonacciCalc(int n)// ravlyk zolotogo peretynu
        {

            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            int f = FibonacciCalc(n - 1) + FibonacciCalc(n - 2);
            // 
            return f;
        }
    }
}
