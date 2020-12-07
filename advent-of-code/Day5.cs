using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace advent_of_code
{
    public static class Day5
    {
        public static void Part1()
        {
            string[] lines = File.ReadAllLines("day5-input.txt");

            int highest_id = -1;

            foreach (string line in lines)
            {
                int row_start = 0;
                int row_end = 127;

                for (int i = 0; i < 7; i++)
                {
                    if (line[i] == 'F')
                    {
                        row_end = (int)Math.Floor((decimal)(row_end - row_start) / 2) + row_start;
                    }
                    else
                    {
                        row_start = (int)Math.Ceiling((decimal)(row_end - row_start) / 2) + row_start;
                    }
                }

                int col_start = 0;
                int col_end = 7;

                for (int i = 7; i < 10; i++)
                {
                    if (line[i] == 'L')
                    {
                        col_end = (int)Math.Floor((decimal)(col_end - col_start) / 2) + col_start;
                    }
                    else
                    {
                        col_start = (int)Math.Ceiling((decimal)(col_end - col_start) / 2) + col_start;
                    }
                }

                int id = row_start * 8 + col_start;

                highest_id = id > highest_id ? id : highest_id;
            }

            Console.WriteLine(highest_id);
        }

        public static void Part2()
        {
            string[] lines = File.ReadAllLines("day5-input.txt");

            List<int> ids = new List<int>();

            foreach (string line in lines)
            {
                int row_start = 0;
                int row_end = 127;

                for (int i = 0; i < 7; i++)
                {
                    if (line[i] == 'F')
                    {
                        row_end = (int)Math.Floor((decimal)(row_end - row_start) / 2) + row_start;
                    }
                    else
                    {
                        row_start = (int)Math.Ceiling((decimal)(row_end - row_start) / 2) + row_start;
                    }
                }

                int col_start = 0;
                int col_end = 7;

                for (int i = 7; i < 10; i++)
                {
                    if (line[i] == 'L')
                    {
                        col_end = (int)Math.Floor((decimal)(col_end - col_start) / 2) + col_start;
                    }
                    else
                    {
                        col_start = (int)Math.Ceiling((decimal)(col_end - col_start) / 2) + col_start;
                    }
                }

                int id = row_start * 8 + col_start;

                ids.Add(id);
            }

            ids = ids.OrderBy(x => x).ToList();

            for (int i = 0; i < ids.Count - 1; i++)
            {
                if (ids[i] + 1 != ids[i + 1])
                {
                    Console.WriteLine(ids[i] + 1);
                }
            }
        }
    }
}
