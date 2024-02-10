namespace Strategy.QuackMove;

public class Squeak: IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("Squek");
    }
}