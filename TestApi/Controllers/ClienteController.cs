using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {

        [HttpGet]
        public List<Cliente> Get()
        {
            var clientes = ClienteRepository.GetAllClientes();

            return clientes;
        }

        [HttpGet]
        [Route("{id}")]
        public Cliente? GetArticulo(int id)
        {
            var cliente = ClienteRepository.GetCliente(id);

            return cliente;
        }


    }
}
