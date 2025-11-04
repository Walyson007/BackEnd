//Imports das classes externas
using System.Security.Authentication;
using PrimeiraClasse;

// //cria uma variavel tipo string
// String nome = "Walyson Menezes";

// //Cria um objeto do tipo Hello
// Hello cumprimento = new Hello();
// //acessa a propriedade TextoHello e adicionando
// cumprimento.TextoHello = "Olá usuário";
// //acessa o metodo SaldarUsuario que imprimi
// cumprimento.SaldarUsuario();
// cumprimento.SaldarComNome("Walyson Menezes");

// Carro c1 = new Carro();
// c1.marca = "Lamborghini";
// c1.modelo = "Urus";
// c1.cor = "Azul escuro";
// c1.qtdPortas = 4;
// c1.qtdRodas = 4;
// c1.ligar();
// c1.Acelerar();
// c1.frear();
// c1.Desligar();

// Carro c2 = new Carro();
// c2.marca = "Chevrolet";
// c2.modelo = "Camaro";
// c2.cor = "Amarelo";
// c2.qtdPortas = 2;
// c2.qtdRodas = 4;

// Console.WriteLine($"Ligando o    {c2.modelo}");
// Console.WriteLine($"Acelrando o  {c2.modelo}");
// Console.WriteLine($"Freando o    {c2.modelo}");
// Console.WriteLine($"Desligando o {c2.modelo}");

// Console.WriteLine();
// Console.WriteLine($"Caracteristicas");
// Console.WriteLine();

// Console.WriteLine($"--------- {c1.marca} ----------");
// Console.WriteLine($"Carro:  {c1.marca }");
// Console.WriteLine($"Modelo: {c1.modelo}");
// Console.WriteLine($"Cor:    {c1.cor   }");
// Console.WriteLine($"Quantidade de Portas: {c1.qtdPortas}");
// Console.WriteLine();
// Console.WriteLine("-----");
// Console.WriteLine();

// Console.WriteLine($"--------- {c2.marca} ----------");
// Console.WriteLine($"Carro:  {c2.marca }");
// Console.WriteLine($"Modelo: {c2.modelo}");
// Console.WriteLine($"Cor:    {c2.cor   }");
// Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
// Console.WriteLine();


/*Criar uma classe que representa uma moto
pelo menos 4 propriedade
pelo menos 3 metodos

na classe program, instanciar 2 objetos mot e exibir as propriedades e rodar os metodos igual fizemos com a classe carro*/

Moto c1 = new Moto();
c1.marca = "Lamborghini";
c1.modelo = "Ducati";
c1.cor = "Verde escuro";
c1.qtdRodas = 2;
c1.ligar();
c1.Acelerar();
c1.frear();
c1.Desligar();

Moto c2 = new Moto();
c2.marca = "Triumph";
c2.modelo = "Tiger 800";
c2.cor = "Preto";
c2.qtdRodas = 2;

Console.WriteLine($"Ligando o    {c2.modelo}");
Console.WriteLine($"Acelrando o  {c2.modelo}");
Console.WriteLine($"Freando o    {c2.modelo}");
Console.WriteLine($"Desligando o {c2.modelo}");

Console.WriteLine();
Console.WriteLine($"Caracteristicas");
Console.WriteLine();

Console.WriteLine($"--------- {c1.marca} ----------");
Console.WriteLine($"Moto:  {c1.marca }");
Console.WriteLine($"Modelo: {c1.modelo}");
Console.WriteLine($"Cor:    {c1.cor   }");
Console.WriteLine();
Console.WriteLine("-----");
Console.WriteLine();

Console.WriteLine($"--------- {c2.marca} ----------");
Console.WriteLine($"Moto:  {c2.marca }");
Console.WriteLine($"Modelo: {c2.modelo}");
Console.WriteLine($"Cor:    {c2.cor   }");
// Console.WriteLine($"Quantidade de Portas: {c2.qtdPortas}");
Console.WriteLine();