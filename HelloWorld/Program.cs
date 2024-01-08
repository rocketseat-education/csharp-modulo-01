using System.Text;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        /* 
        Código da primeira parte da aula

        string texto1 = "A primeira frase.";
        string texto2 = "Segunda frase.";

        string paragrafo = texto1 + " " + 7 + " " + true + " " + texto2;
        string paragrafo2 = $"A primeira frase. {7} {true} Segunda frase.";

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine(paragrafo);
        stringBuilder.AppendLine(paragrafo2);

        string resultado = stringBuilder.ToString();

        string caminho = @"C:\teste";

        Console.WriteLine(resultado);
        */

        string texto = "O usuário {0} gosta do número {1}!";

        string resultado = string.Format(texto, "Welisson", 7);

        Console.WriteLine(resultado);
    }
}