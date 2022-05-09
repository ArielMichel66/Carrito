using Carrito.Common;
using Carrito.Data.Entities;

namespace Carrito.Models
{
    public class HomeViewModel
    {
        public PaginatedList<Product> Products { get; set; }

        public ICollection<Category> Categories { get; set; }

        public float Quantity { get; set; }

    }
}
