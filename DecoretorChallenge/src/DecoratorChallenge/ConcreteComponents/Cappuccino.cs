using DecoratorChallenge.src.DecoratorChallenge.Component;

namespace DecoratorChallenge.src.DecoratorChallenge.ConcreteComponents;
public class Cappuccino : ICoffee
{
    public decimal GetCost()
    {
        return 4.50m;
    }

    public string GetDescription()
    {
        return "Cappuccino";
    }
}
