using WagnerBankADM.SistemaInterno;

namespace WagnerBankADM.Colaboradores
{
    public class ColaboradorGerenteDeContas : ColaboradorFuncionarioAutenticavel
    {

        public ColaboradorGerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }
        public override double GetBonificacao()
        {
            return salario * 0.25;
        }
        public override void AumentarSalario()
        {
            salario *= 1.05;
        }
    }
}
