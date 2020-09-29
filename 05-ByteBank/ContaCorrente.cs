using System;
namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia = 442;
        public int numero;
        public double saldo;

        public ContaCorrente()
        {
        }

        public string Sacar(double valor)
        {
            if(this.saldo < valor)
            {
                string operationResult = "A operação não pode ser concluída.\n Saldo insuficiente:";
                return operationResult;
            }
            else
            {
                this.saldo -= valor;
                string operationResult = "Operação realizada com sucesso.\n Saldo atual: " + this.saldo;
                return operationResult;
            }
        }

        public string Depositar(double valor)
        {

            this.saldo += valor;
            string operationResult = "Operação realizada com sucesso.\n Saldo atual: " + this.saldo;
            return "Saldo atual: " + this.saldo;
        }

        public void Extrato()
        {
            Console.WriteLine("Salso atual da conta: " + this.saldo);
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this.saldo < valor)
            {
                return "A transferência não pode ser realizada.\nSaldo insuficiente.";
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferência realizada com sucesso.";
            }
        }
    }
}
