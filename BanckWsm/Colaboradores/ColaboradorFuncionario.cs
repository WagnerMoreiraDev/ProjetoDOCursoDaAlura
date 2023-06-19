namespace WagnerBankADM.Colaboradores
{
    public abstract class ColaboradorFuncionario
    {
        public string nome { get; set; }
        public string cpf { get; private set; }
        public double salario { get; protected set; }

        public static int TotalFuncionarios { get; private set; }
        public abstract double GetBonificacao();
        public ColaboradorFuncionario(string cpf, double salario)
        {
            this.salario = salario;
            this.cpf = cpf;
            TotalFuncionarios++;
            //Console.WriteLine(  "colaborador funcionário");
        }
        public abstract void AumentarSalario();
    }
}
