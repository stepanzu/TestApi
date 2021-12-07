using TestApi.Models;

namespace TestApi.Repositories
{
    public class ClienteRepository
    {
        private static TestDbContext _context = new TestDbContext();

        public static List<Cliente> GetAllClientes()
        {
            List<Cliente> lc = _context.Clientes.ToList();

            //foreach (contacte contacte in lc)
            //{
            //    contacte.SerializeVirtualProperties = false;

            //}
            return lc;
        }

        public static Cliente? GetCliente(int clienteId)
        {
            Cliente? cliente = _context.Clientes.Where(x => x.Id == clienteId).FirstOrDefault();
            return cliente;
        }

    }
}
