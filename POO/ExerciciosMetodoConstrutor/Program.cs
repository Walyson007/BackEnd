using ExerciciosMetodoConstrutor;
// Carro c1 = new Carro("chevrole", "Camaro", 2000);
// c1.DadosCarro();
// System.Console.WriteLine();

/********************************************************************************/

// AlunoSobreCarga primeiroAluno = new AlunoSobreCarga();

// System.Console.WriteLine(@$"Primerio aluno:
//                         NOme:{primeiroAluno.nomeAluno}
//                         Nota:{primeiroAluno.nota}

// ");

// AlunoSobreCarga segundoAluno = new AlunoSobreCarga("Davi", 2);

// System.Console.WriteLine(@$"Segundo aluno:
//                         Nome:{segundoAluno.nomeAluno}
//                         Nota:{segundoAluno.nota}

// ");

/*******************************************************************************/

// ProdutoSobreCarga p1 = new ProdutoSobreCarga("Arroz", 23, 1);
// p1.DadosProduto();
// System.Console.WriteLine();

/*******************************************************************************/

//conta

/*******************************************************************************/

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Davi";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Walyson";
a2.Media();