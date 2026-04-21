using System;
using Microsoft.Data.SqlClient; 
using System.Windows.Forms;

namespace SysFac
{
    public partial class Form3 : Form
    {
       
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SysFac;Integrated Security=True;TrustServerCertificate=True;";

        public Form3()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(578, 598);
            this.MaximumSize = new System.Drawing.Size(578, 598);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxNombreF3.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string sql = @"INSERT INTO dbo.cliente (nombre, correo, numero_ruc, telefono) 
                           VALUES (@nombre, @correo, @ruc, @tel)";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cnn);

                    
                    cmd.Parameters.AddWithValue("@nombre", textBoxNombreF3.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", textBoxCorreoF3.Text.Trim());
                    cmd.Parameters.AddWithValue("@ruc", mtbRucF3.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", mtbTelefonoF3.Text.Trim());

                    cnn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente registrado con éxito en SysFac.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        
                        Form2? frmFactura = (Form2?)Application.OpenForms["Form2"];
                        if (frmFactura != null)
                        {
                            frmFactura.CargarDatosIniciales(); 
                        }

                        LimpiarCampos();
                        this.Close(); 
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