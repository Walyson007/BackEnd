using TheBasics;
Console.Clear();

// //arrays/lista de pessoas
// List<Pessoa> peoples = new List<Pessoa>();
// /**************WALYSON******************************/
// //ENDERECO
// Endereco enderecoWaly = new Endereco();
// enderecoWaly.Logradouro = "Rua monsenhor pizzaro";
// // PESSOA COM ENDERECO
// Pessoa waly = new Pessoa(enderecoWaly);
// waly.Nome        = "Walyson";
// waly.Idade = 17;

// /***************DAVI********************************/
// //ENDERECO
// Endereco enderecoDavi = new Endereco();
// enderecoDavi.Logradouro = "Rua Cachoeira dourada";
// //PESSOA COM ENDERECO
// Pessoa Davi = new Pessoa(enderecoDavi);
// Davi.Nome        = "Davi";
// Davi.Idade       = 17;

// // GUARDANDO OS DADOS NA LISTA

// peoples.Add(waly);
// peoples.Add(Davi);



// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome; {p.Nome}");
// }

// Endereco endoMuniz = new Endereco();
// endoMuniz.Logradouro = "Cachoeira Dourada";
// endoMuniz.Numero = 188;
// Aluno DaviMuniz = new Aluno(endoMuniz);
// DaviMuniz.Nome = "Davi Muniz";
// DaviMuniz.Curso = "Desenvolvimento de sistema";
// DaviMuniz.RA = "111970666-X";
// DaviMuniz.NotaFinal = 10;

// Endereco endoWaly = new Endereco();
// endoWaly.Logradouro = "Monsenhor Pizzaro";
// endoWaly.Numero = 27;

// Professor proWaly = new Professor(endoWaly);
// proWaly.Nome = "Walyson Menezes";

// System.Console.WriteLine($"Aluno {DaviMuniz.Nome} estuda na turma de {DaviMuniz.Curso} do prof {proWaly.Nome}");

// Moto Tiger = new Moto();
// Tiger.Marca = "Triumph";
// Tiger.Modelo = "1200";

// Carro Camaro = new Carro();
// Camaro.Marca = "Chevrolet";
// Camaro.Modelo = "2000";

Avião avião = new Avião();
avião.Companhia = "Gol";
avião.QtdAssentos = 150;
avião.QtdTurbinas = 4;
System.Console.WriteLine($"O avião da companhia {avião.Companhia} tem {avião.QtdAssentos} assentos e {avião.QtdTurbinas} turbinas");
avião.Decolar();

// Camaro.Ligar();
// Camaro.AbrirPortaMaLas();

// Tiger.Ligar();
// Tiger.Empinar();