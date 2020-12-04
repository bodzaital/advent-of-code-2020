using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace advent_of_code
{
    public static class Day4
    {
        public static void Part1()
        {
            string[] list;

            string raw;
            using StreamReader sr = new StreamReader("day4-input.txt");
            raw = sr.ReadToEnd();

            list = raw.Replace("\r\n\r\n", "ű").Replace("\r\n", " ").Split("ű");

            int sum = 0;

            foreach (string item in list)
            {
                if (item.Contains("byr:") &&
                    item.Contains("iyr:") &&
                    item.Contains("eyr:") &&
                    item.Contains("hgt:") &&
                    item.Contains("hcl:") &&
                    item.Contains("ecl:") &&
                    item.Contains("pid:"))
                {
                    sum++;
                }
            }

            Console.WriteLine(sum);
        }

        public static void Part2()
        {
            string[] list;

            string raw;
            using StreamReader sr = new StreamReader("day4-input.txt");
            raw = sr.ReadToEnd();

            list = raw.Replace("\r\n\r\n", "ű").Replace("\r\n", " ").Split("ű");

            int sum = 0;

            foreach (string item in list)
            {
                if (item.Contains("byr:") &&
                    item.Contains("iyr:") &&
                    item.Contains("eyr:") &&
                    item.Contains("hgt:") &&
                    item.Contains("hcl:") &&
                    item.Contains("ecl:") &&
                    item.Contains("pid:"))
                {
                    int validscore = 0b0000000;

                    string[] passport = item.Split(" ");
                    foreach (string keyval_string in passport)
                    {
                        string[] keyval = keyval_string.Split(":");

                        if (keyval[0] == "byr" &&
                            keyval[1].Length == 4 &&
                            int.TryParse(keyval[1], out int byr) &&
                            byr >= 1920 && byr <= 2002)
                        {
                            validscore += 0b1000000;
                        }

                        if (keyval[0] == "iyr" &&
                            keyval[1].Length == 4 &&
                            int.TryParse(keyval[1], out int iyr) &&
                            iyr >= 2010 && iyr <= 2020)
                        {
                            validscore += 0b0100000;
                        }

                        if (keyval[0] == "eyr" &&
                            keyval[1].Length == 4 &&
                            int.TryParse(keyval[1], out int eyr) &&
                            eyr >= 2020 && eyr <= 2030)
                        {
                            validscore += 0b0010000;
                        }

                        if (keyval[0] == "hgt" && keyval[1].Contains("cm"))
                        {

                            string number = keyval[1].Substring(0, keyval[1].Length - 2);
                            if (int.TryParse(number, out int hgt_cm) &&
                                hgt_cm >= 150 && hgt_cm <= 193)
                            {
                                validscore += 0b0001000;
                            }
                        }

                        if (keyval[0] == "hgt" && keyval[1].Contains("in"))
                        {
                            string number = keyval[1].Substring(0, keyval[1].Length - 2);
                            if (int.TryParse(number, out int hgt_in) &&
                                hgt_in >= 59 && hgt_in <= 76)
                            {
                                validscore += 0b0001000;
                            }
                        }


                        if (keyval[0] == "hcl" &&
                            keyval[1][0] == '#' &&
                            keyval[1].Length == 7)
                        {
                            char[] valids = new char[] {
                                    '0', '1', '2', '3', '4', '5',
                                    '6', '7', '8', '9', 'a', 'b',
                                    'c', 'd', 'e', 'f', '#' };

                            if (keyval[1].All(x => valids.Contains(x)))
                            {
                                validscore += 0b0000100;
                            }
                        }

                        if (keyval[0] == "ecl" &&
                            new string[] { "amb", "blu", "brn", "gry",
                            "grn", "hzl", "oth" }.Any(x => x == keyval[1]))
                        {
                            validscore += 0b0000010;
                        }

                        if (keyval[0] == "pid" &&
                            keyval[1].Length == 9 &&
                            int.TryParse(keyval[1], out int pid))
                        {
                            validscore += 0b0000001;
                        }
                    }

                    if (validscore == 0b1111111)
                    {
                        sum++;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
