int opcao = -1;
do
{
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem-vindo, usuário");
    Console.WriteLine("----------------------------");
    Console.WriteLine();
    Console.WriteLine("     1 - Opção 1");
    Console.WriteLine("     2 - Opção 2");
    Console.WriteLine("     3 - Opção 3");
    Console.WriteLine("     4 - Opção 4");
    Console.WriteLine("     0 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            opcao1();
            break;

        case 2:
            opcao2();
            break;

        case 3:
            opcao3();
            break;

        case 4:
            opcao4();
            break;

    }
    Console.WriteLine();
    Console.WriteLine("Presione <Enter> para continuar");
    Console.WriteLine();

} while (opcao != 0);


void opcao1()
{
    Console.WriteLine($"você escolheu a opção {opcao}");
}

void opcao2()
{
    Console.WriteLine($"você escolheu a opção {opcao}");
}

void opcao3()
{
    Console.WriteLine($"você escolheu a opção {opcao}");
}

void opcao4()
{
    Console.WriteLine($"você escolheu a opção {opcao}");
}