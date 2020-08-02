using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{

    //This is the abstract builder class
    abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza Pizza
        {
            get => this.pizza;
        }

        public abstract void AddPizzaBase();
        public abstract void AddSauces();
        public abstract void AddCheese();
        public abstract void AddToppings();
        public abstract void BakingTime();

    }
    
}
