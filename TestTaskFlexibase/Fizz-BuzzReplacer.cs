namespace TestTaskFlexibase
{
    internal class Fizz_BuzzReplacer : NumberReplacer
    {
        public Fizz_BuzzReplacer()
        {
            AddStrategy();
        }

        private protected void AddStrategy()
        {
            strategyList.Add(new Strategy("fizz", 3));
            strategyList.Add(new Strategy("buzz", 5));
        }



    }
}
