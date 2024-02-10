using Strategy.FlyMove;
using Strategy.QuackMove;

namespace Strategy.Ducks;

public class RedheadDuck: Duck
{
    public RedheadDuck()
    {
        _quackBehavior = new Quack();
        _flyBehavior = new FlyWithWings();
    }
    
    public override void Display()
    {
        Console.WriteLine("readhead duck");
    }
}