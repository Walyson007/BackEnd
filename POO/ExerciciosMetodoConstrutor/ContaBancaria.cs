using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ContaBancaria
    {
        public string titular;
        public double saldo;

        public ContaBancaria(string T, double S)
        {
            titular = T;
            saldo = S;
        }
        
        public void Dadosconta()
        {
            System.Console.WriteLine($"A conta to titular {titular}, tem o saldo de R${saldo}");
        }
    }
}