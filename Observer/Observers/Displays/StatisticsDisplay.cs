using Observer.Interfaces;

namespace Observer.Displays;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private List<float> _temperatures;
    private List<float> _humidities;
    private List<float> _pressures;
    private ISubject _weatherData;

    public StatisticsDisplay(ISubject weatherData)
    {
        _temperatures = new();
        _humidities = new();
        _pressures = new();

        _weatherData = weatherData;

        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _temperatures.Add(_weatherData.GetTemperature());
        _humidities.Add(_weatherData.GetHumidity());
        _pressures.Add(_weatherData.GetPressure());

        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min градусов = {_temperatures.Average()};{_temperatures.Max()};{_temperatures.Min()}");
        Console.WriteLine($"Avg/Max/Min влажность = {_humidities.Average()};{_humidities.Max()};{_humidities.Min()}");
        Console.WriteLine($"Avg/Max/Min давление = {_pressures.Average()};{_pressures.Max()};{_pressures.Min()}");
    }
}