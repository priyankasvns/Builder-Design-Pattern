using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //This is the concrete builder class
    class BbqChicken : PizzaBuilder
    {
        public BbqChicken()
            {
                pizza = new Pizza("BBQ Chicken Pizza");
            }

            public override void AddPizzaBase()
            {
                pizza["Base"] = "Pizza bagel";
            }

            public override void AddSauces()
            {
                pizza["Sauces"] = "Garlic Ranch Sauce";
            }

            public override void AddCheese()
            {
                pizza["Cheese"] = "Parmesan Cheese";
            }

            public override void AddToppings()
            {
                pizza["Toppings"] = "BBQ Chicken";
            }

            public override void BakingTime()
            {
                pizza["BakingTime"] = "30 Minutes";
            }
    }
}
