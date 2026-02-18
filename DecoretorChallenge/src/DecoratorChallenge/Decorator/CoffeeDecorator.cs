using DecoratorChallenge.src.DecoratorChallenge.Component;

namespace DecoratorChallenge.src.DecoratorChallenge.Decorator;
public class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual decimal GetCost()
    {
        return _coffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}
