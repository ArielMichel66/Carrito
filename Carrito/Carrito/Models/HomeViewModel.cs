using Carrito.Data.Entities;

namespace Carrito.Models
{
    public class HomeViewModel
    {
        public ICollection<Product> Products { get; set; }

        public float Quantity { get; set; }

    }
}
