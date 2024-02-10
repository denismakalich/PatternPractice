using Strategy.FlyMove;
using Strategy.QuackMove;

namespace Strategy.Ducks;

public abstract class Duck
{
    protected IFlyBehavior _flyBehavior;
    protected IQuackBehavior _quackBehavior;

    public Duck()
    {
    }

    public abstract void Display();

    public void PerformFly()
    {
        _flyBehavior.Fly();
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        _flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        _quackBehavior = qb;
    }
    
    public void PerformQuack()
    {
        _quackBehavior.QuackSound();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}