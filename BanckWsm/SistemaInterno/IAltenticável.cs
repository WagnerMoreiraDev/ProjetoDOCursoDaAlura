using WagnerBankADM.Colaboradores;

namespace WagnerBankADM.SistemaInterno
{
    public interface IAltenticável
    {
        public string senha { get; set; }

        public bool Autenticar(string senha);
    }
}
