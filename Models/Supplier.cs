using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProductApi.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        // One Supplier can have many Products
        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
