int q = 0, contador = 0, numero1 = 0, numero2 = 0;

Console.WriteLine("Digite o número de repetição");
q = int.Parse(Console.ReadLine());

while(contador < q)
{
    Console.WriteLine("Digite o primeiro número:");
    numero1 = int.Parse(Console.ReadLine);

    Console.WriteLine("Digite o segundo número:");
    numero2 = int.Parse(Console.ReadLine);

    if (numero1 > numero2)
    {
        Console.WriteLine($"O número {numero1} é maior que o número {numero2}");
    }
    else if (numero2 > numero1)
    {
        Console.WriteLine($"O número {numero2} é maior que o número {numero1}");
    }
    else
    {
        Console.WriteLine($"Os números {numero2} e {numero1} são iguais.");
    }
    contador++;
}