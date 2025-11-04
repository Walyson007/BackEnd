
namespace PrimeiraClasse
{
    public class Carro
    {
        //propriedade
        public int qtdRodas;
        public int qtdPortas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //métodos
        public void Acelerar()
        {
            Console.WriteLine($"Carro Acelerando");
        }
        public void frear()
        {
            Console.WriteLine($"Carro Freando");
        }

        public void ligar()
        {
            Console.WriteLine($"Carro ligando");

        }
        public void Desligar()
        {
            Console.WriteLine($"Carro Desligando");

        }
    }
}