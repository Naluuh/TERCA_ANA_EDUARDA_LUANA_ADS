using System.Linq;

class Palindromo
{
    public static void Executar()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string entrada = Console.ReadLine().ToLower();
        string tratada = new string(entrada.Where(char.IsLetterOrDigit).ToArray());

        string invertida = new string(tratada.Reverse().ToArray());

        Console.WriteLine(tratada == invertida ? "É um palíndromo!" : "Não é um palíndromo.");
    }
}
