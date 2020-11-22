using System.Linq;

namespace StrategyConsole.Impostos
{
    public class IKCV : TemplateDeImpostosCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        public IKCV() : base() { };


        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.Itens.Any(i => i.Valor >= 500);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;

        }
    }
}
