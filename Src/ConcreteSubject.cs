using Observer.Interfaces;
namespace Observer;

public class ConcreteSubject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();


    public string Produto {  get; set; }
    private int Preco { get; set; }
    private string Disponibilidade { get; set; }
    public ConcreteSubject(string produto, int preco, string disponibilidade)
    {
        Produto = produto;
        Preco = preco;
        Disponibilidade = disponibilidade;
    }

    public string GetDisponibilidade()
    {
        return Disponibilidade;
    }

    public void SetDisponibilidade(string status)
    {
        this.Disponibilidade = status;
        Console.WriteLine($"A disponibilidade mudou para: {status}");
        NotificarObservers();
    }
    public void RegistrarObserver(IObserver observer)
    {
        Console.WriteLine("Observer Adicionado : " + ((ConcreteObserver)observer).Usuario);
        observers.Add(observer);
    }

    public void RemoverObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotificarObservers()
    {
        Console.WriteLine($"O Produto:{Produto} no valor de R$ {Preco} agora está disponível.");
        Console.WriteLine("\n### Notificando todos os Observers registrados ###");
        Console.WriteLine();

        foreach (var observer in observers)
        {
            observer.Atualiza(Disponibilidade);
        }
    }
}
