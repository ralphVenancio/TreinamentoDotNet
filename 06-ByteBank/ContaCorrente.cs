using System;
namespace ByteBank
{
    public class ContaCorrente
    {
        
        // Como existe uma lógica para a atribuição do saldo é criada uma veriável privada _saldo e seu método de encapsulamento.
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }

            set { if(value >= 0) { this._saldo = value; } }
        }

        // Como os demais atributos não possuem nenhuma lógica mais complexa não é necessária a criação de uma variável privada.
        // Para acessar os atributos contruidos dessa forma basta colocar o noma do método de encapsulamento, como nos comentários a seguir.
        public Cliente Titular { get; set; }    // <objeto>.Titular
        public int Agencia { get; set; }        // <objeto>.Agencia
        public int Numero { get; set; }         // <objeto>.Numero

        /*
            É uma boa prática sempre criar os atributos privados e seus respectivos métodos de encapsulamento.
            Caso seja necessária a implementação de uma lógica em qualquer atributo, será necessário modificar somente na classe de origem.
         */

        public ContaCorrente()
        {
        }

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
