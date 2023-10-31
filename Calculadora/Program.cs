using Calculadora.Services;

HistoricoOperacoes historico = new HistoricoOperacoes();

OperacoesBasicas c1 = new OperacoesBasicas();

int resultadoSomar = c1.Somar(2, 5);
int resultadoSubtrair = c1.Subtrair(10, 5);
int resultadoMult = c1.Multiplicar(5, 5);
int resultadoDividir = c1.Dividir(10, 2);

Console.WriteLine(resultadoSomar);
Console.WriteLine(resultadoSubtrair);
Console.WriteLine(resultadoMult);
Console.WriteLine(resultadoDividir);

historico.ExibirHistorico();