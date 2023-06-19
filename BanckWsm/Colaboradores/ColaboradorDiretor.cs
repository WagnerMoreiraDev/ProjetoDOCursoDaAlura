using WagnerBankADM.SistemaInterno;

namespace WagnerBankADM.Colaboradores
{
    public class ColaboradorDiretor : ColaboradorFuncionarioAutenticavel
    {

        public override double GetBonificacao()
        {
            return salario * 0.5;
        }

        public ColaboradorDiretor(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine(  "Colaborador diretor");
        }
        public override void AumentarSalario()
        {
            salario *= 1.15;
        }
    }
}
