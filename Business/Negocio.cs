using DAL;
using Entities;

namespace Business
{
    public class Negocio
    {
        public void GravarCliente(Clientes model)
        {
            string instrucaoSQL = "INSERT INTO Cliente VALUES (@Nome, @Idade)";
            Dados dal = new Dados();
            dal.GravarCliente(instrucaoSQL, model);
        }
    }
}
