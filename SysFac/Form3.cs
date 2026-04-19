using System;
using Microsoft.Data.SqlClient; // La librería moderna
using System.Windows.Forms;

namespace SysFac
{
    public partial class Form3 : Form
    {
        // Tu cadena de conexión ajustada a (localdb)
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SysFac;Integrated Security=True;TrustServerCertificate=True;";

        public Form3()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(578, 598);
            this.MaximumSize = new System.Drawing.Size(578, 598);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Validaciones previas
            if (string.IsNullOrWhiteSpace(textBoxNombreF3.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Query de inserción
            string sql = @"INSERT INTO dbo.cliente (nombre, correo, numero_ruc, telefono) 
                           VALUES (@nombre, @correo, @ruc, @tel)";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cnn);

                    // 4. Mapeo de parámetros
                    cmd.Parameters.AddWithValue("@nombre", textBoxNombreF3.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", textBoxCorreoF3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ruc", mtbRucF3.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", mtbTelefonoF3.Text.Trim());

                    cnn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente registrado con éxito en SysFac.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // --- NUEVA LÓGICA DE ACTUALIZACIÓN ---
                        // Buscamos el formulario de facturación (Form2) si está abierto
                        Form2? frmFactura = (Form2?)Application.OpenForms["Form2"];
                        if (frmFactura != null)
                        {
                            frmFactura.CargarDatosIniciales(); // Recargamos los combos del Form2
                        }

                        LimpiarCampos();
                        this.Close(); // Opcional: cerramos para volver directo a la factura
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error general: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            textBoxNombreF3.Clear();
            textBoxCorreoF3.Clear();
            mtbRucF3.Clear();
            mtbTelefonoF3.Clear();
            textBoxNombreF3.Focus();
        }
    }
}