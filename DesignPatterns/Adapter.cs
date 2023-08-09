namespace DesignPatterns
{
    public interface IClientTarget
    {
        string GetRequest();
    }

    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request";
        }
    }

    public class Adapter : IClientTarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            return _adaptee.GetSpecificRequest();
        }
    }
}
