**În acest proiect am demonstrat două șabloane comportamentale: Observer și Strategy.**

**Șablonul Observer este utilizat pentru a implementa o relație de tip "unu-la-mulți" între un subiect (Subject) și mai mulți observatori (Observers). În proiect, avem clasa Subject care are o stare internă (state) și o listă de observatori (observers). Observatorii sunt reprezentați de interfața IObserver, iar clasele Observer1 și Observer2 o implementează. Atunci când starea subiectului se schimbă, observatorii sunt notificați și li se trimite noua stare. Aceasta permite observatorilor să reacționeze la schimbările de stare în subiect.**

// Interfață pentru observator (Observer)
public interface IObserver
{
    void Update(int value);
}
// Observatorul (Observer) 1
public class Observer1 : IObserver
{
    public void Update(int value)
    {
        Console.WriteLine("Observer1: The state has changed to " + value);
    }
}

// Observatorul (Observer) 2
public class Observer2 : IObserver
{
    public void Update(int value)
    {
        Console.WriteLine("Observer2: The state has changed to " + value);
    }
}

// Interfață pentru strategie (Strategy)
public interface IStrategy
{
    void Execute();
}

**Sablonul Strategy este utilizat pentru a separa o anumită funcționalitate într-o familie de clase care o implementează diferit. În proiect, avem interfața IStrategy care reprezintă o strategie și clasele Strategy1 și Strategy2 care o implementează. Clasa Context utilizează o strategie și oferă o metodă ExecuteStrategy() pentru a executa strategia curentă. Astfel, putem schimba strategia utilizată în context în timpul executării.**

// Interfață pentru strategie (Strategy)
public interface IStrategy
{
    void Execute();
}

// Implementarea strategiei (Strategy) 1
public class Strategy1 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy 1");
    }
}

// Implementarea strategiei (Strategy) 2
public class Strategy2 : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("Executing Strategy 2");
    }
}

**În metoda Main, se crează obiectele necesare și se demonstrează funcționalitatea sabloanelor. În primul exemplu, se atașează doi observatori la un subiect și se schimbă starea subiectului, observând că observatorii sunt notificați corespunzător. În al doilea exemplu, se utilizează diferite strategii prin intermediul contextului și se executa strategia curentă.**

class Program
{
    static void Main(string[] args)
    {
        // Utilizare Observer
        Subject subject = new Subject();
        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();

        subject.Attach(observer1);
        subject.Attach(observer2);

        subject.State = 10;

        subject.Detach(observer2);

        subject.State = 20;

        // Utilizare Strategy
        IStrategy strategy1 = new Strategy1();
        IStrategy strategy2 = new Strategy2();

        Context context = new Context(strategy1);
        context.ExecuteStrategy();

        context = new Context(strategy2);
        context.ExecuteStrategy();

        Console.ReadLine();
    }
}

**Astfel, proiectul ilustrează modul în care sabloanele Observer și Strategy pot fi implementate pentru a separa funcționalitatea și pentru a permite flexibilitate și extensibilitate în codul software.**