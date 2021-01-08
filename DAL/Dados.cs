using Entities;
using System.Data.SqlClient;

namespace DAL
{
    public class Dados
    {
        private string conexaoBanco = "Data Source=(local);Initial Catalog=Clientes;Integrated Security=True";
        private Clientes model = new Clientes();

        private SqlConnection AbrirConexao()
        {
            SqlConnection conexao = new SqlConnection(conexaoBanco);
            conexao.Open();
            return conexao;
        }

        private SqlCommand AdicionarInstrucao(string instrucaoSQL, SqlConnection conexao)
        {
            SqlCommand command = new SqlCommand(instrucaoSQL, conexao);            
            return command;
        }

        private SqlCommand AdicionarParametros(SqlCommand command, Clientes model, bool ehUpdateOuDelete)
        {
            if (ehUpdateOuDelete)
                command.Parameters.AddWithValue("@IdCliente", model.IdCliente);

            command.Parameters.AddWithValue("@Nome", model.Nome);
            command.Parameters.AddWithValue("@Idade", model.Idade);

            return command;
        }

        public void GravarCliente(string instrucaoSQL, Clientes model)
        {
            SqlConnection conexao = AbrirConexao();
            SqlCommand command = AdicionarInstrucao(instrucaoSQL, conexao);
            command = AdicionarParametros(command, model, false);
            command.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
