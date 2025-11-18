using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;


        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            Valor = valFat;
            DiasDeAtraso = qtdAtraso;
        }

        public void imprimir()
        {
            //Calculara o juros antes de usar o valor da Fatura


            System.Console.WriteLine(@$"
            Credor: {Credor}
            Devedor: {Devedor}
            Dias de Atraso: {DiasDeAtraso} dia(s)
            Valor: R${Valor:F2}
            Juros: R${(Juros * DiasDeAtraso):F2}");
            CalcularValorDivida();
            System.Console.WriteLine(@$"
            Total com juros: R${Valor:F2};
            ");
        }

        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            
            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine(@$"
            Dívida encaminhada para o SERASA");
            }
        }
    }
}