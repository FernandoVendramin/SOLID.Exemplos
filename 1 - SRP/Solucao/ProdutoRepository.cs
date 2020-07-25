using System.Data;
using System.Data.SqlClient;

namespace SOLID.Exemplos.SRP.Solucao
{
    public class ProdutoRepository
    {
        public void Insert(Produto produto)
        {
            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Insert into 
                        Produto 
                            (Nome, Descricao, TipoProdutoId, Validade, QuantidadeEstoque) 
                        values 
                            (@nome, @descricao, @tipoProdutoId, @validade, @quantidade))";

                cmd.Parameters.AddWithValue("nome", produto.Nome);
                cmd.Parameters.AddWithValue("descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("tipoProdutoId", produto.TipoProdutoId);
                cmd.Parameters.AddWithValue("validade", produto.Validade);
                cmd.Parameters.AddWithValue("quantidade", produto.QuantidadeEstoque);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Produto produto)
        {
            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Update Produto 
                            Set Nome = @nome, Descricao = @descricao, TipoProdutoId = @tipoProdutoId, Validade = @validade, QuantidadeEstoque = @quantidade
                            Where Id = @id";

                cmd.Parameters.AddWithValue("id", produto.Id);
                cmd.Parameters.AddWithValue("nome", produto.Nome);
                cmd.Parameters.AddWithValue("descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("tipoProdutoId", produto.TipoProdutoId);
                cmd.Parameters.AddWithValue("validade", produto.Validade);
                cmd.Parameters.AddWithValue("quantidade", produto.QuantidadeEstoque);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                conn.ConnectionString = "myConnection";
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"Delete From Produto Where Id = @id";

                cmd.Parameters.AddWithValue("id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
