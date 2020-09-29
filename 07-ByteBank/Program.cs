using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 8672343);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            ContaCorrente contaRalph = new ContaCorrente(867, 8674691);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
