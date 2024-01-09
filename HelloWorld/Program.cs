namespace HelloWorld;

class Program
{
    static void Main()
    {
        var numero = 0;

        while (numero < 100)
        {
            if (numero == 5) 
            {
                break;
            }

            Console.WriteLine(numero);
            numero++;
        }

        Console.WriteLine("Aqui");
    }
}