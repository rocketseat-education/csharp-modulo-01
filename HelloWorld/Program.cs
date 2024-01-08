using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
       DateOnly dia = new DateOnly(2023, 12, 1);

        string diaEmTexto = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));

        DateTime dia1 = new DateTime(2023, 12, 1, 20, 07, 1);

        DateTime hoje = DateTime.UtcNow;

        DateTime novaData = hoje.AddDays(1);

        Console.WriteLine(hoje);
        Console.WriteLine(novaData);
    }
}