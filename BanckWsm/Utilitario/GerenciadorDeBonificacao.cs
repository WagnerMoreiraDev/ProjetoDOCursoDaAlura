using WagnerBankADM.Colaboradores;

namespace WagnerBankADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }
        public void Registrar(ColaboradorFuncionario colaboradorFuncionario)
        {
            TotalDeBonificacao += colaboradorFuncionario.GetBonificacao();
        }

    }
}
