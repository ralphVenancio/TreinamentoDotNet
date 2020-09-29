using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente ccRalph = new ContaCorrente();
            ContaCorrente contaDestino = new ContaCorrente();

            double valor = 2000;
            double valorDeposito = 500;
            ccRalph.Depositar(valor);

            ccRalph.Transferir(valorDeposito, contaDestino);

            Console.WriteLine("Saldo da conta do Ralph: " + ccRalph.saldo);
            Console.WriteLine("Saldo da conta de Destino: " + contaDestino.saldo);

            Console.ReadLine();
        }
    }
}
