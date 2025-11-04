using MetodoConstrutor;

//fontes é uma variavel do tipo pessoa
// Pessoa fontes = new Pessoa("João", 17);

// fontes.Nome = "Lorenzo";
// fontes.Idade = 17;

// System.Console.WriteLine(@$"O objeto pessoa que criei é o {fontes.Nome} com a idade {fontes.Idade}");

// // fontes.Nome = "Gustavo Oliveira";
// fontes.ExibirDados();

// System.Console.WriteLine($"{fontes.Nome}");



//Primerio moto construtor da class Pessoa3SobreCargas
Pessoa3SobreCargas PrimeiraPessoa = new Pessoa3SobreCargas("Davi Muniz", 17);

System.Console.WriteLine(@$"Primeria pessoa cadastrada:
                            Nome: {PrimeiraPessoa.Nome}
                            Idade:{PrimeiraPessoa.Idade}
                            
");


//Segunda moto construtor da class Pessoa3SobreCargas
Pessoa3SobreCargas SegundaPessoa = new Pessoa3SobreCargas("Matheus Felix");

System.Console.WriteLine(@$"Segunda pessoa cadastrada:
                            Nome: {SegundaPessoa.Nome}
                            Idade:{SegundaPessoa.Idade}
                            
");

//Terceiro metodo construtor da class Pessoa3SobreCargas
Pessoa3SobreCargas TerceiraPessoa = new Pessoa3SobreCargas();

System.Console.WriteLine(@$"Terceira pessoa cadastrada:
                            Nome: {TerceiraPessoa.Nome}
                            Idade:{TerceiraPessoa.Idade}
                            
");
System.Console.WriteLine("Digite um nome");
TerceiraPessoa.Nome = Console.ReadLine();

System.Console.WriteLine("Digite uma idade");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Terceira pessoa cadastrada:");
System.Console.WriteLine($"Nome:{TerceiraPessoa.Nome}, Idade:{TerceiraPessoa.Idade}");