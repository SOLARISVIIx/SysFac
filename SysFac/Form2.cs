using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SysFac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


            this.MinimumSize = new Size(1528, 834);
            this.MaximumSize = new Size(1528, 834);

            dataGridView1.AllowUserToAddRows = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string producto = comboBox2.Text;
            int cantidad = Convert.ToInt32(textBox2.Text);
            decimal precioUnitario = Convert.ToDecimal(textBox7.Text);

            decimal subtotal = cantidad * precioUnitario;

            // Agregar fila con las columnas ya definidas
            dataGridView1.Rows.Add(producto, cantidad, precioUnitario, subtotal, Stock, "Eliminar");

            CalcularTotales();
        }

        private void CalcularTotales()
        {
            decimal subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                subtotal += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            decimal descuento = string.IsNullOrEmpty(textBox5.Text) ? 0 : Convert.ToDecimal(textBox5.Text);
            decimal abono = string.IsNullOrEmpty(textBox6.Text) ? 0 : Convert.ToDecimal(textBox6.Text);
            decimal iva = subtotal * 0.15m; // ejemplo IVA 15%
            decimal total = subtotal + iva - descuento - abono;

            textBox4.Text = subtotal.ToString("N2");
            textBox9.Text = iva.ToString("N2");
            textBox8.Text = total.ToString("N2");
            textBox10.Text = total.ToString("N2");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos si la columna clickeada es la de botón "Eliminar"
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                // Eliminamos la fila seleccionada
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                // Recalculamos los totales
                CalcularTotales();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Factura generada correctamente.\n\n" +
                            "Cliente: " + comboBox1.Text + "\n" +
                            "Método de pago: " + comboBox3.SelectedItem?.ToString() + "\n" +
                            "Total a pagar: " + textBox10.Text,
                            "Factura SysFac");
        }
    }
}
