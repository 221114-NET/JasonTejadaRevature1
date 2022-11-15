namespace JasonTejadaRevature1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, JASON!");
        int x = MyFunc(5);
        Console.WriteLine(x);
    }

    static int MyFunc(int n) {
        return ++n;
    }
}
