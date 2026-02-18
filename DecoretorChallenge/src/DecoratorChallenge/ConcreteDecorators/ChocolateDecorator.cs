using DecoratorChallenge.src.DecoratorChallenge.Component;
using DecoratorChallenge.src.DecoratorChallenge.Decorator;

namespace DecoratorChallenge.src.DecoratorChallenge.ConcreteDecorators;
public class ChocolateDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    private const decimal ChocolateCost = 0.70m;
    public override decimal GetCost()
    {
        return base.GetCost() + ChocolateCost;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Chocolate";
    }
}
