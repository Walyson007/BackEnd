int n, resultado = 0;

for (int i = 2; i >= 0; i--)
{
    Console.WriteLine("Digite o número: ");
    n = int.Parse(Console.ReadLine());
    resultado += n;
}

Console.WriteLine($"Somatoria total: {resultado}");