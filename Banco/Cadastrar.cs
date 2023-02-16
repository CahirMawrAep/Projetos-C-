using System;
using System.Globalization;
namespace Banco
{
    class Cadastrar
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double ContaBancaria { get; private set; }

        public Cadastrar(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Cadastrar(int numero, string titular, double contaBancaria) : this(numero, titular)
        {
            ContaBancaria = contaBancaria;
        }

        public void Deposito(double quantia)
        {
            ContaBancaria += quantia;
        }

        public void Saque(double saque)
        {
            ContaBancaria -= (saque + 5.00);
        }


        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + ContaBancaria.ToString("F2", CultureInfo.InvariantCulture) ; 
        }

    }
}
