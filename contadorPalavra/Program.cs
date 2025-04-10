// See https://aka.ms/new-console-template for more information
Console.WriteLine("Seja bem-vindo ao contador de palavras!");

Console.WriteLine("Digite o texto que deseja analisar:");
string texto = Console.ReadLine();

if (string.IsNullOrWhiteSpace(texto))
{
    Console.WriteLine("Texto inválido.");
}
else
{
    string[] palavras = texto.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    int numeroPalavras = palavras.Length;
    int caracteresComEspacos = texto.Length;
    int caracteresSemEspacos = texto.Count(c => !char.IsWhiteSpace(c));

    Console.WriteLine($"Palavras: {numeroPalavras}");
    Console.WriteLine($"Caracteres: {caracteresSemEspacos}");
}
Console.WriteLine("Obrigado por usar o contador de palavras!");