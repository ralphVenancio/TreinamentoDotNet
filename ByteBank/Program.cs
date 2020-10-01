using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Ralph";
            carlos.CPF = "546.879.157.20";
            carlos.Salario = 2000;

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
