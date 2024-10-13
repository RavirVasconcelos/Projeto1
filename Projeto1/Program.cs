using System;
using System.Globalization;

namespace Projeto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Banco b;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá déposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's')
            {
                Console.Write("Entre o valor de depósito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                b = new Banco(conta, nome, depositoInicial);
                Console.WriteLine();
            }
            else
            {
                b = new Banco(conta, nome);
                Console.WriteLine();
            }
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(b);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(b);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(b);
        }
    }
}