using WagnerBankADM.SistemaInterno;

namespace WagnerBankADM.Parceria
{
    public class ParciriaComercial : IAltenticável
    {
        public string senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
