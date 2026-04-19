#nullable enable

using Microsoft.Data.SqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SysFac
{
    public partial class Form2 : Form
    {
        // Conexión alineada a tu base de datos SysFac
        private readonly string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=SysFac;Trusted_Connection=True;TrustServerCertificate=True;";

        public Form2()
        {
            InitializeComponent();

            // Eventos principales
            this.Load += (s, e) => CargarDatosIniciales();
            button4.Click += button4_Click; // Agregar producto
            button3.Click += button3_Click; // Guardar Factura e Imprimir

            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += ComboBox2_SelectedIndexChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;


            this.MinimumSize = new System.Drawing.Size(1528, 834);
            this.MaximumSize = new System.Drawing.Size(1528, 834);
            dataGridView1.AllowUserToAddRows = false;
        }

        #region Carga de Datos (Combos)
        // CAMBIO: Se cambió a 'public' para que Form3 pueda invocar la recarga
        public void CargarDatosIniciales()
        {
            try
            {
                LlenarCombo("SELECT id_cliente, nombre, telefono, numero_ruc FROM cliente", comboBox1, "nombre", "id_cliente");
                LlenarCombo("SELECT id_producto, nombre, precio FROM producto", comboBox2, "nombre", "id_producto");
                LlenarCombo("SELECT id_metodo, nombre FROM metodo_pago", comboBox3, "nombre", "id_metodo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión inicial: " + ex.Message);
            }
        }

        private void LlenarCombo(string sql, ComboBox cb, string display, string value)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.SelectedIndex = -1;
        }
        #endregion

        #region Eventos de Selección (TextBoxes)
        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is DataRowView row)
            {
                // El RUC y Teléfono se tratan como VARCHAR (texto puro)
                textBox1.Text = row["telefono"]?.ToString() ?? "";
                textBox3.Text = row["numero_ruc"]?.ToString() ?? "";
            }
        }

        private void ComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (comboBox2.SelectedItem is DataRowView row)
            {
                textBox7.Text = Convert.ToDecimal(row["precio"]).ToString("N2");
            }
        }
        #endregion

        #region Lógica del DataGridView
        private void button4_Click(object? sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null) return;
            if (!int.TryParse(textBox2.Text, out int cant) || cant <= 0) return;

            int idProd = (int)comboBox2.SelectedValue;
            decimal precio = LimpiarYParsear(textBox7.Text);
            bool existe = false;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Tag != null && (int)fila.Tag == idProd)
                {
                    int cantActual = Convert.ToInt32(fila.Cells[1].Value);
                    fila.Cells[1].Value = cantActual + cant;
                    fila.Cells[3].Value = (cantActual + cant) * precio;
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                int n = dataGridView1.Rows.Add(comboBox2.Text, cant, precio, cant * precio, ObtenerStockProducto(idProd), "Eliminar");
                dataGridView1.Rows[n].Tag = idProd;
            }
            CalcularTotales();
            textBox2.Clear();
        }

        private void dataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Columna 5 es el botón "Eliminar"
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            decimal sub = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
                if (r.Cells[3].Value != null) sub += Convert.ToDecimal(r.Cells[3].Value);

            textBox4.Text = sub.ToString("N2");
            textBox9.Text = (sub * 0.15m).ToString("N2"); // IVA 15%
            textBox8.Text = (sub * 1.15m).ToString("N2"); // Total con IVA

            decimal desc = LimpiarYParsear(textBox5.Text);
            textBox10.Text = (sub * 1.15m - desc).ToString("N2");
        }
        #endregion

        #region Guardado y PDF
        private void button3_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || comboBox1.SelectedValue == null) return;

            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlTransaction tran = conn.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarFacturaCompleta", conn, tran);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cliente", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@id_usuario", 2); // ID de usuario según tu lógica
                cmd.Parameters.AddWithValue("@id_caja", 1);    // ID de caja según tu lógica
                cmd.Parameters.AddWithValue("@subtotal", LimpiarYParsear(textBox4.Text));
                cmd.Parameters.AddWithValue("@iva", LimpiarYParsear(textBox9.Text));
                cmd.Parameters.AddWithValue("@descuento", LimpiarYParsear(textBox5.Text));
                cmd.Parameters.AddWithValue("@total", LimpiarYParsear(textBox8.Text));
                cmd.Parameters.AddWithValue("@total_a_pagar", LimpiarYParsear(textBox10.Text));
                cmd.Parameters.AddWithValue("@metodo_pago", comboBox3.SelectedValue);

                // Crear el DataTable para el parámetro tipo Tabla (TVP)
                DataTable det = new DataTable();
                det.Columns.Add("id_producto", typeof(int));
                det.Columns.Add("cantidad", typeof(int));
                det.Columns.Add("precio_unitario", typeof(decimal));
                det.Columns.Add("subtotal", typeof(decimal));

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    det.Rows.Add(r.Tag, r.Cells[1].Value, r.Cells[2].Value, r.Cells[3].Value);
                }

                SqlParameter tvp = cmd.Parameters.AddWithValue("@detalleFactura", det);
                tvp.SqlDbType = SqlDbType.Structured;
                tvp.TypeName = "dbo.DetalleFacturaType"; // Asegúrate que este nombre coincida con tu TYPE en SQL

                cmd.ExecuteNonQuery();
                tran.Commit();

                int idFac = ObtenerUltimoIdFactura();
                if (idFac > 0) GenerarFacturaPDF(idFac);

                MessageBox.Show("Factura Guardada con éxito.");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                if (tran != null && tran.Connection != null) tran.Rollback();
                MessageBox.Show("Error al guardar factura: " + ex.Message);
            }
        }

        private void GenerarFacturaPDF(int id)
        {
            try
            {
                DataTable dt = ObtenerDatosReporte(id);
                // Usamos float directamente para evitar el error de Unit a float
                float anchoTicketPuntos = 226.77f; // Aprox 7.5cm
                string ruta = Path.Combine(@"C:\Facturas\", $"Ticket_{id}.pdf");

                Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        // CORRECCIÓN: Usamos el constructor de PageSize directamente
                        page.Size(new PageSize(anchoTicketPuntos, 842f)); // Altura inicial estandar, se ajustará
                        page.Margin(10);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(9).FontColor(Colors.Black).FontFamily(Fonts.Verdana));

                        page.Content().Column(col =>
                        {
                            col.Item().Text("FACTURA").FontSize(14).ExtraBold().AlignCenter();
                            col.Item().Text("SYSFAC S.A.").FontSize(11).Bold().AlignCenter();
                            col.Item().PaddingBottom(5).LineHorizontal(1).LineColor(Colors.Black);

                            // INFO CLIENTE: Usamos el texto directo de los controles sin "LimpiarYParsear"
                            col.Item().AlignCenter().Text(x => { x.Span("Cliente: ").Bold(); x.Span(comboBox1.Text); });
                            col.Item().AlignCenter().Text(x => { x.Span("Tel: ").Bold(); x.Span(textBox1.Text); });
                            col.Item().AlignCenter().Text(x => { x.Span("RUC: ").Bold(); x.Span(textBox3.Text); });

                            col.Item().PaddingVertical(5).LineHorizontal(0.5f).LineColor(Colors.Grey.Lighten2);

                            col.Item().Table(t =>
                            {
                                t.ColumnsDefinition(cd =>
                                {
                                    cd.RelativeColumn(3);
                                    cd.RelativeColumn(1);
                                    cd.RelativeColumn(1.5f);
                                    cd.RelativeColumn(1.5f);
                                });

                                t.Header(h =>
                                {
                                    h.Cell().Text("Producto").Bold();
                                    h.Cell().AlignCenter().Text("Cant").Bold();
                                    h.Cell().AlignRight().Text("Precio").Bold();
                                    h.Cell().AlignRight().Text("Subtotal").Bold();
                                });

                                foreach (DataRow r in dt.Rows)
                                {
                                    t.Cell().Text(r["producto"]?.ToString() ?? "S/N");
                                    t.Cell().AlignCenter().Text(r["cantidad"]?.ToString() ?? "0");
                                    t.Cell().AlignRight().Text(Convert.ToDecimal(r["precio_unitario"]).ToString("N2"));
                                    t.Cell().AlignRight().Text(Convert.ToDecimal(r["subtotal"]).ToString("N2"));
                                }
                            });

                            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);

                            col.Item().AlignRight().Text("I.V.A. Incluido").FontSize(8);
                            // Usamos el total a pagar directamente del label/textbox
                            col.Item().AlignRight().Text(x =>
                            {
                                x.Span("TOTAL: ").Bold().FontSize(12);
                                x.Span(textBox10.Text).Bold().FontSize(12);
                            });

                            col.Item().PaddingTop(10).AlignCenter().Text(DateTime.Now.ToString("G")).FontSize(8);
                            col.Item().AlignCenter().Text($"Factura N°: {id}").FontSize(8).Italic();
                            col.Item().PaddingTop(5).AlignCenter().Text("¡Gracias por su compra!").FontSize(9).Bold();
                        });
                    });
                }).GeneratePdf(ruta);

                Process.Start(new ProcessStartInfo { FileName = ruta, UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Crítico en PDF: " + ex.Message + "\nDetalle: " + ex.InnerException?.Message);
            }
        }
        #endregion

        #region Helpers
        private decimal LimpiarYParsear(string t) =>
            decimal.TryParse(Regex.Replace(t, @"[^0-9\.]", ""), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal r) ? r : 0;

        private int ObtenerUltimoIdFactura()
        {
            using SqlConnection c = new SqlConnection(connectionString);
            c.Open();
            var result = new SqlCommand("SELECT TOP 1 id_factura FROM factura ORDER BY id_factura DESC", c).ExecuteScalar();
            return (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : 0;
        }

        private int ObtenerStockProducto(int id)
        {
            using SqlConnection c = new SqlConnection(connectionString);
            c.Open();
            SqlCommand cmd = new SqlCommand("SELECT stock FROM producto WHERE id_producto = @id", c);
            cmd.Parameters.AddWithValue("@id", id);
            return Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
        }

        private DataTable ObtenerDatosReporte(int id)
        {
            using SqlConnection c = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("sp_ObtenerFacturaParaReporte", c);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id_factura", id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private void LimpiarFormulario()
        {
            dataGridView1.Rows.Clear();
            textBox2.Clear();
            CalcularTotales();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        #endregion

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            // CAMBIO: Usamos ShowDialog para que el usuario complete el registro antes de volver a facturar
            form3.ShowDialog();
        }
    }
}