namespace HelloWorld;

class Program
{
    static void Main()
    {
        int? idade = null;

        int minhaIdade = idade.Value;
        bool informouIdade = idade.HasValue;
    }
}