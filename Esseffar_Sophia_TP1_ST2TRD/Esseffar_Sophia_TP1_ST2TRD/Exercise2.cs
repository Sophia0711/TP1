using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esseffar_Sophia_TP1_ST2TRD
{
    internal class Exercise2
    {
        //1
        public static void Prime()
        {
            Console.WriteLine(2);
            for (int i = 3; i < 100; i++)
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                   
                    else if (i == j + 1)
                        Console.WriteLine(i);

                }
        }
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        //2
        public static int Fibonacci()
        {
            int n = AskUserForParameter();

            int []l = new int[n + 2];

            l[0] = 0;
            l[1] = 1;

            for (int i = 2; i<=n; i++)
            {
                l[i] = l[i - 1] + l[i - 2]
;           }

            Console.WriteLine(l[n]);
            return l[n];

        }
    
        //3
        public static void Factorial()
        {
            int n = AskUserForParameter();

            int res = 1;
            if (n == 1)
            {
                Console.WriteLine(1);
                
            }else
            for (int i=2; i<=n; i++)
            {
                res = res*i;
            }

            Console.WriteLine(res);
        }

        public static int Recursive(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
                return n * Recursive(n - 1);
        }

    }
}
