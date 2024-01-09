namespace HelloWorld;

class Program
{
    static void Main()
    {
        var lista = new List<string> { "Welisson", "Willian", "Edilaine" };
        var dicionario = new Dictionary<string, string>();

        dicionario.Add("Nome1", "Welisson");
        dicionario.Add("Nome2", "Willian");
        dicionario.Add("Nome3", "Edilaine");

        foreach (var item in lista) 
            Console.WriteLine(item);
    }
}