namespace Observer.Interfaces;

public interface ISubject
{
    void RegistrarObserver(IObserver observer);
    void RemoverObserver(IObserver observer);

    void NotificarObservers();
}
