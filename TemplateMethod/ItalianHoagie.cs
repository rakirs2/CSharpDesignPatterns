using System;
namespace TemplateMethod
{
    public class ItalianHoagie : Hoagie
    {
        String[] meats = { "Salami", "Pepperoni", "Capicola" };
        String[] cheeses = { "Provolone" };
        String[] veggies = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        String[] condiments = { "Oil", "Vinegar" };

        internal override void AddMeat()
        {
            Console.WriteLine("Adding Meat: ");
            foreach (var meat in meats)
            {
                Console.Write(meat + " ");
            }
        }

        internal  override void AddCheese()
        {
            Console.WriteLine("Adding Cheese: ");
            foreach (var cheese in cheeses)
            {
                Console.Write(cheese + " ");
            }
        }

        internal  override void AddVegetables()
        {
            Console.WriteLine("Adding Vegetables: ");
            foreach (var veggie in veggies)
            {
                Console.Write(veggie + " ");
            }
        }

        internal  override void AddCondiments()
        {
            Console.WriteLine("Adding Condiments: ");
            foreach (var condiment in condiments)
            {
                Console.Write(condiment + " ");
            }
        }
    }

}

