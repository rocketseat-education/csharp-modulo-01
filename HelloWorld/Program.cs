namespace HelloWorld;

class Program
{
    static void Main()
    {
        var matematica = new OperacoesMatematicas();

        (int resultado, string nome) = matematica.Adicionar(valor1: 7, valor2: 1);

        Console.WriteLine(resultado);
        Console.WriteLine(nome);
    }
}