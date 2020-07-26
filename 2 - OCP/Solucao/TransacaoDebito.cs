namespace SOLID.Exemplos.OCP.Solucao
{
    public class TransacaoDebito : Transacao
    {
        public override string Realizar(decimal valor, string conta)
        {
            // Regras de negócio específicas do Débito

            return $"Transação Débito no valor R$ {valor}, na Conta {conta} realizada com Sucesso. Número da transação {FormatarTransacao()}";
        }
    }
}
