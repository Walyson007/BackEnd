using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class ContaBancariaSobreCarga
    {
        public string titular;
        public double saldo;

        public ContaBancariaSobreCarga(string T, double S)
        {
            titular = T;
            saldo = S;
        }
        
        public ContaBancariaSobreCarga(string T)
        {
            titular = T;
            saldo = 0;
        }
    }
}