using System;
namespace TemplateMethod
{
    public abstract class Hoagie
    {
        internal void makeSandwich()
        {
            CutBun();

            if (CustomerWantsMeat())
            {
                AddMeat();
            }
            if (CustomerWantsCheese())
            {
                AddCheese();
            }

            if (CustomerWantsVegetables())
            {
                AddVegetables();
            }
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }

            WrapTheHoagie();
        }
        public Hoagie()
        {
        }

        internal abstract void AddMeat();
        internal abstract void AddCheese();
        internal abstract void AddVegetables();
        internal abstract void AddCondiments();

        //hook

        Boolean CustomerWantsMeat()
        {
            return true;
        }
        Boolean CustomerWantsCheese()
        {
            return true;
        }
        Boolean CustomerWantsVegetables()
        {
            return true;
        }
        Boolean CustomerWantsCondiments()
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
}

