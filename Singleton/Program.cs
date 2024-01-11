var singletonInstance = Singleton.GetInstance();
var anotherSingletonInstance = Singleton.GetInstance();

Console.WriteLine(singletonInstance == anotherSingletonInstance);


public class Singleton
{
    private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
    private Singleton()
    {

    }

    public static Singleton GetInstance()
    {
        return _instance.Value;
    }
}
