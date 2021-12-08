using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {

        [HttpGet]
        public List<Pedido> Get()
        {
            var pedidos = PedidoRepository.GetAllPedidos();

            return pedidos;
        }

        [HttpGet]
        [Route("{page}/{pageSize}")]
        public List<Pedido> Get(int page, int pageSize)
        {
            var pedidos = PedidoRepository.GetAllPedidos(page, pageSize);

            return pedidos;
        }

        [HttpGet]
        [Route("{page}/{pageSize}/{clienteId}")]
        public List<Pedido> Get(int page, int pageSize, int clienteId)
        {
            var pedidos = PedidoRepository.GetAllPedidos(page, pageSize, clienteId);

            return pedidos;
        }

        [HttpGet]
        [Route("{id}")]
        public Pedido? GetPedido(int id)
        {
            var pedido = PedidoRepository.GetPedido(id);

            return pedido;
        }

        [HttpGet]
        [Route("TotalPages/{pageSize}")]
        public int GetTotalPages(int pageSize)
        {
            int pages = PedidoRepository.GetTotalPages(pageSize);

            return pages;
        }

        [HttpGet]
        [Route("TotalPages/{pageSize}/{id}")]
        public int GetTotalPages(int pageSize, int id)
        {
            int pages = PedidoRepository.GetTotalPages(pageSize, id);

            return pages;
        }


    }
}
