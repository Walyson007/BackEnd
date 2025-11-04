namespace PrimeiraClasse
{
    public class Moto
    {
        //propriedade
        public int qtdRodas;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //métodos
        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");
        }
        public void frear()
        {
            Console.WriteLine($"Moto Freando");
        }

        public void ligar()
        {
            Console.WriteLine($"Moto ligando");

        }
        public void Desligar()
        {
            Console.WriteLine($"Moto Desligando");

        }
    }
}