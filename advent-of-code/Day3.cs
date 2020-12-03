using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code
{
    public static class Day3
    {
        public static void Part1()
        {
            string[] lines = File.ReadAllLines("day3-input.txt");

            int x = 0;
            int y = 0;

            int sumTrees = 0;

            while (y < lines.Length - 1)
            {
                x += 3;
                y++;

                int real_x = x % lines[0].Length;

                if (lines[y][real_x] == '#')
                {
                    sumTrees++;
                }
            }

            Console.WriteLine(sumTrees);
        }

        public static void Part2()
        {
            string[] lines = File.ReadAllLines("day3-input.txt");

            long mult = 1;

            int x = 0;
            int y = 0;

            int sumTrees = 0;

            while (y < lines.Length - 1)
            {
                x += 1;
                y += 1;

                int real_x = x % lines[0].Length;

                if (lines[y][real_x] == '#')
                {
                    sumTrees++;
                }
            }

            mult *= sumTrees;

            x = 0;
            y = 0;

            sumTrees = 0;

            while (y < lines.Length - 1)
            {
                x += 3;
                y += 1;

                int real_x = x % lines[0].Length;

                if (lines[y][real_x] == '#')
                {
                    sumTrees++;
                }
            }

            mult *= sumTrees;

            x = 0;
            y = 0;

            sumTrees = 0;

            while (y < lines.Length - 1)
            {
                x += 5;
                y += 1;

                int real_x = x % lines[0].Length;

                if (lines[y][real_x] == '#')
                {
                    sumTrees++;
                }
            }

            mult *= sumTrees;

            x = 0;
            y = 0;

            sumTrees = 0;

            while (y < lines.Length - 1)
            {
                x += 7;
                y += 1;

                int real_x = x % lines[0].Length;

                if (lines[y][real_x] == '#')
                {
                    sumTrees++;
                }
            }

            mult *= sumTrees;

            x = 0;
            y = 0;

            sumTrees = 0;

            while (y < lines.Length - 1)
            {
                x += 1;
                y += 2;

                int real_x = x % lines[0].Length;

                if (lines[y][real_x] == '#')
                {
                    sumTrees++;
                }
            }

            mult *= sumTrees;

            Console.WriteLine(mult);
        }
    }
}
