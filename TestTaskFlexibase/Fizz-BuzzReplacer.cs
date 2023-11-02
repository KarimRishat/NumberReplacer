namespace TestTaskFlexibase
{
    public class Fizz_BuzzReplacer : NumberReplacer
    {
        public Fizz_BuzzReplacer()
        {
            AddStrategyFizzBuzz();
        }

        private protected void AddStrategyFizzBuzz()
        {
            AddStrategy("fizz", 3);
            AddStrategy("buzz", 5);
        }

    }
}
