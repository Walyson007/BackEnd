string cargo;
double salario, novoSalario, aumento = 0;

Console.WriteLine("Digite o cargo: ");
Console.WriteLine("1- Produção ");
Console.WriteLine("2- Administrativo ");
Console.WriteLine("3- Diretoria ");
cargo = Console.ReadLine();
  
Console.WriteLine("Digite o salário: ");
salario = double.Parse(Console.ReadLine());

if (cargo == "produção")
{
    aumento = 6.5;
}
else if (cargo == "administrativo")
{
    aumento = 7.5;
}
else if (cargo == "diretoria")
{
    aumento = 12;
}
else
{
    Console.WriteLine("cargo invalido, sem direito a reajustes.");
}

novoSalario = salario + (salario * aumento / 100);


Console.WriteLine($"Cargo: {cargo}");
Console.WriteLine($"Salario Antigo: R${salario}");
Console.WriteLine($"Aumento: {aumento}%");
Console.WriteLine($"Novo Salario: R${novoSalario}");