using System;

namespace SOLID.Exemplos.DIP.Solucao
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.Validar() && Cpf.Validar();
        }
    }
}
