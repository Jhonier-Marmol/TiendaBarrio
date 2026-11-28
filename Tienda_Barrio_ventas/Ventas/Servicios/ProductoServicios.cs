
using Datos;
using Modelos;
using System.Linq;

namespace Servicios
{
    public class ProductoServicio
    {


        public List<Producto> BuscarProductos(string nombre)
        {
            using (var db = new TiendaContext())
            {
                return db.Productos
                    .Where(p => p.Nombre.Contains(nombre))
                    .ToList();
            }
        }


        public void RegistrarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (producto.Precio <= 0)
                throw new Exception("El precio debe ser mayor que cero.");

            if (producto.Stock < 0)
                throw new Exception("El stock no puede ser negativo.");

            if (string.IsNullOrWhiteSpace(producto.Categoria))
                throw new Exception("La categoría es obligatoria.");

            using (var db = new TiendaContext())
            {
                db.Productos.Add(producto);
                db.SaveChanges();
            }
        }


        public List<Producto> ListarProductos()
        {
            using (var db = new TiendaContext())
            {
                return db.Productos.ToList();
            }
        }


        public bool EditarProducto(Producto producto)
        {
            using (var db = new TiendaContext())
            {
                var productoExistente = db.Productos.Find(producto.Id);

                if (productoExistente == null)
                {
                    return false;
                }

                productoExistente.Nombre = producto.Nombre;
                productoExistente.Precio = producto.Precio;
                productoExistente.Stock = producto.Stock;
                productoExistente.Categoria = producto.Categoria;

                db.SaveChanges();

                return true;
            }
        }

        public bool EliminarProducto(int id)
        {
            using (var db = new TiendaContext())
            {
                var producto = db.Productos.Find(id);

                if (producto == null)
                {
                    return false;
                }

                db.Productos.Remove(producto);
                db.SaveChanges();

                return true;
            }
        }

    }
}
