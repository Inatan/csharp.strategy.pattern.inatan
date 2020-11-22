namespace StrategyConsole
{
    public abstract class Imposto
    {
        protected Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto() => OutroImposto = null;

        public Imposto OutroImposto { get; set; }


        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoOutroImposto(Orcamento orcamento)
        {
            if (orcamento == null)
                return 0;
            return OutroImposto.Calcula(orcamento);
        }
    }
}
