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