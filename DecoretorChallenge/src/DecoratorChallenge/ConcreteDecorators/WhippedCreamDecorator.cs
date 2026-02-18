using DecoratorChallenge.src.DecoratorChallenge.Component;
using DecoratorChallenge.src.DecoratorChallenge.Decorator;

namespace DecoratorChallenge.src.DecoratorChallenge.ConcreteDecorators;
public class WhippedCreamDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    private const decimal WhippedCreamCost = 1.00m;
    public override decimal GetCost()
    {
        return base.GetCost() + WhippedCreamCost;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Whipped cream";
    }
}
