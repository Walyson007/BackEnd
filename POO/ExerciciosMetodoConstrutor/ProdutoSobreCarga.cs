using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ProdutoSobreCarga
    {
         public string nomeProduto;
        public double preco;
        public int estoque;

        public ProdutoSobreCarga(string nP, double pr, int es)
        {
            nomeProduto = nP;
            preco = pr;
            estoque = es; 
        }

        public void DadosProduto()
        {
            System.Console.WriteLine($@"O produto {nomeProduto}, do estoque {estoque} custa R${preco}");
        }
    }
}