namespace StrategyConsole.Impostos
{
    public abstract class TemplateDeImpostosCondicional : Imposto
    {
        public TemplateDeImpostosCondicional(Imposto outroImposto) : base(outroImposto) { }

        public TemplateDeImpostosCondicional() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento) + CalculoOutroImposto(orcamento);

            return MinimaTaxacao(orcamento) + CalculoOutroImposto(orcamento); ;
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
