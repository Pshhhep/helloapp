namespace helloapp;

class Program
{
    static void Main(string[] args)
    {
        GreetWhite();
        GreetBlack();
        GreetEveryone();
    }

    public static void GreetEveryone()
    {
        Console.WriteLine("hello everyone");
    }

    public static void GreetWhite()
    {
        Console.WriteLine("hello white");
    }
    
    public static void GreetBlack()
    {
        Console.WriteLine("hello black");
    }
}