using static System.Windows.Forms.DataFormats;

namespace SysFac
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(837, 510);
            this.MaximumSize = new System.Drawing.Size(837, 510);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            this.Hide();
        }
    }
}
