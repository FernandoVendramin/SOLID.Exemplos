using SOLID.Exemplos.DIP.Solucao.Interface;
using System;

namespace SOLID.Exemplos.DIP.Solucao
{
    public class EmailServices : IEmailServices
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            Console.WriteLine($"Email enviado de {de} para {para}");
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Mensagem: {mensagem}");
        }
    }
}
