// See https://aka.ms/new-console-template for more information
// Definição da classe principal chamada "temperatura"
class temperatura
{
    // Método principal da aplicação 
    static void Main()
    {
        // Exibe mensagem inicial ao usuário
        Console.WriteLine("Seja bem-vindo ao conversor de temperatura!");

        // Loop principal para manter o programa rodando até o usuário decidir sair
        while (true)
        {
            // Mostra o menu com as opções de conversão disponíveis
            Console.WriteLine("Escolha a escala de origem");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Fahrenheit");
            Console.WriteLine("3 - Kelvin");
            Console.WriteLine("0 - Sair");

            // Lê a escolha do usuário
            string escolha = Console.ReadLine();

            // Verifica se o usuário optou por sair
            if (escolha == "0")
            {
                Console.WriteLine("Encerrando o programa...");
                break; // Sai do laço
            }

            // Solicita que o usuário digite o valor da temperatura
            Console.Write("Digite o valor da temperatura: ");

            // Tenta converter a entrada para um número do tipo double
            if (!double.TryParse(Console.ReadLine(), out double temperatura))
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                continue; // Volta ao início do laço se a entrada for inválida
            }

            // Utiliza switch para realizar a conversão com base na escolha do usuário
            switch (escolha)
            {
                // Caso o usuário tenha escolhido Celsius
                case "1":
                    double f1 = (temperatura * 9 / 5) + 32; // Converte para Fahrenheit
                    double k1 = temperatura + 273.15;       // Converte para Kelvin
                    Console.WriteLine($"{temperatura} °C = {f1:F2} °F");
                    Console.WriteLine($"{temperatura} °C = {k1:F2} K");
                    break;

                // Caso o usuário tenha escolhido Fahrenheit
                case "2":
                    double c2 = (temperatura - 32) * 5 / 9; // Converte para Celsius
                    double k2 = c2 + 273.15;                // Converte para Kelvin
                    Console.WriteLine($"{temperatura} °F = {c2:F2} °C");
                    Console.WriteLine($"{temperatura} °F = {k2:F2} K");
                    break;

                // Caso o usuário tenha escolhido Kelvin
                case "3":
                    double c3 = temperatura - 273.15;       // Converte para Celsius
                    double f3 = (c3 * 9 / 5) + 32;           // Converte para Fahrenheit
                    Console.WriteLine($"{temperatura} K = {c3:F2} °C");
                    Console.WriteLine($"{temperatura} K = {f3:F2} °F");
                    break;

                // Caso a escolha não esteja entre 1, 2 ou 3
                default:
                    Console.WriteLine("Opção inválida. Escolha 1, 2, 3 ou 0.");
                    break;
            }
        }
    }
}



