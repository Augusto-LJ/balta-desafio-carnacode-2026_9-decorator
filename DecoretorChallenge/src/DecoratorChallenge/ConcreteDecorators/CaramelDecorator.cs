using DecoratorChallenge.src.DecoratorChallenge.Component;
using DecoratorChallenge.src.DecoratorChallenge.Decorator;

namespace DecoratorChallenge.src.DecoratorChallenge.ConcreteDecorators;
public class CaramelDecorator(ICoffee coffee) : CoffeeDecorator(coffee)
{
    private const decimal CaramelCost = 0.80m;
    public override decimal GetCost()
    {
        return base.GetCost() + CaramelCost;
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Caramel";
    }
}
