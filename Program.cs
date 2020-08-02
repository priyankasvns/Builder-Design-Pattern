using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder builder;

            AssemblingLine newShop = new AssemblingLine();

            Console.WriteLine("Making pizza 1");
            Console.WriteLine("------------------------------");

            builder = new GrilledChickenPizza();
            newShop.AssemblePizza(builder);
            builder.Pizza.DisplayPizza();

            Console.WriteLine("\nMaking pizza 2");
            Console.WriteLine("------------------------------");

            builder = new BbqChicken();
            newShop.AssemblePizza(builder);
            builder.Pizza.DisplayPizza();

            Console.WriteLine("\nMaking pizza 3");
            Console.WriteLine("------------------------------");

            builder = new MeatLovers();
            newShop.AssemblePizza(builder);
            builder.Pizza.DisplayPizza();

            Console.ReadLine();

        }
    }
}
