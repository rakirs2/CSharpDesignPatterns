namespace TemplateMethod;

public class ItalianHoagie : Hoagie
{
    private readonly string[] cheeses = { "Provolone" };
    private readonly string[] condiments = { "Oil", "Vinegar" };
    private readonly string[] meats = { "Salami", "Pepperoni", "Capicola" };
    private readonly string[] veggies = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };

    internal override void AddMeat()
    {
        Console.WriteLine("Adding Meat: ");
        foreach (var meat in meats) Console.Write(meat + " ");
    }

    internal override void AddCheese()
    {
        Console.WriteLine("Adding Cheese: ");
        foreach (var cheese in cheeses) Console.Write(cheese + " ");
    }

    internal override void AddVegetables()
    {
        Console.WriteLine("Adding Vegetables: ");
        foreach (var veggie in veggies) Console.Write(veggie + " ");
    }

    internal override void AddCondiments()
    {
        Console.WriteLine("Adding Condiments: ");
        foreach (var condiment in condiments) Console.Write(condiment + " ");
    }
}