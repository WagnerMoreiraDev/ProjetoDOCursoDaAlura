namespace WagnerBankADM.Colaboradores
{
    public class ColaboradorDesigner : ColaboradorFuncionario
    {
        public ColaboradorDesigner(string cpf) : base(cpf, 3000)
        {

        }
        public override double GetBonificacao()
        {
            return salario * 0.17;
        }
        public override void AumentarSalario()
        {
            salario *= 1.11;
        }
    }
}


