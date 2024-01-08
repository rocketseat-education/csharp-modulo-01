namespace HelloWorld;

class Program
{
    static void Main()
    {
        /* ⦁ Primeira maneira de fazer:

        var carro = new Carro();

        carro.Modelo = "Lamborghini";
        carro.Cor = Cor.Vermelho;
        carro.LancadoEm = new DateOnly(2021, 01, 01);

        carro.NomeDoModelo();
       
       */

        var carro = new Carro("Lamborghini")
        {
            LancadoEm = new DateOnly(2021, 01, 01),
            Cor = Cor.Azul
        };

        var carro2 = new Carro("Porsche")
        {
            LancadoEm = new DateOnly(2019, 01, 01),
            Cor = Cor.Vermelho
        };

        carro.NomeDoModelo();
    }
}