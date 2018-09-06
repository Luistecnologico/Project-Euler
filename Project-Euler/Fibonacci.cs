using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Fibonacci
    {
        long Sum, x=0, y=1, z=0, numeroFinal;

        public Fibonacci(int max)
        {
            numeroFinal = max;
        }

        public void Fibon()
        {
            Console.Clear();
            Console.Write("0, 1, ");
            for (int i = 1; i < numeroFinal; i++)
            {
                z = x + y;
                x = y;
                y = z;
                    
                Console.Write(z + ", ");
            }
        }
    }
}
