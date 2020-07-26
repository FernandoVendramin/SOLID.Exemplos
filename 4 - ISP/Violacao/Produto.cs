using SOLID.Exemplos.ISP.Violacao.Interface;
using System;

namespace SOLID.Exemplos.ISP.Violacao
{
    public class Produto : ICadastroBase
    {
        public void EnviarEmail()
        {
            // Produto não tem email, retorna um exception
            throw new NotImplementedException("Produto não tem email!");
        }

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
