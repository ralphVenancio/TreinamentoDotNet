using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Ralph";
            cliente.Cpf = "111.109.837-94";
            cliente.Profissao = "Analista de BI";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
