using WagnerBankADM
    .Parceria;

namespace WagnerBankADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAltenticável funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("seja bem vindo ao nosso sistema");
                return true;
            }
            else
            {
                Console.WriteLine("senha errada");
                return false;
            }
        }
    }
}
