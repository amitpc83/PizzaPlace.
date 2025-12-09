using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class HardCodedMenuService : IMenuService
    {
        public async ValueTask<Menu> GetMenuAsync()
        {

            return await new ValueTask<Menu>(
                new Menu
                {
                    Pizzas = new List<Pizza> {
                       new Pizza(1, "Pepperoni", 8.99M, Spiciness.Spicy),
                       new Pizza(2, "Margarita", 7.99M, Spiciness.None),
                       new Pizza(3, "Diabolo", 9.99M, Spiciness.Hot)
                    }
                }); 
        }
    }
}
