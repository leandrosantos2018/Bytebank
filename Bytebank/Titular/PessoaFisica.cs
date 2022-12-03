using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Titular
{
    public class PessoaFisica
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Profissao { get; set; }

        public void Exibir()
        {
            Console.WriteLine("Nome : " + Nome);
            Console.WriteLine("CPF : " + CPF);
            Console.WriteLine("Profissão : " + Profissao);
        }


    }
}
