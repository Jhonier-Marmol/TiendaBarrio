namespace Ventas
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblProducto = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblTotal = new Label();
            cmbProductos = new ComboBox();
            nudCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            txtTotal = new TextBox();
            btnVender = new Button();
            btnCalcular = new Button();
            dgvVentas = new DataGridView();
            btnVolverProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(301, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro de Ventas";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(23, 65);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(23, 133);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(23, 193);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(23, 253);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(125, 65);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(121, 23);
            cmbProductos.TabIndex = 5;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(114, 185);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 6;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(125, 125);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 7;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(114, 253);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(348, 253);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(116, 36);
            btnVender.TabIndex = 9;
            btnVender.Text = "Registrar Ventas";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(518, 253);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 36);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(377, 58);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(391, 150);
            dgvVentas.TabIndex = 11;
            // 
            // btnVolverProducto
            // 
            btnVolverProducto.Location = new Point(348, 338);
            btnVolverProducto.Name = "btnVolverProducto";
            btnVolverProducto.Size = new Size(147, 30);
            btnVolverProducto.TabIndex = 12;
            btnVolverProducto.Text = "Volver Producto";
            btnVolverProducto.UseVisualStyleBackColor = true;
            btnVolverProducto.Click += btnVolverProducto_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverProducto);
            Controls.Add(dgvVentas);
            Controls.Add(btnCalcular);
            Controls.Add(btnVender);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecio);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProductos);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            Controls.Add(lblTitulo);
            Name = "FormVentas";
            Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblProducto;
        private Label lblPrecio;
        private Label lblCantidad;
        private Label lblTotal;
        private ComboBox cmbProductos;
        private NumericUpDown nudCantidad;
        private TextBox txtPrecio;
        private TextBox txtTotal;
        private Button btnVender;
        private Button btnCalcular;
        private DataGridView dgvVentas;
        private Button btnVolverProducto;
    }
}