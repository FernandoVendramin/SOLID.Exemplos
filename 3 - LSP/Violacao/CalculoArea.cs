using System;

namespace SOLID.Exemplos.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado()
            {
                Altura = 7,
                Largura = 4
            };

            ObterAreaRetangulo(quad);
        }
    }
}
