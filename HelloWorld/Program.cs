namespace HelloWorld;

class Program
{
    static void Main()
    { 
        var carro1 = new Carro("Carro 1");

        var carro2 = new Carro("Carro 2");

        carro1.NomeDoModelo();
        carro2.NomeDoModelo();
    }
}