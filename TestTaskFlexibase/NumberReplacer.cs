namespace TestTaskFlexibase
{
    public class NumberReplacer
    {
        private protected List<Strategy> strategyList = new List<Strategy>();
        public string OutputString(int num)
        {
            bool replaced = false;
            string result = "";
            foreach (Strategy strategy in strategyList)
            {
                if (strategy.NeedReplace(num))
                {
                    replaced = true;
                    result = String.Concat(result, strategy.Replace());
                    result += '-';
                }
            }
            return replaced == true ? result.Substring(0, result.Length - 1) : num.ToString();
        }

        public string ReplaceString(List<int> numbers)
        {
            if (numbers == null) throw new ArgumentNullException("numbers");
            string result = string.Empty;
            result = String.Concat(OutputString(numbers[0]));
            for (int i = 1; i < numbers.Count(); i++)
            {
                result = String.Concat(result, ", ");
                result = String.Concat(result, OutputString(numbers[i]));
            }
            return result;
        }

    }
}
