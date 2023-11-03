using MuzzGuzz;
using TestTaskFlexibase;

namespace GoodBoy
{
    internal class Program
    {

        static List<int> InputNumbers()
        {

            string input = Console.ReadLine();
            if (!input.Equals(String.Empty))
            {
                input = input.Trim();
                List<int> nums = input.Split(',').Select(x => int.Parse(x)).ToList();
                return nums;
            }
            else return null;
        }

        static void Main(string[] args)
        {
            List<int> list = InputNumbers();
            NumberReplacer replacer = new Good_BoyReplacer();
            Console.WriteLine(replacer.ReplaceString(list));
        }
    }
}