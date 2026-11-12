using System;
using System.Collections.Generic;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNWD(12, 18));
        }

        static uint GetNWD(uint a, uint b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            return a;
        }
    };
}