using Bytebank;

ContaCorrente Conta1 = new ContaCorrente();

string result = Conta1.ResumoConta(15, "1010-x", "Leandro Santos", 100);

Console.WriteLine(result);

ContaCorrente contaDaMaria = new ContaCorrente();

contaDaMaria.Titular = "Maria Souza";
contaDaMaria.Numero_Agencia = 17;
contaDaMaria.Conta = "1010-5";
contaDaMaria.Saldo = 300;


Console.WriteLine("Saldo da Conta Da Maria = " + contaDaMaria.Saldo);

Conta1.Transferir(50, contaDaMaria);

Console.WriteLine("SAldo da Leandro = " + Conta1.Saldo);

Console.WriteLine("Saldo da Maria " + contaDaMaria.Saldo);