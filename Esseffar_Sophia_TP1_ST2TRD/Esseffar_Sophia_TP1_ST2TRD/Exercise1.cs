using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esseffar_Sophia_TP1_ST2TRD
{
    internal class Exercise1
    {
        public static void Tables()
        {
            for (int i=1; i<11; i++)
            {
                for( int j=1; j<11; j++)
                {
                   
                    Console.WriteLine(i + "x" + j + "=" + i * j);
                }
            }
        }

        public static void Odd()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if ((i * j) % 2 != 0)
                    {
                        Console.WriteLine(i + "x" + j + "=" + i * j);
                    }
                    
                }
            }
        }

        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }

        public static void Display()
        {
            int N = AskUserForParameter();
            for (int i =1; i<11; i++)
            {
                Console.WriteLine(N + "x" + i + "=" + i * N);
            }
        }

    }
}
