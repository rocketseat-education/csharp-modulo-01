using HelloWorld.Teste;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        Carro meuCarro = new Carro();

        meuCarro.Ligar();

        meuCarro.Desligar();

        Biscoito meuBiscoito = new Biscoito();

        meuBiscoito.Temperatura();
    }
}