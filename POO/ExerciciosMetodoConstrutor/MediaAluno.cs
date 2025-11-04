namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        //propriedades
        public string Nome;
        public double N1, N2, N3;

        //construtores
        public MediaAluno(double param1, double param2, double param3)
        {
            //Define os valores iniciais para as minhas propriedades
            //N1 = 0;   //fixo
            N1 = param1; //parametro param1 representa o valor do N1 - valor dinamico
            N2 = param2;
            N3 = param3;
        }
        public MediaAluno()
        {
            N1 = N2 = N3 = 0; //Atribunido valor fixo para as 3 propriedades de uma vez
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;

            System.Console.WriteLine($"A media do aluno(a) {Nome} é: {Media}");
        }
    }
}