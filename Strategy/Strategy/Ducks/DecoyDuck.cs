using Strategy.FlyMove;
using Strategy.QuackMove;

namespace Strategy.Ducks;

public class DecoyDuck: Duck
{
    public DecoyDuck()
    {
        _flyBehavior = new FlyNoWay();
        _quackBehavior = new MuteQuack();
    }
    
    public override void Display()
    {
        Console.WriteLine("Decoy silence");
    }
}