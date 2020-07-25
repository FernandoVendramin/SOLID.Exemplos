using System;

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

            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    //CaixaEletronico.Operacoes();
                    break;
                case '2':
                    //CalculoArea.Calcular();
                    break;
            }
        }
    }
}
