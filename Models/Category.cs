using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProductApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // One Category can have many Products
        // [JsonIgnore] prevents circular reference errors when testing in Swagger
        [JsonIgnore]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
