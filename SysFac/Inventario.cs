using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SysFac
{
    public partial class Inventario : Form
    {
        private readonly string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=SysFac;Trusted_Connection=True;TrustServerCertificate=True;";

        public Inventario()
        {
            InitializeComponent();

            this.Load += Inventario_Load;
            this.MinimumSize = new System.Drawing.Size(699, 756);
            this.MaximumSize = new System.Drawing.Size(699, 756);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarProductos();

            buttonAgregarproducto.Click += buttonAgregarProducto_Click;
            buttonLimpiar.Click += buttonLimpiar_Click;
            buttonSalir.Click += buttonSalir_Click;

            dataGridViewInventario.CellDoubleClick += dataGridViewProductos_CellDoubleClick;
        }

        private void CargarProductos()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    string sql = @"
                    SELECT
                        id_producto AS ID,
                        nombre AS Producto,
                        precio AS Precio,
                        stock AS Existencia
                    FROM producto
                    ORDER BY nombre";

                    SqlDataAdapter da = new SqlDataAdapter(sql, cn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dataGridViewInventario.DataSource = dt;

                    dataGridViewInventario.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridViewInventario.ReadOnly = true;

                    dataGridViewInventario.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;

                    dataGridViewInventario.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar productos.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreproducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                return;
            }

            if (!decimal.TryParse(textBoxPrecioproducto.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            if (!int.TryParse(textBoxCantidadproducto.Text, out int stock))
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    string sql = @"
                    INSERT INTO producto
                    (
                        nombre,
                        precio,
                        stock
                    )
                    VALUES
                    (
                        @nombre,
                        @precio,
                        @stock
                    )";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    cmd.Parameters.AddWithValue("@nombre", textBoxNombreproducto.Text.Trim());
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Producto agregado correctamente.",
                    "Inventario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // --- RECARGA DEL COMBOBOX EN EL FORMULARIO PRINCIPAL ---
                FacturacionSYSFAC? frmFactura = Application.OpenForms.OfType<FacturacionSYSFAC>().FirstOrDefault();
                if (frmFactura != null)
                {
                    // Llama al método que carga datos iniciales/productos en tu formulario principal
                    frmFactura.CargarDatosIniciales();
                }

                LimpiarCampos();

                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBoxNombreproducto.Clear();
            textBoxPrecioproducto.Clear();
            textBoxCantidadproducto.Clear();

            textBoxNombreproducto.Focus();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (this.Owner != null)
                this.Owner.Show();

            this.Close();
        }

        private void dataGridViewProductos_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dataGridViewInventario.Rows[e.RowIndex];

            textBoxNombreproducto.Text =
                fila.Cells["Producto"].Value.ToString();

            textBoxPrecioproducto.Text =
                fila.Cells["Precio"].Value.ToString();

            textBoxCantidadproducto.Text =
                fila.Cells["Existencia"].Value.ToString();
        }
    }
}