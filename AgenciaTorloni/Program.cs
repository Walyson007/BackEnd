string[] nomes = new string[4];
double[] saldos = new double[4];
int opcao = -1, totalCliente = 0, totalSaldo = 0;
double s = 0;
do
{
    Console.Clear();
    Console.WriteLine("----------------------------");
    Console.WriteLine("  SISTEMA BANCARIO SIMPLES");
    Console.WriteLine("----------------------------");
    Console.WriteLine();
    Console.WriteLine("     1 - cadastrar");
    Console.WriteLine("     2 - Depositar");
    Console.WriteLine("     3 - Sacar");
    Console.WriteLine("     4 - Transferir");
    Console.WriteLine("     5 - Listar Cliente");
    Console.WriteLine("     0 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            cadastro();
            break;

        case 2:
            deposito();

            Console.WriteLine("Pressione <Enter> para continuar");
            Console.ReadLine();
            break;

        case 3:
            saque();
            break;

        case 4:
            transferencia();
            break;

        case 5:
            lista();
            break;

    }

} while (opcao != 0);


void cadastro()
{

    //verififcar se tem espaco no array para cadastrar
    if (totalCliente >= 4)
    
    {
        Console.WriteLine($"Limite de ocupação atingido");
        Console.WriteLine("Pressione <Enter> para continuar");
        Console.ReadLine();
        return;
    }

    //pedir os dados para o usuario(nome, idade)
    Console.WriteLine($"Digite o nome do cliente");
    string n = Console.ReadLine();

    //guardar no array
    nomes[totalCliente] = n;
    saldos[totalCliente] = s;
    totalCliente++;

    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Há {totalCliente} clientes(s) cadastrados(s) no sistema!");
    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}

void deposito()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Digite a quantia que deseja depositar");
    double valorDeposito = double.Parse(Console.ReadLine());

    saldos[idCliente] += valorDeposito;

    Console.WriteLine($"Valor R${valorDeposito} depositado com sucesso");

}

void saque()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Valor que deseja sacar: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    if (saldos[idCliente] >= valorSolicitado)
    {
        saldos[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saque realizado com sucesso");
    }
    else
    {
        Console.WriteLine("Saldo insuficente");
    }
    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}

void transferencia()
{
    Console.WriteLine($"==TRANSFÊNCIA==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {
        return;
    }

    Console.WriteLine($"Conta de destino: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {
        return;
    }

    Console.Write($"Valor para transferir: ");
    double valor = double.Parse(Console.ReadLine());

    if(saldos[idClienteOrigem] >= valor)
    {
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        Console.WriteLine("Transferencia concluida!");
    } else
    {
        Console.WriteLine("Saldo insuficiente");
    }
}

void lista()
{
    Console.WriteLine();
    Console.WriteLine($"Resultado: ");

    for (int i = 0; i < totalCliente; i++)
    {
        Console.WriteLine($"{i} Nome: {nomes[i]} | Saldo:  R${saldos[i]}");
        Console.WriteLine();
    }

    Console.WriteLine("Pressione <Enter> para continuar");
    Console.ReadLine();
}

int BuscarCliente()
{
    lista();
    Console.WriteLine($"Digite o numero do cliente:");
    int idCliente = int.Parse(Console.ReadLine());

    if (idCliente < 0 || idCliente >= totalCliente)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return idCliente;
}