using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LineaPedidoController : ControllerBase
    {

        [HttpGet]
        public List<LineaPedido> Get()
        {
            var lineasPedidos = LineaPedidoRepository.GetAllLineasPedidos();

            return lineasPedidos;
        }

        [HttpGet]
        [Route("{page}/{pageSize}")]
        public List<LineaPedido> Get(int page, int pageSize)
        {
            var lineasPedidos = LineaPedidoRepository.GetAllLineasPedidos(page, pageSize);

            return lineasPedidos;
        }

        [HttpGet]
        [Route("{page}/{pageSize}/{pedidoId}")]
        public List<LineaPedido> Get(int page, int pageSize, int pedidoId)
        {
            var lineasPedidos = LineaPedidoRepository.GetAllLineasPedidos(page, pageSize, pedidoId);

            return lineasPedidos;
        }

        [HttpGet]
        [Route("{id}")]
        public LineaPedido? GetPedido(int id)
        {
            var pedido = LineaPedidoRepository.GetLineaPedido(id);

            return pedido;
        }

        [HttpGet]
        [Route("TotalPages/{pageSize}")]
        public int GetTotalPages(int pageSize)
        {
            int pages = LineaPedidoRepository.GetTotalPages(pageSize);

            return pages;
        }

        [HttpGet]
        [Route("TotalPages/{pageSize}/{id}")]
        public int GetTotalPages(int pageSize, int id)
        {
            int pages = LineaPedidoRepository.GetTotalPages(pageSize, id);

            return pages;
        }


    }
}
