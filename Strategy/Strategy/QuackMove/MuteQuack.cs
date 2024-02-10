namespace Strategy.QuackMove;

public class MuteQuack: IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("Silence");
    }
}