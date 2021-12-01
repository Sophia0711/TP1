using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esseffar_Sophia_TP1_ST2TRD
{
    internal class Exercise5
    {

        public static void Tree() {

            Console.WriteLine("Please write a number between 3 and 20 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);

            if (result <= 20 && result >= 3)
            {
  
                for(int j=0; j<result; j++)
                {
                    Console.Write("*".PadLeft(result - j));
                    Console.WriteLine(new String('*', 2 * j));
                }

                Console.Write("|".PadLeft(((result*2)-2) / 2));
                Console.Write("|".PadLeft(2));
            }
            else
                Console.WriteLine("Wrong Number...");

        }

        public static void Nicetree()
        {
            Console.WriteLine("Please write a number between 3 and 20 and press enter :");
            int.TryParse(Console.ReadLine(), out var result);

            if (result <= 20 && result >= 3)
            {

                for (int j = 0; j < result; j++)
                {
                    Console.Write("*".PadLeft(result - j));
                    for(int k=0; k<2*j; k++)
                    {
                        Random aleatoire = new Random();
                        int choice = aleatoire.Next(6);

                        if (choice == 1 || choice == 3)
                        {
                            Console.Write("i");
                        }
                        else if (choice == 2)
                        {
                            Console.Write("o");
                        }
                        else
                            Console.Write("*");
                    }
                    Console.WriteLine("");
                }

                Console.Write("|".PadLeft(((result * 2) - 2) / 2));
                Console.Write("|".PadLeft(2));
            }
            else
                Console.WriteLine("Wrong Number...");
        }

    }
}
