namespace SysFac
{
    partial class Inventario
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            dataGridViewInventario = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            buttonSalir = new Button();
            buttonLimpiar = new Button();
            buttonAgregarproducto = new Button();
            textBoxCantidadproducto = new TextBox();
            textBoxPrecioproducto = new TextBox();
            textBoxNombreproducto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 62);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.MediumPurple;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(621, 38);
            label1.TabIndex = 1;
            label1.Text = "Control de Inventario";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridViewInventario);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 293);
            panel2.TabIndex = 1;
            // 
            // dataGridViewInventario
            // 
            dataGridViewInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventario.Location = new Point(3, 35);
            dataGridViewInventario.Name = "dataGridViewInventario";
            dataGridViewInventario.RowHeadersWidth = 62;
            dataGridViewInventario.Size = new Size(643, 251);
            dataGridViewInventario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SlateBlue;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(179, -2);
            label2.Name = "label2";
            label2.Size = new Size(288, 34);
            label2.TabIndex = 0;
            label2.Text = "Existencia de productos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(buttonSalir);
            panel3.Controls.Add(buttonLimpiar);
            panel3.Controls.Add(buttonAgregarproducto);
            panel3.Controls.Add(textBoxCantidadproducto);
            panel3.Controls.Add(textBoxPrecioproducto);
            panel3.Controls.Add(textBoxNombreproducto);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 412);
            panel3.Name = "panel3";
            panel3.Size = new Size(653, 276);
            panel3.TabIndex = 2;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.IndianRed;
            buttonSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = SystemColors.ButtonHighlight;
            buttonSalir.Location = new Point(440, 218);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(176, 34);
            buttonSalir.TabIndex = 10;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(237, 218);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(176, 34);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar Datos";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarproducto
            // 
            buttonAgregarproducto.BackColor = Color.LightGreen;
            buttonAgregarproducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAgregarproducto.ForeColor = SystemColors.ActiveCaptionText;
            buttonAgregarproducto.Location = new Point(34, 218);
            buttonAgregarproducto.Name = "buttonAgregarproducto";
            buttonAgregarproducto.Size = new Size(176, 34);
            buttonAgregarproducto.TabIndex = 8;
            buttonAgregarproducto.Text = "Agregar producto";
            buttonAgregarproducto.UseVisualStyleBackColor = false;
            // 
            // textBoxCantidadproducto
            // 
            textBoxCantidadproducto.Location = new Point(319, 166);
            textBoxCantidadproducto.Name = "textBoxCantidadproducto";
            textBoxCantidadproducto.Size = new Size(217, 31);
            textBoxCantidadproducto.TabIndex = 7;
            // 
            // textBoxPrecioproducto
            // 
            textBoxPrecioproducto.Location = new Point(319, 116);
            textBoxPrecioproducto.Name = "textBoxPrecioproducto";
            textBoxPrecioproducto.Size = new Size(217, 31);
            textBoxPrecioproducto.TabIndex = 6;
            // 
            // textBoxNombreproducto
            // 
            textBoxNombreproducto.Location = new Point(319, 66);
            textBoxNombreproducto.Name = "textBoxNombreproducto";
            textBoxNombreproducto.Size = new Size(217, 31);
            textBoxNombreproducto.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = Color.MediumPurple;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(98, 159);
            label6.Name = "label6";
            label6.Size = new Size(217, 38);
            label6.TabIndex = 4;
            label6.Text = "Cantidad del producto";
            // 
            // label5
            // 
            label5.BackColor = Color.MediumPurple;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(98, 109);
            label5.Name = "label5";
            label5.Size = new Size(217, 38);
            label5.TabIndex = 3;
            label5.Text = "Precio del producto";
            // 
            // label4
            // 
            label4.BackColor = Color.MediumPurple;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(98, 59);
            label4.Name = "label4";
            label4.Size = new Size(217, 38);
            label4.TabIndex = 2;
            label4.Text = "Nombre del producto";
            // 
            // label3
            // 
            label3.BackColor = Color.SlateBlue;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(179, 0);
            label3.Name = "label3";
            label3.Size = new Size(288, 42);
            label3.TabIndex = 1;
            label3.Text = "Agregar producto";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(677, 700);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Inventario";
            Text = "Inventario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventario).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridViewInventario;
        private Panel panel3;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxCantidadproducto;
        private TextBox textBoxPrecioproducto;
        private TextBox textBoxNombreproducto;
        private Button buttonLimpiar;
        private Button buttonAgregarproducto;
        private Button buttonSalir;
    }
}