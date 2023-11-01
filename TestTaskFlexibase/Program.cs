namespace TestTaskFlexibase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            NumberReplacer replacer = new Fizz_BuzzReplacer();
            foreach (int i in list)
            {
                Console.Write($"{replacer.OutputString(i)}, ");
            }
        }
    }
}