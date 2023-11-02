﻿namespace TestTaskFlexibase
{
    internal class Program
    {
        static List<int> InputNumbers()
        {

            string input = Console.ReadLine();
            if(!input.Equals(String.Empty))
            {
                input = input.Trim();
                List<int> nums = input.Split(',').Select(x => int.Parse(x)).ToList();
                return nums;
            }else throw new ArgumentNullException(nameof(input));
        }
        static void Main(string[] args)
        {
            List<int> list = InputNumbers();
            NumberReplacer replacer = new Fizz_BuzzReplacer();
            Console.WriteLine(replacer.ReplaceString(list));
        }
    }
}