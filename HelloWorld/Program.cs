namespace HelloWorld;

class Program
{

    enum Cores
    {
        Azul,
        Vermelho,
        Amarelo,
        Verde,
        Roxo
    }


    static void Main()
    {
        string texto = "Welisson";
        Cores cor = Cores.Azul;
        int numero = 7;
        
        /* Usando o exemplo da cor */
        switch (cor)
        {
            case Cores.Azul:
                {
                    Console.WriteLine("Azul");
                }
                break;
            case Cores.Vermelho:
                {
                    Console.WriteLine("Vermelho");
                }
                break;
            default:
                {
                    Console.WriteLine("Outra cor");
                }
                break;
        }

        /* Usando exemplo da string */
        switch (texto)
        {
            case "Welisson":
                {
                    Console.WriteLine("Welisson");
                }
                break;
            case "Willian":
                {
                    Console.WriteLine("Willian");
                }
                break;
            default:
                {
                    Console.WriteLine("Outro nome");
                }
                break;
        }

        /* Usando exemplo dos números */
        switch (numero)
        {
            case > 7:
                {
                    Console.WriteLine("O número é maior que 7");
                }
                break;
            case 1:
                {
                    Console.WriteLine("O número é 1");
                }
                break;
            case 0:
                {
                    Console.WriteLine("O número é 0");
                }
                break;
        }

        /* Switch ternário com números */
        string resultado = numero switch
        {
            7 => "Welisson",
            1 => "Willian",
            3 => "Edilaine",
            _ => "Nome desconhecido"
        };

        /* Switch ternário com enums */
        string resultado1 = cor switch
        {
            Cores.Azul => "Welisson",
            Cores.Amarelo => "Willian",
            Cores.Verde => "Edilaine",
            _ => "Nome desconhecido"
        };

        Console.WriteLine(resultado);
        Console.WriteLine(resultado1);
    }
}