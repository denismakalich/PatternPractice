using Strategy.FlyMove;
using Strategy.QuackMove;

namespace Strategy.Ducks;

public class MallardDuck: Duck
{
    public MallardDuck()
    {
        _quackBehavior = new Quack();
        _flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Console.WriteLine("Mallard duck");
    }
}