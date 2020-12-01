using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace advent_of_code
{
    public static class Day1
    {
        public static void Part1()
        {
            string[] list = File.ReadAllLines("day1-input.txt");

            for (int i = 0; i < list.Length; i++)
            {
                int number1 = int.Parse(list[i]);
                for (int j = 0; j < list.Length; j++)
                {
                    int number2 = int.Parse(list[j]);

                    if (number1 + number2 == 2020)
                    {
                        Console.WriteLine(number1 * number2);
                        return;
                    }
                }
            }
        }

        public static void Part2()
        {
            string[] list = File.ReadAllLines("day1-input.txt");

            for (int i = 0; i < list.Length; i++)
            {
                int number1 = int.Parse(list[i]);

                for (int j = 0; j < list.Length; j++)
                {
                    int number2 = int.Parse(list[j]);

                    for (int k = 0; k < list.Length; k++)
                    {
                        int number3 = int.Parse(list[k]);

                        if (number1 + number2 + number3 == 2020)
                        {
                            Console.WriteLine(number1 * number2 * number3);
                            return;
                        }
                    }
                }
            }
        }
    }
}
