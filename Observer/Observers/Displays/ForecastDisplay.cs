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

    public void Update(float temp, float humidity, float pressure)
    {
        _pressure = pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine(_pressure + " давление");
    }
}