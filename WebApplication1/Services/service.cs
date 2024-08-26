// IMyService.cs
public interface IMyService
{
    string GetMessage();
}

// MyService.cs
public class MyService : IMyService
{
    public string GetMessage()
    {
        return "Hello from MyService!";
    }
}
