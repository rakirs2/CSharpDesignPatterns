namespace TemplateMethod;

public abstract class Hoagie
{
    internal void makeSandwich()
    {
        CutBun();

        if (CustomerWantsMeat()) AddMeat();
        if (CustomerWantsCheese()) AddCheese();

        if (CustomerWantsVegetables()) AddVegetables();
        if (CustomerWantsCondiments()) AddCondiments();

        WrapTheHoagie();
    }

    internal abstract void AddMeat();
    internal abstract void AddCheese();
    internal abstract void AddVegetables();
    internal abstract void AddCondiments();

    //hook

    private bool CustomerWantsMeat()
    {
        return true;
    }

    private bool CustomerWantsCheese()
    {
        return true;
    }

    private bool CustomerWantsVegetables()
    {
        return true;
    }

    private bool CustomerWantsCondiments()
    {
        return true;
    }

    public void WrapTheHoagie()
    {
        Console.WriteLine("Hoagie is Wrapped");
    }

    public void CutBun()
    {
        Console.WriteLine("Bun is Cut");
    }
}