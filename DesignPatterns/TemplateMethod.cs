namespace DesignPatterns
{
    public abstract class AbstractClass
    {
        protected void Operation1()
        {
            Console.WriteLine("Operation1");
        }

        protected abstract void Operations2();

        protected void Operation3()
        {
            Console.WriteLine("Operation3");
        }
    }

    public class ConcreteClass1 : AbstractClass
    {
        protected override void Operations2()
        {
            Console.WriteLine("Implemented Operation2");
        }
    }

    public class ConcreteClass2 : AbstractClass
    {
        protected override void Operations2()
        {
            Console.WriteLine("Implemented Operation2");
        }
    }
}

