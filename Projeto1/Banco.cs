using System;
using System.Globalization;

namespace Projeto
{
    public class Banco
    {
        public int Conta { get; private set; }
        public string Usuario { get; set; }
        public double Saldo { get; private set; }

        public Banco(int conta, string usuario)
        {
            Conta = conta;
            Usuario = usuario;
        }
        public Banco(int conta, string usuario, double deposito) : this(conta, usuario)
        {
            Saldo = deposito;
        }
        public void DepositoInicial(double deposito)
        {
            Saldo += deposito;
        }
        public double Deposito(double deposito)
        {
            return Saldo += deposito;
        }
        public double Saque(double saque)
        {
            return Saldo -= saque + 5.00;
        }
        public override string ToString()
        {
            return "Conta " +
                Conta + ", Titular: " +
                Usuario + ", Saldo: $ " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}