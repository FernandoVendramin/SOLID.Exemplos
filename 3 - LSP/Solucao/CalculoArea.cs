using System;

namespace SOLID.Exemplos.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo paralelogramo)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralelogramo");
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Altura + " * " + paralelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(7, 7);
            var ret = new Retangulo(7, 4);

            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}
