using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente ccRalph = new ContaCorrente();

            ccRalph.titular = "Ralph";
            ccRalph.agencia = 842;
            ccRalph.numero = 842250;
            ccRalph.saldo = 1000;

            Console.WriteLine(ccRalph.titular);
            Console.WriteLine(ccRalph.agencia);
            Console.WriteLine(ccRalph.numero);
            Console.WriteLine(ccRalph.saldo);

            Console.ReadLine();
        }
    }
}

