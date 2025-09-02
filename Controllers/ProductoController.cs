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
        // GET /api/productos/{id}
        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
                return NotFound();
            return Ok(producto);
        }
        // POST /api/productos
        [HttpPost]
        public ActionResult<Producto> CrearProducto([FromBody] Producto nuevoProducto)
        {
            nuevoProducto.Id = productos.Max(p => p.Id) + 1;
            productos.Add(nuevoProducto);
            return CreatedAtAction(nameof(GetProducto), new { id = nuevoProducto.Id }, nuevoProducto);
        }

        // PUT /api/productos/{id}
        [HttpPut("{id}")]
        public IActionResult ActualizarProducto(int id, [FromBody] Producto productoActualizado)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
                return NotFound();

            producto.Nombre = productoActualizado.Nombre;
            producto.Precio = productoActualizado.Precio;
            producto.Disponible = productoActualizado.Disponible;

            return NoContent();
        }

         // DELETE /api/productos/{id}
        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
                return NotFound();

            productos.Remove(producto);
            return NoContent();
        }

    }
}

