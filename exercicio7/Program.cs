/*Crie um menu de console igual ao exibido abaixo, utilizando a estrutra switch do c#:

-------------------------------------------------------
        Bem Vindo, Usuário
-------------------------------------------------------


Escolha uma opção no menu abaixo:

   1) Opção 1
   2) Opção 2
   3) Opção 3
   0) Sair                                                                              */

int opcao = -1;

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

    switch(opcao)
    {
        case 1:
            Console.WriteLine($"você escolheu a opção {opcao}");
        break;
            
        case 2:
            Console.WriteLine($"você escolheu a opção {opcao}");
        break;
            
        case 3:
            Console.WriteLine($"você escolheu a opção {opcao}");
        break;
            
        case 4:
            Console.WriteLine($"você escolheu a opção {opcao}");
        break;
            
        case 5:
            Console.WriteLine($"você escolheu a opção {opcao}");
        break;
    }