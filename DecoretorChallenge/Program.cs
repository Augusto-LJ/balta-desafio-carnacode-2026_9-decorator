using DecoratorChallenge.src.DecoratorChallenge.Component;
using DecoratorChallenge.src.DecoratorChallenge.ConcreteComponents;
using DecoratorChallenge.src.DecoratorChallenge.ConcreteDecorators;

ICoffee cappuccinoChantillyCaramelo = new Cappuccino();
cappuccinoChantillyCaramelo = new WhippedCreamDecorator(cappuccinoChantillyCaramelo);
cappuccinoChantillyCaramelo = new CaramelDecorator(cappuccinoChantillyCaramelo);

Console.WriteLine($"{cappuccinoChantillyCaramelo.GetDescription()}: R$ {cappuccinoChantillyCaramelo.GetCost():N2}");


ICoffee espressoLeiteChocolateCaramelo = new Espresso();
espressoLeiteChocolateCaramelo = new MilkDecorator(espressoLeiteChocolateCaramelo);
espressoLeiteChocolateCaramelo = new ChocolateDecorator(espressoLeiteChocolateCaramelo);
espressoLeiteChocolateCaramelo = new CaramelDecorator(espressoLeiteChocolateCaramelo);

Console.WriteLine($"{espressoLeiteChocolateCaramelo.GetDescription()}: R$ {espressoLeiteChocolateCaramelo.GetCost():N2}");