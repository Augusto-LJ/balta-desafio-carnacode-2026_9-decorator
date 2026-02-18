using DecoratorChallenge.src.DecoratorChallenge.Component;

namespace DecoratorChallenge.src.DecoratorChallenge.ConcreteComponents;
public class Espresso : ICoffee
{
    public decimal GetCost()
    {
        return 3.50m;
    }

    public string GetDescription()
    {
        return "Espresso";
    }
}
