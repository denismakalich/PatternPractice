using Strategy.FlyMove;
using Strategy.QuackMove;

namespace Strategy.Ducks;

public class RubberDuck: Duck
{
    public RubberDuck()
    {
        _quackBehavior = new Quack();
        _flyBehavior = new FlyWithWings();
    }
    
    public override void Display()
    {
        Console.WriteLine("Rubber duck");
    }
}