using System;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();

            cc.titular = "Alessandra";

            Console.WriteLine(cc.titular);
            Console.WriteLine(cc.agencia);
            Console.WriteLine(cc.saldo);

            Console.ReadLine();
        }
    }
}
