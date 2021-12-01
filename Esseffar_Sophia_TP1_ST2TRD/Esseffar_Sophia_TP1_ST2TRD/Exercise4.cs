using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esseffar_Sophia_TP1_ST2TRD
{
    internal class Exercise4
    {
        //1 et 2
        public static void Square()
        {
            Console.WriteLine("Please write two numbers separated with a space and press enter :");

            try {
                string[] values = Console.ReadLine().Split();

                int n = int.Parse(values[0]);
                int m = int.Parse(values[1]);

                Console.Write("0");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("0");

                int count = 0;
                for (int j = 0; j < m - 2; j++)
                {
                    
                    Console.Write("|");
                    for (int k = 0; k < n - 2; k++)
                    {
                    
                        if (count % 3 == 0)
                        {
                            Console.Write("*");
                        }else
                            Console.Write(" ");
                        count++;
                    }
                    Console.WriteLine("|");
                }

                Console.Write("0");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine("0");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        
    }
}
