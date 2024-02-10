namespace Strategy.FlyMove;

public class FlyRocketPowered: IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with a rocket!");
    }
}