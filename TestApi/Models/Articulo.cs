using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestApi.Models
{
    public partial class Articulo
    {
        public Articulo()
        {
            LineaPedidos = new HashSet<LineaPedido>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Importe { get; set; }

        [JsonIgnore]
        public virtual ICollection<LineaPedido> LineaPedidos { get; set; }
    }
}
