using DecoratorChallenge.src.DecoratorChallenge.Component;
using DecoratorChallenge.src.DecoratorChallenge.Decorator;

namespace DecoratorChallenge.src.DecoratorChallenge.ConcreteDecorators;
public class MilkDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    private const decimal MilkCost = 0.50m;
    public override decimal GetCost()
    {
        return base.GetCost() + MilkCost;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }
}
