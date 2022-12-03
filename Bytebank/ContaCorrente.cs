using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    public class ContaCorrente
    {

        public int Numero_Agencia;
        public string Conta;
        public string Titular;
        public double Saldo = 100;

        public string ResumoConta()
        {
            Console.WriteLine("Resumo da conta :");
            return "teste";
        }

        public string ResumoConta(int numero_agencia, string conta, string titular, double saldo)
        {
            this.Conta = conta;
            this.Numero_Agencia = numero_agencia;
            this.Titular = titular;
            this.Saldo = saldo;

            Console.WriteLine("Resumo da conta :");
            return "Numero da Conta " + conta + " \nNumero da AG: " + numero_agencia + " \nTitular: " 
                + titular + "\nSaldo da Conta é: R$" + saldo ;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;

        }

        public void Saque(double valor)
        {
            if(valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
               
            }
        }


        public bool Transferir(double valor, ContaCorrente destino )
        {
            if(this.Saldo < valor)
            {
                return false;
            }
            else
            {
                this.Saque(valor);
                destino.Depositar(valor);
                return true;
            }
        }
    }
}
