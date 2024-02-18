using Observer.Interfaces;

namespace Observer.Displays;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private readonly ISubject _weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _temperature = _weatherData.GetTemperature();
        _humidity = _weatherData.GetHumidity();
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current conditions: " + _temperature + "F degrees and " + _humidity + "% humidity");
    }
}