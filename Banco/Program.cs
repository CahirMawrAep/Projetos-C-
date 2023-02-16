using System;
using System.Globalization;
namespace Banco
{
    internal class Banco
    {
        static void Main(string[] args)
        {
            Cadastrar conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string depOpt = Console.ReadLine();

            if ( depOpt == "s" || depOpt == "S")
            {
                Console.Write("Entre um valor para depósito: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Cadastrar(numero, titular, valor);

            }

            else
            {
                conta = new Cadastrar(numero, titular);
            }
            Console.WriteLine("\r\n Dados da Conta");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double valorr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorr);
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            valorr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorr);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            

        }
    }
}