using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace advent_of_code
{
    public static class Day2
    {
        public static void Part1()
        {
            string[] list = File.ReadAllLines("day2-input.txt");

            int correct_passwords = 0;

            for (int i = 0; i < list.Length; i++)
            {
                string[] line_split = list[i].Split(':');
                string[] rule_split = line_split[0].Split(' ');
                string[] occurences = rule_split[0].Split('-');

                int minimum = int.Parse(occurences[0]);
                int maximum = int.Parse(occurences[1]);

                char character = rule_split[1][0];

                string password = line_split[1].Trim();

                int real_occurence = password.Count(x => x == character);

                if (real_occurence >= minimum && real_occurence <= maximum)
                {
                    correct_passwords++;
                }
            }

            Console.WriteLine(correct_passwords);
        }

        public static void Part2()
        {
            string[] list = File.ReadAllLines("day2-input.txt");

            int correct_passwords = 0;

            for (int i = 0; i < list.Length; i++)
            {
                string[] line_split = list[i].Split(':');
                string[] rule_split = line_split[0].Split(' ');
                string[] occurences = rule_split[0].Split('-');

                int position1 = int.Parse(occurences[0]);
                int position2 = int.Parse(occurences[1]);

                char character = rule_split[1][0];

                string password = line_split[1].Trim();

                if (password[position1 - 1] == character ^ password[position2 - 1] == character)
                {
                    correct_passwords++;
                }
            }

            Console.WriteLine(correct_passwords);
        }
    }
}
