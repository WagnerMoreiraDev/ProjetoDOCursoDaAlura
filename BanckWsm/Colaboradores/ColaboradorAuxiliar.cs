namespace WagnerBankADM.Colaboradores
{
    public class ColaboradorAuxiliar : ColaboradorFuncionario
    {
        public ColaboradorAuxiliar(string cpf) : base(cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return salario * 0.2;
        }

        public override void AumentarSalario()
        {
            salario *= 1.1;
        }
    }
}

