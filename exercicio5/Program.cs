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