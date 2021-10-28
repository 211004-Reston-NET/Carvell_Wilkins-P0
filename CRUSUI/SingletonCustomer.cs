using CRUSModels;

namespace CRUSUI
{
    public class SingletonCustomer
    {
        public static Customer customer = new Customer();
        public static Order order = new Order();
        public static string location { get; set; }
        
    }
}