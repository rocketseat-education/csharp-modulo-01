namespace HelloWorld;

class Program
{
    static void Main()
    {
       HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);

        set.Add(1);

        Console.WriteLine(set.Count);
    }
}