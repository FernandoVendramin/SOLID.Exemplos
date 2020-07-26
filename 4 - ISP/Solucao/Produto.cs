using SOLID.Exemplos.ISP.Solucao.Interface;

namespace SOLID.Exemplos.ISP.Solucao
{
    public class Produto : IProduto
    {
        public void Insert()
        {
            // Insere no banco um novo registro para tabela Produto
        }

        public bool ValidarDados()
        {
            // Valida os dados da classe Produto
            return true;
        }
    }
}
