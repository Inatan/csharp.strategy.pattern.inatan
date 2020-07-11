using StrategyConsole.Investimentos;
using System;

namespace StrategyConsole
{
    public static class CalculadorInvestimento
    {
        public static void RealizaCalculo(Orcamento orcamento, Investimento investimento)
        {
            double valor = investimento.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
