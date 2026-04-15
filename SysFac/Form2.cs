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
            string producto = comboBox2.Text;//donde se selecciona el producto
            int cantidad = Convert.ToInt32(textBox2.Text);//donde se ingresa la cantidad
            decimal precioUnitario = Convert.ToDecimal(textBox7.Text);//donde se reflejara el precio unitario del producto seleccionado

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

            decimal descuento = string.IsNullOrEmpty(textBox5.Text) ? 0 : Convert.ToDecimal(textBox5.Text);//este es el textbox del descuento
            decimal abono = string.IsNullOrEmpty(textBox6.Text) ? 0 : Convert.ToDecimal(textBox6.Text);//este es el textbox del abono
            decimal iva = subtotal * 0.15m; // ejemplo IVA 15%
            decimal total = subtotal + iva - descuento - abono;

            textBox4.Text = subtotal.ToString("N2");//este es el textbox del subtotal
            textBox9.Text = iva.ToString("N2");//este es el textbox del IVA
            textBox8.Text = total.ToString("N2");//este es el textbox del total antes de aplicar el descuento y el abono
            textBox10.Text = total.ToString("N2");//este es el textbox del total a pagar después de aplicar el descuento y el abono
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

        private void button3_Click(object sender, EventArgs e)//este es el boton de generar factura
        {
            MessageBox.Show("Factura generada correctamente.\n\n" +
                            "Cliente: " + comboBox1.Text + "\n" +//combobox donde se selecciona el cliente
                            "Método de pago: " + comboBox3.SelectedItem?.ToString() + "\n" +//combobox donde se selecciona el método de pago
                            "Total a pagar: " + textBox10.Text,//textbox donde se muestra el total a pagar después de aplicar el descuento y el abono
                            "Factura SysFac");
        }
    }
}
