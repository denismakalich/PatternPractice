namespace Observer.Interfaces;

public interface ISubject
{
    public void RegisterObserver(IObserver o);
    public void RemoveObserver(IObserver o);
    public void NotifyObserver();
    public float GetTemperature();
    public float GetHumidity();
    public float GetPressure();
}