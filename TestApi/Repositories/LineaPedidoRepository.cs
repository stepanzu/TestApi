using TestApi.Models;

namespace TestApi.Repositories
{
    public class LineaPedidoRepository
    {
        private static TestDbContext _context = new TestDbContext();

        public static List<LineaPedido> GetAllLineasPedidos()
        {
            List<LineaPedido> lc = _context.LineaPedidos.ToList();

            return lc;
        }

        public static List<LineaPedido> GetAllLineasPedidos(int page, int pageSize)
        {

            List<LineaPedido> lc = _context.LineaPedidos.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return lc;
        }

        public static List<LineaPedido> GetAllLineasPedidos(int page, int pageSize, int pedidoId)
        {

            List<LineaPedido> lc = _context.LineaPedidos.Where(p => p.PedidoId == pedidoId).Skip((page - 1) * pageSize).Take(pageSize).ToList();

            return lc;
        }

        public static LineaPedido? GetLineaPedido(int lineaId)
        {
            LineaPedido? lineaPedido = _context.LineaPedidos.Where(x => x.Id == lineaId).FirstOrDefault();
            return lineaPedido;
        }

    }
}
