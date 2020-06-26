using System;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Orcamento orcamento = new Orcamento(500.0);

            // Calculando o ISS
            CalculadorImposto.RealizaCalculo(orcamento, iss);

            // Calculando o ICMS        
            CalculadorImposto.RealizaCalculo(orcamento, icms);

            Console.ReadKey();
        }
    }
}
