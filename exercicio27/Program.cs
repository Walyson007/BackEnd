int q = 0, i = 1, n = 1;

Console.WriteLine("Quantos números voce quer exibir? ");
q = int.Parse(Console.ReadLine());

while (n <= q)
{
    Console.WriteLine("Digite um número:");
    if (i % 2 == 0)
    {
        Console.WriteLine($"Foi encontrado o numero par: {i}");
    }
    n++;
}