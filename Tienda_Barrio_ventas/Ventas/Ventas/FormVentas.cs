using Modelos;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ventas
{
    public partial class FormVentas : Form
    {
        private VentaServicio ventaServicio = new VentaServicio();

        private ProductoServicio productoServicio = new ProductoServicio();

        private void CargarProductos()
        {
            cmbProductos.DataSource = null;

            cmbProductos.DataSource = productoServicio.ListarProductos();

            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id";
        }
        public FormVentas()
        {
            InitializeComponent();
            CargarProductos();
            CargarVentas();

        }
        private void CalcularTotal()
        {
            if (cmbProductos.SelectedItem is Producto producto)
            {
                decimal total = producto.Precio * nudCantidad.Value;

                txtTotal.Text = total.ToString("N2");
            }
        }
        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem is Producto producto)
            {
                txtPrecio.Text = producto.Precio.ToString("N2");
                CalcularTotal();
            }
        }

        private void CargarVentas()
        {
            dgvVentas.DataSource = null;

            dgvVentas.DataSource = ventaServicio.ListarVentas();
        }


        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {

            if (cmbProductos.SelectedItem is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }


            int cantidad = (int)nudCantidad.Value;

            try
            {

                bool resultado = ventaServicio.RegistrarVenta(
                    producto.Id,
                    cantidad
                );

                if (resultado)
                {
                    MessageBox.Show("Venta registrada correctamente.");


                    CargarProductos();
                    CargarVentas();

                    nudCantidad.Value = 1;


                    txtPrecio.Clear();
                    txtTotal.Clear();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar la venta. " +
                        "Verifica que haya suficiente inventario."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }

        private void btnVolverProducto_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Show();
        }
    }
}
