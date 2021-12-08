using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticuloController : ControllerBase
    {

        [HttpGet]
        public List<Articulo> Get()
        {
            var articulos = ArticuloRepository.GetAllArticulos();

            return articulos;
        }

        [HttpGet]
        [Route("{id}")]
        public Articulo? GetArticulo(int id)
        {
            var articulo = ArticuloRepository.GetArticulo(id);

            return articulo;
        }

        [HttpGet]
        [Route("TotalPages/{pageSize}")]
        public int GetTotalPages(int pageSize)
        {
            int pages = ArticuloRepository.GetTotalPages(pageSize);

            return pages;
        }


    }
}
