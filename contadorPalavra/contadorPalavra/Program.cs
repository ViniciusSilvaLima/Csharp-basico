﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Seja bem-vindo ao contador de palavras!");

// Solicita que o usuário digite um texto
Console.WriteLine("Digite o texto que deseja analisar:");
string texto = Console.ReadLine();

// Verifica se o texto é nulo, vazio ou apenas espaços
if (string.IsNullOrWhiteSpace(texto))
{
    Console.WriteLine("Texto inválido.");
}
else
{
    // Divide o texto em palavras, ignorando espaços, tabulações e quebras de linha
    string[] palavras = texto.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

    // Conta quantas palavras existem no texto
    int numeroPalavras = palavras.Length;

    // Conta todos os caracteres incluindo espaços
    int caracteresComEspacos = texto.Length;

    // Conta os caracteres excluindo espaços e quebras de linha
    int caracteresSemEspacos = texto.Count(c => !char.IsWhiteSpace(c));

    // Exibe os resultados no console
    Console.WriteLine($"Palavras: {numeroPalavras}");
    Console.WriteLine($"Caracteres: {caracteresSemEspacos}");
}

// Mensagem final
Console.WriteLine("Obrigado por usar o contador de palavras!");
