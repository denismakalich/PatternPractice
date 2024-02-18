using Observer.Interfaces;

namespace Observer;

public class WeatherData : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    private float _humidity;
    private float _pressure;

    public WeatherData()
    {
        _observers = new();
    }

    public void RegisterObserver(IObserver o) => _observers.Add(o);

    public void RemoveObserver(IObserver o) => _observers.Remove(o);

    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature, _humidity, _pressure);
        }
    }

    public void MeansurementsChanged() => NotifyObserver();

    public void SetMeansurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeansurementsChanged();
    }
}