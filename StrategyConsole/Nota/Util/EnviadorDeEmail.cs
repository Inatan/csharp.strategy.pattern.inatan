using System;

namespace StrategyConsole.Nota.Util
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("simulando envio de email");
        }
    }
}
