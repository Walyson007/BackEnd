using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa3SobreCargas
    {
        public string Nome;

        public int Idade;

        public Pessoa3SobreCargas()
        {
            Nome = "Desconhecido";
            Idade = 0;
        }

        public Pessoa3SobreCargas(string n)
        {
            Nome = n;
            Idade = 0;
        }

        public Pessoa3SobreCargas(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}; Idade: {Idade}");
        }
    }
}