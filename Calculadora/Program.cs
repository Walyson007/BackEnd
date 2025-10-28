/*Você deverá criar um programa chamado Calculadora, dentro do arquivo Program.cs, que siga as seguintes instruções:

Exibir um menu com as opções:   

   1 - Soma
   2 - Subtração
   3 - Multiplicação
   4 - Divisão
   0 - Sair

- O usuário escolhe a operação digitando o número correspondente.
- O sistema solicita dois números.
- A operação escolhida é executada por uma função que: Recebe os dois números como parâmetros.
- Retorna o resultado da operação.- O resultado é exibido no console.
- Após mostrar o resultado, o menu deve ser exibido novamente até o usuário escolher sair (opção 0).

ORIENTAÇÕES:
- Todas as operações (soma, subtração, multiplicação, divisão) devem ser implementadas em funções.
- As funções o resultado (por exemplo, double), e não apenas exibir o valor na tela.
- O código será escrito , (ou seja, apenas código de nível superior).
- Trate a divisão por zero para evitar erros.
- Utilize mensagens claras para interação com o usuário.

EXEMPLO DE FUNCIONAMENTO 

===== CALCULADORA =====

1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
0 - Sair
Escolha uma opção: 1

Digite o primeiro número: 10
Digite o segundo número: 5
Resultado: 15

Pressione qualquer tecla para continuar...*/

Console.Clear();

double numero1 = 0;
double numero2 = 0;
double total = 0;

int opcao = -1;

do
{
    Console.WriteLine("   =====CALCULADORA=====");
    Console.WriteLine();
    Console.WriteLine("     1 - Soma");
    Console.WriteLine("     2 - Subtração");
    Console.WriteLine("     3 - multiplicação");
    Console.WriteLine("     4 - divisão");
    Console.WriteLine("     0 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Você escolheu a opção {opcao} soma");
            Console.WriteLine("Agora digite o primeiro numero");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora digite o segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            total = Soma(numero1, numero2);
            Console.WriteLine($"O resultado da soma é {total}");
            break;

        case 2:
            Console.WriteLine($"Você escolheu a opção {opcao} subtração");
            Console.WriteLine();

            Console.WriteLine("Agora digite o primeiro numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Agora digite o segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            total = Subtração(numero1, numero2);
            Console.WriteLine($"O resultado da subtração é {total}");
            break;

        case 3:
            Console.WriteLine($"Você escolheu a opção {opcao} mutiplicação");
            Console.WriteLine();

            Console.WriteLine("Agora digite o primeiro numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Agora digite o segundo numero");
            numero2 = int.Parse(Console.ReadLine());

            total = Multiplicação(numero1, numero2);
            Console.WriteLine($"O resultado da multiplicação é {total}");
            break;

        case 4:

            Console.WriteLine($"Você escolheu a opção {opcao} divisão");
            Console.WriteLine();

            Console.WriteLine("Agora digite o primeiro numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Agora digite o segundo numero");
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 == 0)
            {
                Console.WriteLine("Divisão por zero");
            }
            else
            {

                total = Divisão(numero1, numero2);
                Console.WriteLine($"O resultado da divisão é {total}");
            }

            break;
    }
    Console.WriteLine();
    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

double Soma(double numeroRecebido1, double numeroRecebido2)
{
    return numeroRecebido1 + numeroRecebido2;
}

double Subtração(double numeroRecebido1, double numeroRecebido2)
{
    return numeroRecebido1 - numeroRecebido2;
}

double Multiplicação(double numeroRecebido1, double numeroRecebido2)
{
    return numeroRecebido1 * numeroRecebido2;
}

double Divisão(double numeroRecebido1, double numeroRecebido2)
{
    return numeroRecebido1 / numeroRecebido2;
}