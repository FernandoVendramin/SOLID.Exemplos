using SOLID.Exemplos.DIP.Solucao.Interface;
using System;

namespace SOLID.Exemplos.DIP.Solucao
{
    public class ClienteRepository : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            Console.WriteLine("Cliente inserido no banco com sucesso.");
        }
    }
}
