////using Bytebank;

////ContaCorrente Conta1 = new ContaCorrente();

////string result = Conta1.ResumoConta(15, "1010-x", "Leandro Santos", 100);

////Console.WriteLine(result);

////ContaCorrente contaDaMaria = new ContaCorrente();

////contaDaMaria.Titular = "Maria Souza";
////contaDaMaria.Numero_Agencia = 17;
////contaDaMaria.Conta = "1010-5";
////contaDaMaria.Saldo = 300;


////Console.WriteLine("Saldo da Conta Da Maria = " + contaDaMaria.Saldo);

////Conta1.Transferir(50, contaDaMaria);

////Console.WriteLine("SAldo da Leandro = " + Conta1.Saldo);

////Console.WriteLine("Saldo da Maria " + contaDaMaria.Saldo);


//using Bytebank.Contas;
//using Bytebank.Titular;

//PessoaFisica pessoa = new PessoaFisica();

//pessoa.Nome = " Andre";
//pessoa.CPF = "12345678911";
//pessoa.Profissao = " Analista";

//ContaCorrente conta = new ContaCorrente();

//conta.Titular = pessoa;

//conta.Conta = " 1010-x";
//conta.Numero_Agencia= 15;
//conta.Saldo = 100;


//Console.WriteLine("Titlar " + conta.Titular.Nome);
//Console.WriteLine("CPF " + conta.Titular.CPF);
//Console.WriteLine("Profissao : " + conta.Titular.Profissao);
//Console.WriteLine("Conta : " + conta.Conta);
//Console.WriteLine("Numero de Conta : " + conta.Numero_Agencia);
//Console.WriteLine("Saldo da Conta : " + conta.Saldo);

//conta.Depositar(100);

//Console.WriteLine("Depois de Efetuar depositivo de R$ 100 Saldo Anterior é era de R$ 100");
//Console.WriteLine($"Saldo Atual: é {conta.Saldo}");

//conta.ResumoConta();

//ContaCorrente conta2 = new ContaCorrente();
//conta2.Titular=  new PessoaFisica();

//conta2.Titular.Nome = "Jose";
//conta2.Titular.Profissao = "Testes";
//conta2.Titular.CPF = "1234567891";

//conta2.Conta = " 1015-x";
//conta2.Numero_Agencia = 20;
//conta2.Saldo = 100;


//Console.WriteLine("Titlar " + conta2.Titular.Nome);
//Console.WriteLine("CPF " + conta2.Titular.CPF);
//Console.WriteLine("Profissao : " + conta2.Titular.Profissao);
//Console.WriteLine("Conta : " + conta2.Conta);
//Console.WriteLine("Numero de Conta : " + conta2.Numero_Agencia);
//Console.WriteLine("Saldo da Conta : " + conta2.Saldo);

using Bytebank.Contas;
using Bytebank.Titular;

//ContaCorrente conta3  =new ContaCorrente();
//conta3.Numero_agencia= 10;
//conta3.Conta = "1518-9";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);


//ContaCorrente conta4 = new ContaCorrente(18,"1010-x");

//PessoaFisica pessoa = new PessoaFisica("Leandro", "1234164854", "Analista");
//conta4.SetSaldo(500);

ContaCorrente cont5 = new ContaCorrente(15, "1536");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
ContaCorrente cont6 = new ContaCorrente(25, "39851");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente cont7 = new ContaCorrente(25, "31111");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
