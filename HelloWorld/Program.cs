namespace HelloWorld;

class Program
{
    static void Main()
    {
        /* Início da aula

        int[] inteiros = new int[10];

        inteiros[0] = 1;
        inteiros[1] = 10;
        inteiros[2] = 7;
        

        int[] inteiros = [1, 10, 7];

        Console.WriteLine(inteiros[0]);
        Console.WriteLine(inteiros[1]);
        Console.WriteLine(inteiros[2]);

        */

        int[,] inteiros = new int[10, 10];
        inteiros[0,0] = 1;
        inteiros[0,3] = 2;

        Console.WriteLine(inteiros[0, 0]);
        Console.WriteLine(inteiros[0, 1]);
        Console.WriteLine(inteiros[0, 2]);
        Console.WriteLine(inteiros[0, 3]);
    }
}