using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos
{
    public class Venta
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }

        public string? NombreProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal Total { get; set; }

        public DateTime Fecha { get; set; }
    }
}
