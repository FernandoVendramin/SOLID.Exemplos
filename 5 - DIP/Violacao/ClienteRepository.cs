using System.Data.SqlClient;

namespace SOLID.Exemplos.DIP.Violacao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "myConnection";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Insert into Cliente (Nome, Email, Cpf, DataCadastro) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("dataCad", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
