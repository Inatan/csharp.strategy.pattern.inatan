using System;

namespace StrategyConsole.Nota.Util
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("banco");
        }
    }
}
