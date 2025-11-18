

namespace TheBasics
{
    public class Veiculo
    {
        public String Marca;
        public string Modelo;
        public int QtdRodas;
        public void Ligar()
        {
            System.Console.WriteLine($"Ligando veiculo");
        }
        public void Desligar()
        {
            System.Console.WriteLine($"Veiculo desligando");
        }

    }
}