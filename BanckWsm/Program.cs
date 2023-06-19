using WagnerBankADM.Colaboradores;
using WagnerBankADM.Parceria;
using WagnerBankADM.SistemaInterno;
using WagnerBankADM.Utilitario;

#region
//ColaboradorFuncionario wagner = new ColaboradorFuncionario("112121-12", 2000);
//wagner.nome = "wagner silva moreira";
//Console.WriteLine(wagner.nome);
//Console.WriteLine(wagner.GetBonificacao());
//ColaboradorDiretor cleudy = new ColaboradorDiretor("21321232");
//cleudy.nome = "Cleudineia Torres Pereira";
//Console.WriteLine(cleudy.nome);
//Console.WriteLine(cleudy.GetBonificacao());

//GerenciadorDeBonificacao geranciador = new GerenciadorDeBonificacao();
//geranciador.Registrar(wagner);
//geranciador.Registrar(cleudy);
//Console.WriteLine("Total de bonificações " + geranciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários" + ColaboradorFuncionario.TotalFuncionarios);
//wagner.AumentarSalario();
//cleudy.AumentarSalario();
//Console.WriteLine( "Novo salário" + wagner.salario);
//Console.WriteLine("novo salario "+ cleudy.salario);
#endregion
//CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    ColaboradorDesigner wagner = new ColaboradorDesigner("04787565346");
    wagner.nome = "wagner silva moreira ";
    ColaboradorDiretor cleudy = new ColaboradorDiretor("213453212");
    cleudy.nome = "cleudy torres";
    ColaboradorAuxiliar paulo = new ColaboradorAuxiliar("312354321");
    paulo.nome = "Paulo Vitor";
    ColaboradorGerenteDeContas joao = new ColaboradorGerenteDeContas("132312323");
    joao.nome = "João silva Moreira";
    gerenciador.Registrar(joao);
    gerenciador.Registrar(paulo);
    gerenciador.Registrar(cleudy);
    gerenciador.Registrar(wagner);
    Console.WriteLine("total de bonificação" + gerenciador.TotalDeBonificacao);
}
UsarSistema();
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    ColaboradorDiretor claudio = new ColaboradorDiretor("04787565344");
    claudio.nome = "Claudio silva";
    claudio.senha = "121";
    ColaboradorGerenteDeContas joana = new("04787565751");
    joana.nome = "Joana silva";
    joana.senha = "2122";
    ParciriaComercial kaio = new ParciriaComercial();
    kaio.senha = "999";
    sistema.Logar(kaio, "999");
    sistema.Logar(claudio, "121");
    sistema.Logar(joana, "321");

}