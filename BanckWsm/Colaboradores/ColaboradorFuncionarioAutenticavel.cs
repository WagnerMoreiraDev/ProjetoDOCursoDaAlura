using WagnerBankADM.SistemaInterno;

namespace WagnerBankADM.Colaboradores
{
    public abstract class ColaboradorFuncionarioAutenticavel : ColaboradorFuncionario, IAltenticável
    {
        protected ColaboradorFuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
