namespace SOLID.Exemplos.OCP.Solucao
{
    public class TransacaoCredito : Transacao
    {
        public override string Realizar(decimal valor, string conta)
        {
            // Regras de negócio específicas do Crédito

            return $"Transação Crédito no valor R$ {valor}, na Conta {conta} realizada com Sucesso. Número da transação {FormatarTransacao()}";
        }
    }
}
