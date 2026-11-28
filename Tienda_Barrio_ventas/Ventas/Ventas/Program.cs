using Datos;
using Microsoft.EntityFrameworkCore;


namespace Ventas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var db = new TiendaContext())
            {
                db.Database.EnsureCreated();

                db.Database.ExecuteSqlRaw(@"
        CREATE TABLE IF NOT EXISTS Ventas (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            ProductoId INTEGER NOT NULL,
            NombreProducto TEXT,
            Cantidad INTEGER NOT NULL,
            PrecioUnitario TEXT NOT NULL,
            Total TEXT NOT NULL,
            Fecha TEXT NOT NULL
        );
    ");
            }

            Application.Run(new Form1());


        }
    }
}