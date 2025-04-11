// See https://aka.ms/new-console-template for more information
// Mensagem de boas-vindas
Console.WriteLine("Seja bem-vindo à calculadora simples!");

// Declaração das variáveis utilizadas
int n1, n2, resultado;
string operacao = "";

// Loop principal que só termina quando o usuário digitar "sair"
while (operacao != "sair")
{
    // Solicita ao usuário qual operação deseja realizar
    Console.WriteLine("Qual operação você deseja realizar? (+, -, *, /) ou digite 'sair' para encerrar:");
    operacao = Console.ReadLine();

    // Verifica se o usuário deseja encerrar o programa
    if (operacao == "sair")
    {
        Console.WriteLine("Obrigado por usar a calculadora simples!");
        break;
    }

    // Valida se o operador informado é válido
    if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
    {
        Console.WriteLine("Operação inválida. Tente novamente.");
        continue; // Volta para o início do loop
    }

    // Pede o primeiro número e valida a entrada
    Console.WriteLine("Digite o primeiro número:");
    if (!int.TryParse(Console.ReadLine(), out n1))
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        continue;
    }

    // Pede o segundo número e valida a entrada
    Console.WriteLine("Digite o segundo número:");
    if (!int.TryParse(Console.ReadLine(), out n2))
    {
        Console.WriteLine("Número inválido. Tente novamente.");
        continue;
    }

    // Estrutura switch para realizar a operação escolhida
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
            // Verifica se o divisor é zero
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

