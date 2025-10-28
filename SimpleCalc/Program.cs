/*
Pedir o nome usuário, 
Pedir dois numeros e 
mostrar a soma dos números no final
*/

string nome;
int numero1;
int numero2;
int soma;

//Pedir os nome pro usuario
Console.WriteLine("Digite seu nome");
nome = Console.ReadLine();

//Pedir os dois números
Console.WriteLine  ("Digite o primeiro números");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo números");
numero2 = int.Parse(Console.ReadLine());


//Somer os dois números
soma = numero1 + numero2;

Console.WriteLine(nome);
Console.WriteLine(soma);