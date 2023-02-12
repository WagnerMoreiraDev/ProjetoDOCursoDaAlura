using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string numeroConta;
        public double saldo = 100;

        public Cliente titular;
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

    }
}
