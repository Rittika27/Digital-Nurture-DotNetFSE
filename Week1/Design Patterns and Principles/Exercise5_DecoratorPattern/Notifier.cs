public interface INotifier
{
    void Send(string message);
}

public class EmailNotifier : INotifier
{
    public void Send(string message) =>
        Console.WriteLine($"Email: {message}");
}

public abstract class NotifierDecorator : INotifier
{
    protected readonly INotifier _inner;
    protected NotifierDecorator(INotifier notifier) => _inner = notifier;
    public virtual void Send(string message) => _inner.Send(message);
}

public class SMSNotifierDecorator : NotifierDecorator
{
    public SMSNotifierDecorator(INotifier notifier) : base(notifier) { }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS: {message}");
    }
}

public class SlackNotifierDecorator : NotifierDecorator
{
    public SlackNotifierDecorator(INotifier notifier) : base(notifier) { }
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"Slack: {message}");
    }
}
