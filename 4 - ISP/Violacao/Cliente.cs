using SOLID.Exemplos.ISP.Violacao.Interface;

namespace SOLID.Exemplos.ISP.Violacao
{
    public class Cliente : ICadastroBase
    {
        public void EnviarEmail()
        {
            // Envia email para o cliente
        }

        public void Insert()
        {
            // Insere no banco um novo registro para tabela Cliente
        }

        public bool ValidarDados()
        {
            // Valida os dados da classe cliente
            return true;
        }
    }
}
