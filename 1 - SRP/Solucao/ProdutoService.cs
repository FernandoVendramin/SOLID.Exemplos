namespace SOLID.Exemplos.SRP.Solucao
{
    public class ProdutoService
    {
        public string Insert(Produto produto)
        {
            if (produto.Validar())
                return "Produto inválido";

            var repo = new ProdutoRepository();
            repo.Insert(produto);

            return "Sucesso";
        }
    }
}
