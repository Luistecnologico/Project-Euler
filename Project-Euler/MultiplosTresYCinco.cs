using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class MultiplosTresYCinco
    {
        int NumeroFinal;

        public MultiplosTresYCinco(int num)
        {
            NumeroFinal = num;
        }

        public void Multiplos()
        {
            Console.Clear();
            for(int i = 0; i <= NumeroFinal; i++)
            {
                if ((i % 3 == 0) || (i % 5) == 0)
                    Console.Write(i + ", ");
            }
        }
    }
}
