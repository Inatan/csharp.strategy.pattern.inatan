using StrategyConsole.Nota;
using System;
using System.Collections.Generic;

namespace StrategyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 1 - strategy
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

            //ex 2 - Chain of Responsability
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500);
            //orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 250));
            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);

            // ex 5 STATE

            //Orcamento reforma = new Orcamento(500);
            //Console.WriteLine(reforma.Valor);

            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);
            //reforma.Aprova();
            //reforma.AplicaDescontoExtra();
            //Console.WriteLine(reforma.Valor);
            //reforma.Finaliza();


            // ex 6 - Builder
            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder
                .ParaEmpresa("Caelum Ensino")
                .ComCnpj("223.456/789/0001-12")
                .ComItem(new ItemDaNota("item 1", 100.0))
                .ComItem(new ItemDaNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("uma obs qualquer");

            NotaFiscal nf = builder.Constroi();
           
            Console.ReadKey();
        }
    }
}
