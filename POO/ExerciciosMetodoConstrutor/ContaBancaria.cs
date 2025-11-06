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


// ******** ENCAPSULAMENTO ********** //
public class ContaBancaria
{
    private double saldo; // dado protegido
    public double Saldo //propriedade
    {
        get { return saldo; }          // Permite ler o valor
        private set                   // Só pode ser alterado dentro da classe
        {
            if (value >= 0)            // Garante que o saldo nunca seja negativo
                saldo = value;
        }
    }
    public void Depositar(double valor)
    {
        if (valor > 0)
            saldo += valor;
    }

    public double ConsultarSaldo()
    {
        return saldo;
    }
}
    