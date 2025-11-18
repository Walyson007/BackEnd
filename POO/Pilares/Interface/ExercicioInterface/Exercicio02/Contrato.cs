
namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string prestadorServico, string TxtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = prestadorServico;
            TextoClausulas = TxtClausulas;
        }
        public void imprimir()
        {
         System.Console.WriteLine($@"
         Partes:
            Contratante: {Contratante}
            Contratada:  {PrestadorServico}
            Clausulas do contrato:

            {TextoClausulas}
            --
        ");
            
        }
    }
}