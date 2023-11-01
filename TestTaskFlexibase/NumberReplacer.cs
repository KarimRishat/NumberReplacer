namespace TestTaskFlexibase
{
    internal class NumberReplacer
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
    }
}
