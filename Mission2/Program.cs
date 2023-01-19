using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");

            int rollNum = int.Parse(Console.ReadLine());

            int[] counts = new int[11];

            Random rnd = new Random();
            for (int i = 0; i < rollNum; i++)
            {
                int dieNum1 = rnd.Next(1, 7);
                int dieNum2 = rnd.Next(1, 7);

                counts[dieNum1 + dieNum2-2]++;
            }

            for (int i = 0; i < 11; i++)
            {
                double percentage = (counts[i] / (double)rollNum) * 100;

                Console.Write(i + 2 + ": ");

                for (int e = 0; e < percentage; e++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        
        }
    }
}
