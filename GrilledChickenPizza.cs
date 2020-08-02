using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //This is the concrete builder class
    class GrilledChickenPizza : PizzaBuilder
    {
        public GrilledChickenPizza()
        {
            pizza = new Pizza("Grilled Chicken Pizza");
        }

        public override void AddPizzaBase()
        {
            pizza["Base"] = "Fresh Pan Dough";
        }

        public override void AddSauces()
        {
            pizza["Sauces"] = "White Garlic Sauce";
        }

        public override void AddCheese()
        {
            pizza["Cheese"] = "Cheddar Cheese";
        }

        public override void AddToppings()
        {
            pizza["Toppings"] = "Chicken";
        }

        public override void BakingTime()
        {
            pizza["BakingTime"] = "20 Minutes";
        }

    }
}
