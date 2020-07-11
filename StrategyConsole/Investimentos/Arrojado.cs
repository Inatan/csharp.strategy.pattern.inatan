
using System;

namespace StrategyConsole.Investimentos
{
    public class Arrojado : Investimento
    {
        public double Calcula(Orcamento orcamento)
        {
            int percentual = new Random().Next(101);

            if (percentual <= 20)
            {
                return orcamento.Valor * 0.05;

            }
            else if (percentual <= 50)
            {
                return orcamento.Valor * 0.03;
            }
            else
            {
                return orcamento.Valor * 0.006;
            }

        }

    }

}
