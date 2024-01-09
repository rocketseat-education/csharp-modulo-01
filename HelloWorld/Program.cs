namespace HelloWorld;

class Program
{   enum Cores
    {
        Vermelho,
        Azul,
        Amarelo
    }
    static void Main()
    {
        int numero = 0;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Welisson";
        List<int> lista = new List<int> { 1, 7 };
        Cores cor = Cores.Azul;

        /* Operadores:
            > Maior
            < Menor
            >= Maior ou igual
            <= Menor ou igual
            == Igualdade
            != Diferente
        */


        /* Condições com o numero */
        if (numero > 0)
        {
            Console.WriteLine("Este número é POSITIVO");
        }
        else if (numero == 0)
        {
            Console.WriteLine("Este número é NEUTRO");
        }
        else
        {
            Console.WriteLine("Este número é NEGATIVO");
        }

        /* Condições com o booleano */
        if (ativo)
        {
            Console.WriteLine("ENTROUUU");
        }

        /* Condições com a string */
        if (autor.Equals("Welisson"))
        {
            Console.WriteLine("ENTROUUU");
        }

        /* Condições com a lista */
        if (lista.Count > 0) 
        {
            Console.WriteLine("A lista tem pelo menos um valor!");
        }

        /* Condições com o enum */
        if (cor == Cores.Azul)
        {
            Console.WriteLine("ENTROUUU");
        }
    }
}