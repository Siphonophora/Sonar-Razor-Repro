using System.Security.Cryptography.X509Certificates;

namespace BlazorApp;

public static class OtherClass{
    public static bool SomeBool() => DateTime.Now > DateTime.MinValue;

    public static void DoWork(){
        if(SomeBool() == true)
        {
            Console.WriteLine("Foo");
        }
    }
}