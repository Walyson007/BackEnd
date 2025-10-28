using System.Collections;

Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"Ok, {nome}! Agora vamos dar as boas vindas a você!!");

Console.WriteLine($"por favor escolha uma opção abaixo");
Console.WriteLine($"1 - Saudar com nome");
Console.WriteLine($"2 - saudar com sobrenome");
Console.WriteLine($"3 - saudar com nome e sobrenome");
Console.WriteLine($"0 - apenas saudação genérica");
Console.Clear();

int opcao = 0;
switch (opcao)
{
    case 0:
        Console.WriteLine($"Olá, seja bem vindo ao nosso programa, tenha um ótimo dia :)");
        break;

    case 1:
        SaudacaoComNome(nome);
        break;
    
    case 2:
        SaudacaoComSobrenome(sobrenome);
        break;

    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja Bem-vindo, {nomeCompleto}");
        break;

    default:
        break;
}

void SaudacaoGenerica()
{
    Console.WriteLine($"Olá seja bem-vindo ao nosso programa, tenha um ótimo dia :-)");
}

void SaudacaoComNome( string NomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo {NomeRecebido}");
}

void SaudacaoComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"seja bem-vindo{sobrenomeRecebido}");
}

string DevolveNomeCompleto(string NomeRecebido, string sobrenomeRecebido)
{
    return $"{NomeRecebido}{sobrenomeRecebido}";
}