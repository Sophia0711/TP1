using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esseffar_Sophia_TP1_ST2TRD
{
    internal class Exercise3
    {
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }

        public static void Function()
        {
            for(int i=-3; i<=3; i++)
            {
                try
                {
                    double res = 10 / PowerFunction(i);
                    Console.WriteLine(res);
                }
                catch(DivideByZeroException e) {
                    Console.WriteLine(e.Message);
                }
                    
            }
        }
    }
}
