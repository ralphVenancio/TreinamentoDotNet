using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Cliente ralph = new Cliente();


            //ralph.nome = "Ralph Venancio de Oliveira";
            //ralph.profissao = "Analista de BI";
            //ralph.cpf = "111.109.837-94";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = ralph;
            //conta.titular = new Cliente();
            conta.titular.nome = "Ralph Venancio de Oliveira";
            conta.titular.cpf = "111.109.837-94";
            conta.titular.profissao = "Analista de BI";
            conta.saldo = 3000;
            conta.agencia = 456;
            conta.numero = 4567865;

            //Console.WriteLine(ralph.nome);
            //Console.WriteLine(conta.titular.nome);

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
