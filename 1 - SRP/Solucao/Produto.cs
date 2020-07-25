using System;

namespace SOLID.Exemplos.SRP.Solucao
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int TipoProdutoId { get; set; }
        public virtual TipoProduto TipoProduto { get; set; }
        public DateTime Validade { get; set; }
        public int QuantidadeEstoque { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                return false;

            if (string.IsNullOrEmpty(Descricao))
                return false;

            if (Validade <= DateTime.Now)
                return false;

            if (QuantidadeEstoque == 0)
                return false;

            return TipoProduto.Validar();
        }
    }
}
