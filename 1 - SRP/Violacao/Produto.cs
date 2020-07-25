using System;
using System.Data;
using System.Data.SqlClient;

namespace SOLID.Exemplos.SRP.Violacao
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime Validade { get; set; }
        public int QuantidadeEstoque { get; set; }

        public string Insert()
        {
            if (string.IsNullOrEmpty(Nome))
                return $"Name é obrigatório.";

            if (string.IsNullOrEmpty(Descricao))
                return $"Description é obrigatório.";

            if (string.IsNullOrEmpty(Tipo))
                return $"Type é obrigatório.";

            if (Validade <= DateTime.Now)
                return $"Data de Validade inválida.";

            if (QuantidadeEstoque == 0)
                return $"Quantidade em Estoque Invalido.";

            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Insert into 
                        Produto 
                            (Nome, Descricao, Tipo, Validade, QuantidadeEstoque) 
                        values 
                            (@nome, @descricao, @tipo, @validade, @quantidade))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("descricao", Descricao);
                cmd.Parameters.AddWithValue("tipo", Tipo);
                cmd.Parameters.AddWithValue("validade", Validade);
                cmd.Parameters.AddWithValue("quantidade", QuantidadeEstoque);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            return "Sucesso";
        }

        public string Update()
        {
            if (string.IsNullOrEmpty(Nome))
                return $"Name é obrigatório.";

            if (string.IsNullOrEmpty(Descricao))
                return $"Description é obrigatório.";

            if (string.IsNullOrEmpty(Tipo))
                return $"Type é obrigatório.";

            if (Validade <= DateTime.Now)
                return $"Data de Validade inválida.";

            if (QuantidadeEstoque == 0)
                return $"Quantidade em Estoque Invalido.";

            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Update Produto 
                            Set Nome = @nome, Descricao = @descricao, Tipo = @tipo, Validade = @validade, QuantidadeEstoque = @quantidade
                            Where Id = @id";

                cmd.Parameters.AddWithValue("id", Id);
                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("descricao", Descricao);
                cmd.Parameters.AddWithValue("tipo", Tipo);
                cmd.Parameters.AddWithValue("validade", Validade);
                cmd.Parameters.AddWithValue("quantidade", QuantidadeEstoque);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            return "Success";
        }

        public void Delete()
        {
            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Delete From Produto Where Id = @id";

                cmd.Parameters.AddWithValue("id", Id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
