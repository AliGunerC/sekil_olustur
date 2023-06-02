using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sekil_olustur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            for (int i = 1; i <=7; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");


            }
            Console.WriteLine();

            for (int a = 7; a >= 1; a--)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }

            Console.WriteLine();
            

            for(int c = 1; c <= 11; c+=2)
            {
                for (int f = c; f <= 11; f++)
                {
                    Console.Write(" ");
                }

                for (int d = 0; d < c ; d++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine("");

            }





























            Console.ReadLine();

        }
    }
}
