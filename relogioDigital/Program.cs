// See https://aka.ms/new-console-template for more information
// Captura a data e hora atual no momento da execução
DateTime data = DateTime.Now;

// Exibe a data e hora no console
Console.WriteLine($"Data e hora atual: {data}");

// Loop infinito para atualizar a hora dinamicamente
while (true)
{
    // Limpa o console a cada iteração para manter o visual limpo
    Console.Clear();

    // Atualiza o valor da data/hora
    data = DateTime.Now;

    // Exibe a data/hora atualizada
    Console.WriteLine($"Data e hora atual: {data}");

    // Instrução para o usuário encerrar o programa
    Console.WriteLine("Pressione 'Esc' para sair ou qualquer outra tecla para continuar...");

    // Verifica se alguma tecla foi pressionada e se foi a tecla ESC
    if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
    {
        // Limpa o console e exibe mensagem de saída
        Console.Clear();
        Console.WriteLine("Saindo...");
        break; // Encerra o loop
    }

    // Aguarda 1 segundo antes de atualizar novamente
    System.Threading.Thread.Sleep(1000); 
}
