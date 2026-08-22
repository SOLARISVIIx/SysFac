using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SysFac
{
    public partial class Arqueo : Form
    {
        private readonly string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=SysFac;Trusted_Connection=True;TrustServerCertificate=True;";

        public Arqueo()
        {
            InitializeComponent();

            this.Load += Arqueo_Load;
            this.MinimumSize = new System.Drawing.Size(1068, 848);
            this.MaximumSize = new System.Drawing.Size(1068, 848);
        }

        private void Arqueo_Load(object sender, EventArgs e)
        {
            CargarCajas();

            comboBoxcaja.SelectedIndexChanged += FiltroCambiado;
            dateTimePickerinicio.ValueChanged += FiltroCambiado;
            dateTimePickerfinal.ValueChanged += FiltroCambiado;

            textBoxEfectivoContado.TextChanged += textBoxEfectivoContado_TextChanged;
        }

        private void FiltroCambiado(object sender, EventArgs e)
        {
            GenerarArqueo();
        }

        private void CargarCajas()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                string sql = @"
                SELECT id_caja, ubicacion
                FROM caja
                ORDER BY ubicacion";

                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                DataTable dt = new DataTable();

                da.Fill(dt);

                comboBoxcaja.DataSource = dt;
                comboBoxcaja.DisplayMember = "ubicacion";
                comboBoxcaja.ValueMember = "id_caja";
            }
        }

        private void GenerarArqueo()
        {
            if (comboBoxcaja.SelectedValue == null)
                return;

            if (!int.TryParse(comboBoxcaja.SelectedValue.ToString(), out int idCaja))
                return;

            DateTime inicio = dateTimePickerinicio.Value.Date;

            DateTime fin =
                dateTimePickerfinal.Value.Date
                .AddDays(1)
                .AddSeconds(-1);

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                // RESUMEN GENERAL
                string sqlResumen = @"
                SELECT
                    COUNT(*) AS Facturas,
                    ISNULL(SUM(total),0) AS TotalFacturado,
                    ISNULL(SUM(iva),0) AS IVA,
                    ISNULL(SUM(descuento),0) AS Descuento
                FROM factura
                WHERE id_caja=@caja
                AND fecha BETWEEN @inicio AND @fin";

                SqlCommand cmdResumen = new SqlCommand(sqlResumen, cn);

                cmdResumen.Parameters.AddWithValue("@caja", idCaja);
                cmdResumen.Parameters.AddWithValue("@inicio", inicio);
                cmdResumen.Parameters.AddWithValue("@fin", fin);

                SqlDataReader dr = cmdResumen.ExecuteReader();

                if (dr.Read())
                {
                    textBoxFacturasEmitidas.Text = dr["Facturas"].ToString();

                    textBoxTotalFacturado.Text =
                        Convert.ToDecimal(dr["TotalFacturado"]).ToString("N2");

                    textBoxIVArecaudado.Text =
                        Convert.ToDecimal(dr["IVA"]).ToString("N2");

                    textBoxDescuentos.Text =
                        Convert.ToDecimal(dr["Descuento"]).ToString("N2");
                }

                dr.Close();

                // MÉTODOS DE PAGO (Filtrados por caja)
                decimal efectivo = 0;
                decimal tarjeta = 0;
                decimal transferencia = 0;

                string sqlPagos = @"
                SELECT
                    mp.nombre,
                    ISNULL(SUM(p.monto), 0) AS Total
                FROM pago p
                INNER JOIN metodo_pago mp
                    ON mp.id_metodo = p.id_metodo
                INNER JOIN factura f
                    ON f.id_factura = p.id_factura
                WHERE f.id_caja = @caja
                AND p.fecha BETWEEN @inicio AND @fin
                GROUP BY mp.nombre";

                SqlCommand cmdPagos = new SqlCommand(sqlPagos, cn);

                cmdPagos.Parameters.AddWithValue("@caja", idCaja);
                cmdPagos.Parameters.AddWithValue("@inicio", inicio);
                cmdPagos.Parameters.AddWithValue("@fin", fin);

                SqlDataReader drPagos = cmdPagos.ExecuteReader();

                while (drPagos.Read())
                {
                    string metodo = drPagos["nombre"].ToString();
                    decimal total = Convert.ToDecimal(drPagos["Total"]);

                    if (metodo.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
                        efectivo = total;
                    else if (metodo.Equals("Tarjeta", StringComparison.OrdinalIgnoreCase))
                        tarjeta = total;
                    else if (metodo.Equals("Transferencia", StringComparison.OrdinalIgnoreCase))
                        transferencia = total;
                }

                drPagos.Close();

                textBoxEfectivo.Text = efectivo.ToString("N2");
                textBoxTarjeta.Text = tarjeta.ToString("N2");
                textBoxTransferencia.Text = transferencia.ToString("N2");

                textBoxTotalrecaudado.Text =
                    (efectivo + tarjeta + transferencia).ToString("N2");

                // MOVIMIENTOS
                string sqlMovimientos = @"
                SELECT
                    fecha,
                    tipo,
                    monto,
                    id_factura
                FROM movimiento_caja
                WHERE id_caja=@caja
                AND fecha BETWEEN @inicio AND @fin
                ORDER BY fecha";

                SqlCommand cmdMov = new SqlCommand(sqlMovimientos, cn);

                cmdMov.Parameters.AddWithValue("@caja", idCaja);
                cmdMov.Parameters.AddWithValue("@inicio", inicio);
                cmdMov.Parameters.AddWithValue("@fin", fin);

                SqlDataAdapter da = new SqlDataAdapter(cmdMov);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridViewMovimientos.DataSource = dt;

                textBoxMontoEsperado.Text = efectivo.ToString("N2");
            }

            CalcularDiferencia();
        }

        private void textBoxEfectivoContado_TextChanged(object sender, EventArgs e)
        {
            CalcularDiferencia();
        }

        private void CalcularDiferencia()
        {
            decimal esperado = 0;
            decimal contado = 0;

            decimal.TryParse(textBoxMontoEsperado.Text, out esperado);
            decimal.TryParse(textBoxEfectivoContado.Text, out contado);

            decimal diferencia = contado - esperado;

            textBoxDiferencia.Text =
                diferencia.ToString("N2");

            if (diferencia == 0)
            {
                textBoxResultado.Text = "CUADRADO";
            }
            else if (diferencia > 0)
            {
                textBoxResultado.Text = "SOBRANTE";
            }
            else
            {
                textBoxResultado.Text = "FALTANTE";
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ReporteArqueo.GenerarArqueoPDF(
                comboBoxcaja.Text,
                dateTimePickerinicio.Value,
                dateTimePickerfinal.Value,
                textBoxFacturasEmitidas.Text,
                textBoxTotalFacturado.Text,
                textBoxIVArecaudado.Text,
                textBoxDescuentos.Text,
                textBoxEfectivo.Text,
                textBoxTarjeta.Text,
                textBoxTransferencia.Text,
                textBoxMontoEsperado.Text,
                textBoxEfectivoContado.Text,
                textBoxDiferencia.Text,
                textBoxResultado.Text,
                textBoxObservaciones.Text,
                dataGridViewMovimientos
            );
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();

            this.Close();
        }

        private void buttonCerrarCaja_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}