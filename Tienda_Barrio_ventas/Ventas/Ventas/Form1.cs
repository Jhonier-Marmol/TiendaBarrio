
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Servicios;
using Modelos;

namespace Ventas
{
    public partial class Form1 : Form
    {
        private ProductoServicio servicio = new ProductoServicio();

        public Form1()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = servicio.ListarProductos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }


            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresa un precio válido.");
                return;
            }


            Producto producto = new Producto()
            {
                Nombre = txtNombre.Text.Trim(),
                Precio = precio,
                Stock = (int)nudStock.Value,
                Categoria = txtCategoria.Text.Trim()
            };

            servicio.RegistrarProducto(producto);


            CargarProductos();

            MessageBox.Show("Producto registrado correctamente.");


            txtNombre.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
            nudStock.Value = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value?.ToString();
                nudStock.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                txtCategoria.Text = fila.Cells["Categoria"].Value?.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)


        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresa un precio válido.");
                return;
            }

            int id = Convert.ToInt32(
                dgvProductos.CurrentRow.Cells["Id"].Value);

            Producto producto = new Producto()
            {
                Id = id,
                Nombre = txtNombre.Text.Trim(),
                Precio = precio,
                Stock = (int)nudStock.Value,
                Categoria = txtCategoria.Text.Trim()
            };

            bool resultado = servicio.EditarProducto(producto);

            if (resultado)
            {
                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
            }
            else
            {
                MessageBox.Show("No se encontró el producto.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (dgvProductos.CurrentRow == null)
                {
                    MessageBox.Show("Selecciona un producto.");
                    return;
                }

                int id = Convert.ToInt32(
                    dgvProductos.CurrentRow.Cells["Id"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado = servicio.EliminarProducto(id);

                    if (eliminado)
                    {
                        MessageBox.Show("Producto eliminado correctamente.");
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto.");
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCategoria.Clear();
            nudStock.Value = 0;

            dgvProductos.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Escribe el nombre del producto.");
                return;
            }

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = servicio.BuscarProductos(nombre);

            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarProductos();
        }

        private void btnAbrirVentas_Click(object sender, EventArgs e)
        {
            FormVentas formulario = new FormVentas();
            formulario.Show();
        }
    }
}