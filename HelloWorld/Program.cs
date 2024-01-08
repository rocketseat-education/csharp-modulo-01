namespace HelloWorld;

class Program
{
    static void Main()
    {
        var resultado = Math.Cbrt(8);
        Console.WriteLine(resultado);


        var matematica = new OperacoesMatematicas();
        matematica.Restante(valor1: 8, valor2: 3);
    }
}