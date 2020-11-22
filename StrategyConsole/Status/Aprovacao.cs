using System;

namespace StrategyConsole.Status
{
    public class Aprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor = orcamento.Valor * (1 - 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em aprovado, não pode ser reprovado agora");
        }
    }
}
