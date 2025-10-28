int opcao = -1;
do
{
    Console.WriteLine("----------------------------");
    Console.WriteLine("     Bem-vindo, usuário");
    Console.WriteLine("----------------------------");
    Console.WriteLine();
    Console.WriteLine("     1 - Salário");
    Console.WriteLine("     2 - Time");
    Console.WriteLine("     3 - Triangulo");
    Console.WriteLine("     4 - senha");
    Console.WriteLine("     5 - Quantidade maçã");
    Console.WriteLine("     6 - nota");
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

        case 5:
            opcao5();
            break;

        case 6:
            opcao6();
            break;

    }
    
    Console.WriteLine();
    Console.WriteLine("Presione <Enter> para continuar");
    Console.WriteLine();

} while (opcao != 0);


void opcao1()
{
    int salario, totalGasto;

Console.WriteLine("Digite o seu salário: ");
salario = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o total gasto: ");
totalGasto = int.Parse(Console.ReadLine());

int dinheiroSobrando = salario - totalGasto;

if (salario >= totalGasto)
{
    Console.WriteLine("Gastos dentro do orçamento!");
    Console.WriteLine($"Dinheiro sobrando {dinheiroSobrando}");
} 
else
{
    Console.WriteLine("Orçamento estourado!");
}
}

void opcao2()
{
   string time1, time2;
int golsTimeUm, golsTimeDois;

Console.WriteLine("Digite o primeiro time: ");
time1 = (Console.ReadLine());

Console.WriteLine("Digite o segundo time: ");
time2 = (Console.ReadLine());

Console.WriteLine("Digite os gols do Time 1: ");
golsTimeUm = int.Parse(Console.ReadLine());

Console.WriteLine("Digite os gols do Time 2: ");
golsTimeDois = int.Parse(Console.ReadLine());

if (golsTimeUm > golsTimeDois)
{
    Console.WriteLine($"Vitória do {time1}");
    Console.WriteLine($"Placar: {golsTimeUm} X {golsTimeDois}");
}
else if (golsTimeDois > golsTimeUm)
{
    Console.WriteLine($"Vitória do {time2}");
    Console.WriteLine($"Placar: {golsTimeUm} X {golsTimeDois}");
}
else
{
    Console.WriteLine("O jogo terminou EMPATADO!");
    Console.WriteLine($"Placar: {golsTimeUm} X {golsTimeDois}");
}
}

void opcao3()
{
   double lado1, lado2, lado3;

Console.WriteLine("Digite o primeiro lado do triângulo:");
lado1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo lado do triângulo:");
lado2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro lado do triângulo:");
lado3 = double.Parse(Console.ReadLine());

if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else
    {
        Console.WriteLine("Triângulo Escaleno");
    }
}
else
{
    Console.WriteLine("As medidas informadas não formam um triângulo.");
}
}

void opcao4()
{
   int senha = 1234;
int senhaDigitada = 0;

Console.WriteLine("Digite a senha correta de 4 digitos");
senhaDigitada = int.Parse(Console.ReadLine());

if (senha == senhaDigitada)
{
    Console.WriteLine("Senha Correta");
}
else
{
    Console.WriteLine("Senha Incorreta");
}
}

void opcao5()
{
int quantidade;
double preco = 0;
double total;

Console.Clear();
Console.Write("Digite o número de maçãs compradas: ");
quantidade = int.Parse(Console.ReadLine());

total = preco * quantidade;

if (quantidade >= 12)
{
    preco = 0.25;
}
else
{
    preco = 0.30;
}


Console.WriteLine($"O valor total da compra é: R$ {preco * quantidade}");
}

void opcao6()
{
int nota = 0;
double presencia = 0;

Console.Clear();
Console.WriteLine("Escreva a nota");
nota = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva a presencia");
presencia = double.Parse(Console.ReadLine());

if (presencia < 75)
{
    Console.WriteLine(" Melhoras");
    Console.WriteLine("REPROVADO :(");
}
else if(nota < 7)
{
    Console.WriteLine(" Você consegue");
    Console.WriteLine("  RECUPERAÇÃO");
}
else
{
    Console.WriteLine(" Parabéns");
    Console.WriteLine("APROVADO :)");
}
}