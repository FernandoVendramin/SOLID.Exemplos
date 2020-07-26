namespace SOLID.Exemplos.ISP.Violacao.Interface
{
    public interface ICadastroBase
    {
        bool ValidarDados();
        void Insert();
        void EnviarEmail();
    }
}
