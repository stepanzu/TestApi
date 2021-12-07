using TestApi.Models;

namespace TestApi.Repositories
{
    public class ArticuloRepository
    {
        private static TestDbContext _context = new TestDbContext();

        public static List<Articulo> GetAllArticulos()
        {
            List<Articulo> lc = _context.Articulos.ToList();

            //foreach (contacte contacte in lc)
            //{
            //    contacte.SerializeVirtualProperties = false;

            //}
            return lc;
        }

        public static Articulo? GetArticulo(int articuloId)
        {
            Articulo? articulo = _context.Articulos.Where(x => x.Id == articuloId).FirstOrDefault();
            return articulo;
        }

    }
}
