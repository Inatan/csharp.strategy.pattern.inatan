namespace StrategyConsole.Nota
{
    public class ItemDaNota
    {

        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}