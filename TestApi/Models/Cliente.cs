using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestApi.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        [JsonIgnore]
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
