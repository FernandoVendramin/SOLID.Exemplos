using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exemplos.OCP.Violacao
{
    public class Paramento
    {
        public void Pagar(decimal valor, string conta, TipoTransacao tipoTransacao)
        {
            if (tipoTransacao == TipoTransacao.Debito)
            {
                // Realiza transação no cartão por Débito
            }

            if (tipoTransacao == TipoTransacao.Credito)
            {
                // Realiza transação no cartão por Crédito
            }
        }
    }
}
