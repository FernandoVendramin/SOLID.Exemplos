using SOLID.Exemplos.DIP.Solucao;
using System;
using System.Runtime.InteropServices;

namespace SOLID.Exemplos
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Selecione o Exemplo:");
            Console.WriteLine("1 - SRP");
            Console.WriteLine("2 - OCP");
            Console.WriteLine("3 - LSP");
            Console.WriteLine("4 - ISP");
            Console.WriteLine("5 - DIP");

            Console.WriteLine("");

            var opcao = Console.ReadKey();

            Console.Clear();

            switch (opcao.KeyChar)
            {
                case '1':
                    // Executa algo
                    break;
                case '2':
                    OCP.Solucao.TransacaoDebito transacaoDebito = new OCP.Solucao.TransacaoDebito();
                    Console.WriteLine(transacaoDebito.Realizar(55, "1234.5678.9123.1235")); Console.WriteLine("");
                    OCP.Solucao.TransacaoCredito transacaoCredito = new OCP.Solucao.TransacaoCredito();
                    Console.WriteLine(transacaoCredito.Realizar(12, "5555.6666.7777.1212")); Console.WriteLine("");
                    break;
                case '3':
                    LSP.Violacao.CalculoArea.Calcular(); Console.WriteLine("");
                    break;
                case '4':
                    // Executa algo
                    break;
                case '5':
                    DIP.Solucao.Cliente cliente = new DIP.Solucao.Cliente() 
                    { 
                        Id = 1, 
                        Nome = "Usuario 1", 
                        Cpf = new DIP.Solucao.Cpf() { Numero = "12345678912" }, 
                        DataCadastro = DateTime.Now, 
                        Email = new DIP.Solucao.Email() { Endereco = "usuario1@teste.com" } 
                    };

                    DIP.Solucao.ClienteServices clienteServices = new DIP.Solucao.ClienteServices(
                        new DIP.Solucao.EmailServices(), 
                        new DIP.Solucao.ClienteRepository());

                    clienteServices.AdicionarCliente(cliente);
                    break;
                default:
                    break;
            }
        }
    }
}
