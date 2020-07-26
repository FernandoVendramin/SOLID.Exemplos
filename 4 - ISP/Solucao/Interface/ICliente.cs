namespace SOLID.Exemplos.ISP.Solucao.Interface
{
    public interface ICliente : ICadastroBase
    {
        // Implementações específicas de Cliente
        void EnviarEmail();
    }
}
