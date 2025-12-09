using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class ConsoleOrderService : IOrderService
    {
        public ValueTask PlaceOrder(ShoppingBasket shoppingBasket)
        {
            Console.WriteLine($"Placing order for {shoppingBasket.Customer.Name}");
            return new ValueTask();
        }
    }
}
