using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int idadeRalph = 36;
            int idadeRalphOliveira = 36;

            ContaCorrente ccRalph = new ContaCorrente();
            ccRalph.titular = "Ralph";
            ccRalph.agencia = 442;
            ccRalph.numero = 442592;
            ccRalph.saldo = 140;

            ContaCorrente ccRalphOliveira = new ContaCorrente();
            ccRalph.titular = "Ralph";
            ccRalph.agencia = 442;
            ccRalph.numero = 442592;
            ccRalph.saldo = 140;

            Console.WriteLine("Igualdade de tipo de referência: " + (ccRalph == ccRalphOliveira));
            Console.WriteLine("Igualdade de tipo de valor: " + (idadeRalph == idadeRalphOliveira));
        }
    }
}
