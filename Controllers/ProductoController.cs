using Microsoft.AspNetCore.Mvc;
using ApiProductos.Models;

namespace ApiProductos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop", Precio = 1200.50m, Disponible = true },
            new Producto { Id = 2, Nombre = "Mouse", Precio = 25.99m, Disponible = true },
            new Producto { Id = 3, Nombre = "Teclado", Precio = 45.75m, Disponible = false }
        };

        // GET /api/productos
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProductos()
        {
            return Ok(productos);
        }
    }
}

