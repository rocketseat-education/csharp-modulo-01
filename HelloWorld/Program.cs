namespace HelloWorld;

class Program
{
    static void Main()
    {
        var numero = 10;

        do
        {
            Console.WriteLine("Teste");

            numero++;
        }
        while (numero < 10);

        Console.WriteLine(numero);

    }
}