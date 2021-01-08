using Business;
using Entities;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio business = new Negocio();
            Clientes cliente = new Clientes();

            cliente.Nome = "Teste";
            cliente.Idade = 20;
            business.GravarCliente(cliente);
        }
    }
}
