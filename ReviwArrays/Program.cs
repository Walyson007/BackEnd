using System.Net.WebSockets;
string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;


do
{
    Console.Clear();
    Console.WriteLine($"1) Cadastrar Alunos");
    Console.WriteLine($"2) Listar alunos");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Digite uma opção");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            Console.WriteLine($"Pressione <Enter> para encerrar...");
            Console.ReadLine();
            break;

        case 1:
            CadastrarAluno();
            break;

        case 2:
            ListarAlunos();
            break;

        default:
            Console.WriteLine($"opção invalida, pressione <Enter> para continuar...");
            Console.ReadLine();
            break;
    }
    
} while (opcao != 0);


//=================== Funções


void CadastrarAluno()
{

    //verififcar se tem espaco no array para cadastrar
    if (totalAlunos >= 4)
    {
        Console.WriteLine($"Limite de ocupação atingido");
        Console.WriteLine("Pressione <Enter> para continuar");
        Console.ReadLine();
        return;
    }

    //pedir os dados para o usuario(nome, idade)
    Console.WriteLine($"Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    //guardar no array
    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine($"Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} alunos(s) cadastrados(s) no sistema!");
    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}


//função para exibir os alunos
void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Nome: {nomes[i]}");
        Console.WriteLine($"Idade: {idades[i]} anos");

        Console.WriteLine();
    }
    
    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}



