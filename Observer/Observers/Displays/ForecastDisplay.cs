using Observer.Interfaces;

namespace Observer.Displays;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float _pressure;
    private ISubject _weatherData;

    public ForecastDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _pressure = _weatherData.GetPressure();
        Display();
    }

    public void Display()
    {
        Console.WriteLine(_pressure + " давление");
    }
}