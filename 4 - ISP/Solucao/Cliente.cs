using SOLID.Exemplos.ISP.Solucao.Interface;

namespace SOLID.Exemplos.ISP.Solucao
{
    public class Cliente : ICliente
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
