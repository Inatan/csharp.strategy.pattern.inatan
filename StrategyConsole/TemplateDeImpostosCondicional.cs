namespace StrategyConsole
{
    public abstract class TemplateDeImpostosCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        public abstract double MinimaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
