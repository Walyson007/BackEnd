
namespace TheBasics
{
    public class Professor : Pessoa
    {
        public float Salario;

        //chama o construtor da calsse mae e repassa e endereco pra la
        public Professor(Endereco endereco) : base(endereco)
        {

        }
    }
}