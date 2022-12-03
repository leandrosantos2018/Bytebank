using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank.Titular;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }

        private int Numero_Agencia;
        private  int Numero_agencia
        {
            get { return this.Numero_Agencia; }
            set {
                if (value > 0)
                { this.Numero_Agencia = value;
                }

            }
        }


        //private string? _Conta;

        public string Conta { get; }

        private double Saldo = 100;

        public PessoaFisica? Titular;

        public ContaCorrente(int numero_agencia,string conta)
        {
            this.Numero_agencia= numero_agencia;
            this.Conta = conta;  
            TotalDeContasCriadas++;
        }

      



        public string ResumoConta()
        {
            //Console.WriteLine("Resumo da conta :");
            return "teste";
        }

        //public string ResumoConta(int numero_agencia, string conta, PessoaFisica titular, double saldo)
        //{
        //  //  Conta = conta;
        //    Numero_Agencia = numero_agencia;
        //    Titular = titular;
        //    Saldo = saldo;

        //    Console.WriteLine("Resumo da conta :");
        //    return "Numero da Conta " + conta + " \nNumero da AG: " + numero_agencia + " \nTitular: "
        //        + titular + "\nSaldo da Conta é: R$" + saldo;
        //}

        public void Depositar(double valor)
        {
            Saldo += valor;

        }

        public void Saque(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");

            }
        }


        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saque(valor);
                destino.Depositar(valor);
                return true;
            }
        }

       public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }else
            {
                this.Saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.Saldo;
        }
    }
}
