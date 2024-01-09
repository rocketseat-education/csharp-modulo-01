namespace HelloWorld;

class Program
{
    static void Main()
    {
        var texto = Teste(5);

        Console.WriteLine("texto");
    }

    static string Teste(int numero)
    {
        Console.WriteLine("Teste 1");
    
        if (numero == 5) 
        {
            Console.WriteLine("Teste2");
            return "Welisson";
        }

        Console.WriteLine("Teste 3");
        return "Willian";
    }
}