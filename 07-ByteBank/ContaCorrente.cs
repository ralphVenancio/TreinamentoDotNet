using System;
namespace ByteBank
{
    public class ContaCorrente
    {
        // O atributo pode ser acessado fora da classe, mas não pode ser atualizado fora dela.
        public static int TotalDeContasCriadas { get; private set; }    // O get é publico mas o set é privado.

        // Declaração e encapsulamento do atributo saldo.
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }

            set { if(value >= 0) { this._saldo = value; } }
        }

        // Declareção e encapsulamento do atributo titular.
        public Cliente Titular { get; set; }

        // Declaracla e encapsulamento do atributo agencia.
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }

        // Declaração e encapsulamento do atributo número.
        public int Numero { get; set; }

        
        // Construtor da classe ContaCorrente.
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            /*
             * Para acessar atributos estáticos de uma classe fora da mesma, é necessário passar o nome da classe anteriormente. (ContaCorrente.TotalDeContasCriadas)
             * Para acessar atributos estáticos de uma classe dentro da mesma, basta acessar diretamente pelo nome do atributo. Como no código abaixo.
            */
            TotalDeContasCriadas++;
        }

        // Método sacar
        public string Sacar(double valor)
        {
            if(this._saldo < valor)
            {
                string operationResult = "A operação não pode ser concluída.\n Saldo insuficiente:";
                return operationResult;
            }
            else
            {
                this._saldo -= valor;
                string operationResult = "Operação realizada com sucesso.\n Saldo atual: " + this._saldo;
                return operationResult;
            }
        }

        public string Depositar(double valor)
        {

            this._saldo += valor;
            string operationResult = "Operação realizada com sucesso.\n Saldo atual: " + this._saldo;
            return "Saldo atual: " + this._saldo;
        }

        public void Extrato()
        {
            Console.WriteLine("Salso atual da conta: " + this._saldo);
        }

        public string Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
            {
                return "A transferência não pode ser realizada.\nSaldo insuficiente.";
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return "Transferência realizada com sucesso.";
            }
        }
    }
}
