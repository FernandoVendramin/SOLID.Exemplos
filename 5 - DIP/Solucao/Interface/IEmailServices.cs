namespace SOLID.Exemplos.DIP.Solucao.Interface
{
    public interface IEmailServices
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
