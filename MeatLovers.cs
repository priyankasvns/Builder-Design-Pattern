using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //This is the concrete builder class
    class MeatLovers : PizzaBuilder
    {
        public MeatLovers()
        {
            pizza = new Pizza("Meat Lovers Pizza");
        }

        public override void AddPizzaBase()
        {
            pizza["Base"] = "Thin Crust";
        }

        public override void AddSauces()
        {
            pizza["Sauces"] = "Pesto Sauce";
        }

        public override void AddCheese()
        {
            pizza["Cheese"] = "Parmesan Cheese";
        }

        public override void AddToppings()
        {
            pizza["Toppings"] = "all meat";
        }

        public override void BakingTime()
        {
            pizza["BakingTime"] = "35 Minutes";
        }
    }
}
