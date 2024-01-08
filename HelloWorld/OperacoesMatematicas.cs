namespace HelloWorld;

public class OperacoesMatematicas
{
    /* Maneira simplificada quando a função tem apenas uma linha:
    public int Adicionar(int valor1, int valor2) => valor1 + valor2;
    */
    public (int resultadoDaAdicao, string autor) Adicionar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        return (resultado, "welisson");
    }
}