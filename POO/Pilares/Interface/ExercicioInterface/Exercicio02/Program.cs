using Exercicio02;

//
List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatDavi = new Fatura("Davi", "Walyson", 200, 31);
// Relatorio relDavi = new Relatorio("Davi", "asdfakdhfuhrivn ");
// Contrato docDavi = new Contrato("Walyson", "Davi", "Não pode a quebra de contrato");


// fatDavi.imprimir();
// relDavi.imprimir();
// docDavi.imprimir();

int opcao;
do
{
    System.Console.WriteLine("Menu de Opções");
    System.Console.WriteLine($@"
1) Cadastrar Faturas
2) Cadastrar Relatórios
3) Cadastrar Contratos
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolha a opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            System.Console.WriteLine($"Cadastrar Faturas");
            CadastrarFatura();
            break;

        case 2:
            System.Console.WriteLine($"Cadastrar Relatórios");
            CadastrarRelatorio();
            break;

        case 3:
            System.Console.WriteLine($"Cadastrar Contratos");
            CadastrarContrato();
            break;

        case 4:
            System.Console.WriteLine($"Listar Faturas");
            listarFatura();
            break;

        case 5:
            System.Console.WriteLine($"Listar Relatórios");
            listarRelatorio();
            break;

        case 6:
            System.Console.WriteLine($"Listar Contratos");
            listarContrato();
            break;

        case 0:
            System.Console.WriteLine($"Saindo...");
            break;

        default:
            System.Console.WriteLine("Esse item não está disponivel");
            break;
    }

    System.Console.WriteLine($"Aperte <ENTER> para continuar");
    Console.ReadLine();
} while (opcao != 0);


// =======================FUNCOES AUXILIARES=================================

//------------------------------FATURA----------------------------------
void CadastrarFatura()
{
    System.Console.WriteLine($"Digite qual o nome do devedor: ");
    System.Console.Write("");
    string dev = Console.ReadLine();

    System.Console.WriteLine($"Digite qual o nome do credor: ");
    System.Console.Write("");
    string cred = Console.ReadLine();

    System.Console.WriteLine($"Digite qual o valor da fatura: ");
    System.Console.Write("");
    float valor = float.Parse(Console.ReadLine());

    System.Console.WriteLine($"Quantos dias a fatura está em atraso: ");
    System.Console.Write("");
    int diasAtraso = int.Parse(Console.ReadLine());

    // cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, valor, diasAtraso);
    // cadastra a fatura na lista
    documentos.Add(f);
}

void listarFatura()
{
 foreach(var item in documentos)
    {
        if(item is Fatura)
        {
            item.imprimir();
        }
    }
}

//---------------------RELATORIO---------------------------------

void CadastrarRelatorio()
{
    System.Console.WriteLine($"Digite seu nome");
    string nome = Console.ReadLine();

    System.Console.WriteLine($"Digite seu texto do relatório");
    string txtRelatorio = Console.ReadLine();

    Relatorio r = new Relatorio(nome, txtRelatorio);
    documentos.Add(r);
}

void listarRelatorio()
{
    foreach(var item in documentos)
    {
         if(item is Relatorio)
        {
            item.imprimir();
        }
    }
}

//------------------------CONTRATO--------------------------------

void CadastrarContrato()
{
    System.Console.WriteLine($"Digite o nome do contratante");
    string Contratante = Console.ReadLine();

    System.Console.WriteLine($"Digite o nome prestador do serviço");
    string prestadorServico = Console.ReadLine();

    System.Console.WriteLine($"Quais as clausulas do contrado");
    string TextoClausulas = Console.ReadLine();

    Contrato contrato = new Contrato(Contratante, prestadorServico, TextoClausulas);
    documentos.Add(contrato);
}

void listarContrato()
{
    foreach(var item in documentos)
    {
       if(item is Contrato)
        {
            item.imprimir();
        }
    }
}
