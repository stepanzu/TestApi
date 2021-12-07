using System;
using System.Collections.Generic;

namespace TestApi.Models
{
    public partial class LineaPedido
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ArticuloId { get; set; }
        public decimal Importe { get; set; }

        public virtual Articulo Articulo { get; set; } = null!;
        public virtual Pedido Pedido { get; set; } = null!;
    }
}
