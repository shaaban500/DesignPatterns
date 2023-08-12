namespace DesignPatterns
{
    public interface IOrderProcess
    {
        public void Process();
    }
    public class OrderProcess : IOrderProcess
    {
        public void Process()
        {
            Console.WriteLine("Do Something");
        }
    }


    public class OrderProcessDecorator : IOrderProcess
    {
        private IOrderProcess _orderProcess;
        public OrderProcessDecorator(IOrderProcess orderProcess)
        {
            _orderProcess = orderProcess;
        }

        public void Process()
        {
            _orderProcess.Process();
            
            // extension
            // put more implementation here 
        }
    }
}
