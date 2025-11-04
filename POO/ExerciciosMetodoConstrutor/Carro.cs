namespace ExerciciosMetodoConstrutor
{
    public class Carro
    {
        public string Marca;
        public string Modelo;

        public int Ano;

        public Carro(string m, string md, int a)
        {
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        public void DadosCarro()
        {
            System.Console.WriteLine(@$"A marca do carro é: {Marca}, modelo: {Modelo} {Ano}");
        }
    }
}