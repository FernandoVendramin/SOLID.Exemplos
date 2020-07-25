namespace SOLID.Exemplos.SRP.Solucao
{
    public class TipoProduto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public bool Validar()
        {
            return !string.IsNullOrEmpty(Descricao);
        }
    }
}
