﻿using System;

namespace SOLID.Exemplos.DIP.Violacao
{
    public static class EmailServices
    {
        public static void Enviar(string de, string para, string assunto, string mensagem)
        {
            Console.WriteLine($"Email enviado de {de} para {para}");
            Console.WriteLine($"Assunto: {assunto}");
            Console.WriteLine($"Mensagem: {mensagem}");
        }
    }
}
