using TestApi.Models;

namespace TestApi.Repositories
{
    public class PedidoRepository
    {
        private static TestDbContext _context = new TestDbContext();

        public static List<Pedido> GetAllPedidos()
        {
            List<Pedido> lc = _context.Pedidos.ToList();

            return lc;
        }
        public static List<Pedido> GetAllPedidos(int page, int pageSize)
        {

            List<Pedido> lc = _context.Pedidos.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return lc;
        }

        public static List<Pedido> GetAllPedidos(int page, int pageSize, int clienteId)
        {

            List<Pedido> lc = _context.Pedidos.Where(p=>p.ClienteId == clienteId).Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return lc;
        }

        public static Pedido? GetPedido(int pedidoId)
        {
            Pedido? pedido = _context.Pedidos.Where(x => x.Id == pedidoId).FirstOrDefault();
            return pedido;
        }

        public static int GetTotalPages(int pageSize)
        {
            int totalItemCount = _context.Pedidos.Count();

            return System.Convert.ToInt32(System.Math.Ceiling(totalItemCount / System.Convert.ToDouble(pageSize))); ;
        }

        public static int GetTotalPages(int pageSize, int clienteId)
        {
            int totalItemCount = _context.Pedidos.Where(p => p.ClienteId == clienteId).Count();

            return System.Convert.ToInt32(System.Math.Ceiling(totalItemCount / System.Convert.ToDouble(pageSize))); ;
        }

    }
}
