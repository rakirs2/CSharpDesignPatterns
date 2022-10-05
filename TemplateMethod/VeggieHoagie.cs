namespace TemplateMethod;

public class VeggieHoagie : Hoagie
{
    private readonly string[] condiments = { "Oil", "Vinegar" };
    private readonly string[] veggies = { "Lettuce", "Tomatoes", "Onions", "Sweet Peppers" };

    internal bool CustomerWantsMeat()
    {
        return false;
    }

    internal bool CustomerWantsCheese()
    {
        return false;
    }

    internal override void AddCondiments()
    {
        Console.WriteLine("Adding Condiments");
        foreach (var condiment in condiments) Console.Write(condiments + " ");
    }


    internal override void AddVegetables()
    {
        Console.WriteLine("Adding Vegetables");
        foreach (var veggie in veggies) Console.Write(veggie + " ");
    }

    internal override void AddMeat()
    {
    }

    internal override void AddCheese()
    {
    }
}