using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestApi.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            LineaPedidos = new HashSet<LineaPedido>();
        }

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }

        public virtual Cliente Cliente { get; set; } = null!;

        [JsonIgnore]
        public virtual ICollection<LineaPedido> LineaPedidos { get; set; }
    }
}
