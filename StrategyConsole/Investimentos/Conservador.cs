
namespace StrategyConsole.Investimentos
{
    public class Conservador : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08;
        }
    }

}
