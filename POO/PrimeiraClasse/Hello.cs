
namespace PrimeiraClasse
{


    public class Hello
    {
        //Propriedades/Caracteristicas - variaveis internas dessa classe
        public string TextoHello = "";

        //Metodos/comportamentos/acoes - sao as funcoes internas desa classe
        public void SaldarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }

        public void SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }//fim da classe
}// fim do namespace