using System;

namespace StrategyConsole
{
    public static class CalculadorImposto
    {
        public static void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
