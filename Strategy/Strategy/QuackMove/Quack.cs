namespace Strategy.QuackMove;

public class Quack: IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("Quack");
    }
}