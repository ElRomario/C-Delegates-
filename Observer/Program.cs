

public delegate void EventHandler(string message);


public class Subject
{
    public event EventHandler EventOccured;
    public event EventHandler RNGEventOccured;


    public void RNGshit()
    {
        Random random = new Random();
        int numb = random.Next(0, 10);

        if (numb > 5) RNGEventOccured?.Invoke("RNG win!");
        else RNGEventOccured?.Invoke("RNG fail");
    }
    public void DoSomething()
    {
        EventOccured?.Invoke("Smth happend with subject1");
    }

}

public class Subject2
{
    public event EventHandler EventOccured;
    public event EventHandler RNGEventOccured;

    public void RNGshit()
    {
        Random random = new Random();
        int numb = random.Next(0, 10);

        if (numb > 5) RNGEventOccured?.Invoke("RNG win!");
        else RNGEventOccured?.Invoke("RNG fail");
    }

    public void DoSomething()
    {
        EventOccured?.Invoke("Smth happend with subject2");
    }

}

public class Observer   
{
    int counter = 1;
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Observer 1 reserved {counter++} new {message} ");
    }
    public void RNGEventHandle(string message)
    {
        Console.WriteLine($"Oberver 1{message}");
    }
}

public class Observer2
{
    int counter = 1;
    public void HandleEvent(string message)
    {
        Console.WriteLine($"Observer 2 reserved {counter++} new {message} ");
    }
    public void RNGEventHandle(string message)
    {
        Console.WriteLine($"Oberver 2{message}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject();
        Subject2 subject2 = new Subject2();

        Observer observer1 = new Observer();
        Observer2 observer2 = new Observer2();

        subject.EventOccured += observer1.HandleEvent;
        subject.EventOccured += observer2.HandleEvent;

        subject2.EventOccured += observer1.HandleEvent;
        subject2.EventOccured += observer2.HandleEvent;

        subject.RNGEventOccured += observer1.RNGEventHandle;
        subject2.RNGEventOccured += observer2.RNGEventHandle;  
        
        subject.DoSomething();
        subject2.DoSomething();

        subject.RNGshit();
        subject2.RNGshit();
       
    }
}

