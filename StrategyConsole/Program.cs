using StrategyConsole.Investimentos;
using System;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imposto iss = new ISS();
            //Imposto icms = new ICMS();
            //Imposto iccc = new ICCC();

            //Investimento conversador = new Conservador();
            //Investimento moderado = new Moderado();
            //Investimento arrojado = new Arrojado();

            //Orcamento orcamento = new Orcamento(500.0);

            //// Calculando o ISS
            //CalculadorImposto.RealizaCalculo(orcamento, iss);

            //// Calculando o ICMS        
            //CalculadorImposto.RealizaCalculo(orcamento, icms);

            //// Calculando o ISSS
            //CalculadorImposto.RealizaCalculo(orcamento, iccc);

            //// Calculando o ISS
            //CalculadorInvestimento.RealizaCalculo(orcamento, conversador);

            //// Calculando o ICMS        
            //CalculadorInvestimento.RealizaCalculo(orcamento, moderado);

            //// Calculando o ISSS
            //CalculadorInvestimento.RealizaCalculo(orcamento, arrojado);

            //ex 2
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 250));
            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
