using System;
namespace TemplateMethod
{
    public class VeggieHoagie : Hoagie
    {
        String[] veggies = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };
        String[] condiments = { "Oil", "Vinegar" };

        internal Boolean  CustomerWantsMeat() { return false; }
        internal Boolean  CustomerWantsCheese() { return false; }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding Condiments");
            foreach (var condiment in condiments){
                Console.Write(condiments + " ");
            }
        }


        internal override void AddVegetables()
        {
            Console.WriteLine("Adding Vegetables");
            foreach (var veggie in veggies){
                Console.Write(veggie + " ");
            }
        }

        internal override void AddMeat()
        {
        }

        internal override void AddCheese()
        {    
        }
    }
}

