namespace Observer;

class Program
{
    static void Main(string[] args)
    {
        ConcreteSubject produto = new ConcreteSubject("IPhone 11 ",4900,"Sem Estoque");
        Console.WriteLine("IPhone 11 - estado atual : " + produto.GetDisponibilidade());

        Console.WriteLine("\nObservers inscritos para receber notificações sobre "+
            "o produto "+ produto.Produto);

        ConcreteObserver reytler = new ConcreteObserver("Reytler",produto);
        ConcreteObserver iarla = new ConcreteObserver("Iarla", produto);

        Console.WriteLine("\nPressione algo para alterar a disponibilidade e "+
            "notificar os observers\n");
        Console.ReadKey();

        produto.SetDisponibilidade("Disponível");

        Console.Read();
    }
}