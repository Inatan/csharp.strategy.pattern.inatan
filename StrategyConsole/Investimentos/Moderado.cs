
using System;

namespace StrategyConsole.Investimentos
{
    public class Moderado : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            Random rand = new Random();

            if (rand.Next(0, 2) == 0)
            {
                return orcamento.Valor * 0.025;
            }
            else
            {
                return orcamento.Valor * 0.07;
            }
        }

    }

}
