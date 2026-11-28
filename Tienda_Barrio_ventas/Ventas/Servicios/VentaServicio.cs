
using Datos;
using Modelos;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Servicios
{
    public class VentaServicio
    {
        public bool RegistrarVenta(int productoId, int cantidad)
        {
            if (cantidad <= 0)
                return false;


            using (var db = new TiendaContext())
            {
                using (var transaccion = db.Database.BeginTransaction())
                {
                    var producto = db.Productos.Find(productoId);

                    if (producto == null || producto.Stock < cantidad)
                        return false;

                    decimal total = producto.Precio * cantidad;

                    Venta venta = new Venta()
                    {
                        ProductoId = producto.Id,
                        NombreProducto = producto.Nombre,
                        Cantidad = cantidad,
                        PrecioUnitario = producto.Precio,
                        Total = total,
                        Fecha = DateTime.Now
                    };

                    producto.Stock -= cantidad;

                    db.Ventas.Add(venta);
                    db.SaveChanges();

                    transaccion.Commit();

                    return true;
                }
            }
        }


        public List<Venta> ListarVentas()
        {
            using (var db = new TiendaContext())
            {
                return db.Ventas
                    .OrderByDescending(v => v.Fecha)
                    .ToList();
            }
        }
    }
}
