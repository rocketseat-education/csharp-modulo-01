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
      
        /* Usando o && */
        if (cor == Cores.Azul && numero >= 0 && ativo)
        {
            Console.WriteLine("Entrou no exemplo usando &&");
        }

        /* Usando o || */
        if (cor == Cores.Vermelho || numero > 0)
        {
            Console.WriteLine("Entrou no exemplo usando ||");
        }


        string mensagemDeErro = null;

        /* Usando o &&: Se a primeira condição for verdadeira, ele não segue verificando as outras */
        if (mensagemDeErro is not null && mensagemDeErro.ToUpper().Equals("WELISSON"))
        {
            Console.WriteLine("ENTROUUUU");
        }
        
        if (numero == 0 && (saldo > 100.0 || ativo))
        {
            Console.WriteLine("ENTROUUUU");
        }
    }
}