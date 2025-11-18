using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome;
        public string TextoRelatorio = "";

        //SobreCarga do construtor
        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }
        
        public void imprimir()
        {
            System.Console.WriteLine($"Responsavel: {Nome}...");
            System.Console.WriteLine(TextoRelatorio);
            System.Console.WriteLine($"---FIM---");
        }
    }
}