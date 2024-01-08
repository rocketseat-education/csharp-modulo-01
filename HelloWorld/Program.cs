namespace HelloWorld;

class Program
{
    static void Main()
    {
        /* Código com os exemplos de Listas do início da aula:

        List<string> strings = new List<string>();
        strings.Add("Hello!");
        strings.Add("Mundo");

        List<int> ints = new List<int>();
        ints.Add(1);

        List<decimal> decimals = new List<decimal>();
        decimals.Add(2.5m);

        List<bool> bools = new List<bool>();
        bools.Add(true);

        List<object> objetos = new List<object>();

        objetos.Add("Hello");
        objetos.Add(7);
        objetos.Add(true);

        */

        List<string> strings = new List<string>();
        strings.Add("Hello");
        strings.Add("Mundo");

        string resultado = string.Join(" ", strings);

        Console.WriteLine(resultado);
    }
}