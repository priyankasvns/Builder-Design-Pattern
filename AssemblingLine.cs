using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class AssemblingLine
    {
        //This is the director participant in the builder pattern
        public void AssemblePizza(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.AddPizzaBase();
            pizzaBuilder.AddSauces();
            pizzaBuilder.AddCheese();
            pizzaBuilder.AddToppings();
            pizzaBuilder.BakingTime();

        }
    }
}
