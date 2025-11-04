
namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string nomeAluno;
        public int nota;

        public Aluno(string N, int Nt)
        {
            nomeAluno = N;
            nota = Nt;
        }

        public Aluno()
        {
            nomeAluno = "Desconhecido";
            nota = 0;
        }
        
        public void DadosAluno()
        {
            System.Console.WriteLine(@$"O aluno:{nomeAluno} tirou a nota {nota}");
        }
    }
}