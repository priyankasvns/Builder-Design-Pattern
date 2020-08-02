using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Pizza
    {
        // This is the product class 
        private string pizzaName;

        Dictionary<string,string> ingredientsList = new Dictionary<string, string>();

        public string PizzaName
        {
            get => this.pizzaName;
            set => this.pizzaName = value;
        }

        public string this[string key]
        {
            get => ingredientsList[key];
            set => ingredientsList[key] = value;
        }
        
        public Pizza(string pizzaName)
        {
            this.PizzaName = pizzaName;
        }

        public void DisplayPizza()
        {
            Console.WriteLine("Pizza Name: {0} ", this.PizzaName );
            Console.WriteLine("Base: {0}", (ingredientsList["Base"]));
            Console.WriteLine("Sauces: {0}", (ingredientsList["Sauces"]));
            Console.WriteLine("Cheese: {0}", (ingredientsList["Cheese"]));
            Console.WriteLine("Toppings: {0}", (ingredientsList["Toppings"]));
            Console.WriteLine("BakingTime: {0}", (ingredientsList["BakingTime"]));
            
        }
    }
}
