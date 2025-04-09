// See https://aka.ms/new-console-template for more information
Console.WriteLine("Seja bem-vindo à calculadora simples!");
int n1, n2, resultado;
string operacao = "";

while (operacao != "sair")
{
    Console.WriteLine("Qual operação você deseja realizar? (+, -, *, /) ou digite 'sair' para encerrar:");
    operacao = Console.ReadLine();

    if (operacao == "sair")
    {
        Console.WriteLine("Obrigado por usar a calculadora simples!");
        break;
    }

    if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
    {
        Console.WriteLine("Operação inválida. Tente novamente.");
        continue; 
    }

    Console.WriteLine("Digite o primeiro número:");
    if (!int.TryParse(Console.ReadLine(), out n1))
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        continue;
    }

    Console.WriteLine("Digite o segundo número:");
    if (!int.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        continue;
    }

    switch (operacao)
    {
        case "+":
            resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            break;
        case "-":
            resultado = n1 - n2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            break;
        case "*":
            resultado = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            break;
        case "/":
            if (n2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                break;
            }
            resultado = n1 / n2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            break;
    }
}
