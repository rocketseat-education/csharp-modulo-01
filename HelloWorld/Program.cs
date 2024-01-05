namespace HelloWorld;

class Program
{
    static void Main()
    {
       /*
       Variáveis do tipo TEXTO
       char
       string
       */

        char letra = 'a';
        char numero = '1';
        char caracter = '@';
        char espaco = ' ';

        string texto = "Este curso é muito bom!";

        char primeiraLetraDoTexto = texto[0];
        bool existe1 = texto.Contains("curso");
        bool existe2 = texto.Equals("Este curso é muito bom!");

        Console.WriteLine(existe1);

        string meuNome = "      Welisson Dev      ";
        string nomeSemEspaco = meuNome.Trim();

        bool comecaComALetraW = nomeSemEspaco.StartsWith("W");
        bool terminaComALetraV = nomeSemEspaco.EndsWith("v");
        string textoAposReplace = nomeSemEspaco.Replace('e', '7');
    }
}