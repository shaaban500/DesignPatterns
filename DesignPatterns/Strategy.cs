namespace DesignPatterns
{
    public interface IStrategy
    {
        void Execute();
    }

    public class StrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing strategy A");
        }
    }

    public class StrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Executing strategy B");
        }
    }

    public class StrategyContext
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

}

/*
 
// in the main program
// use simple factory to use these strategies

var context = new StrategyContext();

// Use the strategy A
context.SetStrategy(new ConcreteStrategyA());
context.ExecuteStrategy();

// Use the strategy B
context.SetStrategy(new ConcreteStrategyB());
context.ExecuteStrategy();

*/