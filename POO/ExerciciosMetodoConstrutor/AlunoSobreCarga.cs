using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class AlunoSobreCarga
    {
        public string nomeAluno;

        public int nota;

        public AlunoSobreCarga()
        {
            nomeAluno = "Desconhecido";
            nota = 0;
        }

        public AlunoSobreCarga(string n, int Nt)
        {
            nomeAluno = n;
            nota = Nt;
        }
         public void DadosAluno()
        {
            System.Console.WriteLine(@$"O aluno:{nomeAluno} tirou a nota {nota}");
        }
    }
}