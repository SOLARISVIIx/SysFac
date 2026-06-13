namespace SysFac
{
    partial class Arqueo
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
            panel3 = new Panel();
            dateTimePickerfinal = new DateTimePicker();
            dateTimePickerinicio = new DateTimePicker();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            comboBoxcaja = new ComboBox();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            label14 = new Label();
            textBoxDescuentos = new TextBox();
            textBoxIVArecaudado = new TextBox();
            textBoxTotalFacturado = new TextBox();
            textBoxFacturasEmitidas = new TextBox();
            label13 = new Label();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            label15 = new Label();
            textBoxTotalrecaudado = new TextBox();
            textBoxTarjeta = new TextBox();
            textBoxTransferencia = new TextBox();
            textBoxEfectivo = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            dataGridViewMovimientos = new DataGridView();
            panel6 = new Panel();
            textBoxObservaciones = new TextBox();
            label25 = new Label();
            label20 = new Label();
            textBoxResultado = new TextBox();
            textBoxDiferencia = new TextBox();
            textBoxEfectivoContado = new TextBox();
            textBoxMontoEsperado = new TextBox();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            panel7 = new Panel();
            label26 = new Label();
            buttonSalir = new Button();
            buttonLimpiarDatos = new Button();
            buttonCerrarCaja = new Button();
            buttonGuardar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimientos).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.PowderBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(498, 47);
            label1.TabIndex = 0;
            label1.Text = "Control de Arqueo y Facturacion";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 188);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(dateTimePickerfinal);
            panel3.Controls.Add(dateTimePickerinicio);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(comboBoxcaja);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(-2, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 188);
            panel3.TabIndex = 7;
            // 
            // dateTimePickerfinal
            // 
            dateTimePickerfinal.Location = new Point(163, 137);
            dateTimePickerfinal.Name = "dateTimePickerfinal";
            dateTimePickerfinal.Size = new Size(300, 31);
            dateTimePickerfinal.TabIndex = 6;
            dateTimePickerfinal.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePickerinicio
            // 
            dateTimePickerinicio.Location = new Point(163, 89);
            dateTimePickerinicio.Name = "dateTimePickerinicio";
            dateTimePickerinicio.Size = new Size(300, 31);
            dateTimePickerinicio.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = Color.DarkSlateGray;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(3, 135);
            label6.Name = "label6";
            label6.Size = new Size(131, 33);
            label6.TabIndex = 4;
            label6.Text = "Fecha final";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.PowderBlue;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(3, -2);
            label9.Name = "label9";
            label9.Size = new Size(72, 27);
            label9.TabIndex = 0;
            label9.Text = "Filtros";
            // 
            // label7
            // 
            label7.BackColor = Color.DarkSlateGray;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(3, 87);
            label7.Name = "label7";
            label7.Size = new Size(131, 33);
            label7.TabIndex = 3;
            label7.Text = "Fecha inicio";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBoxcaja
            // 
            comboBoxcaja.FormattingEnabled = true;
            comboBoxcaja.Location = new Point(163, 43);
            comboBoxcaja.Name = "comboBoxcaja";
            comboBoxcaja.Size = new Size(182, 33);
            comboBoxcaja.TabIndex = 2;
            // 
            // label8
            // 
            label8.BackColor = Color.DarkSlateGray;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(3, 42);
            label8.Name = "label8";
            label8.Size = new Size(131, 33);
            label8.TabIndex = 1;
            label8.Text = "Caja";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(158, 137);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(158, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(-2, 135);
            label5.Name = "label5";
            label5.Size = new Size(131, 33);
            label5.TabIndex = 4;
            label5.Text = "Fecha final";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkSlateGray;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(-2, 87);
            label4.Name = "label4";
            label4.Size = new Size(131, 33);
            label4.TabIndex = 3;
            label4.Text = "Fecha inicio";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkSlateGray;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(-2, 42);
            label3.Name = "label3";
            label3.Size = new Size(131, 33);
            label3.TabIndex = 1;
            label3.Text = "Caja";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSlateGray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(214, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 27);
            label2.TabIndex = 0;
            label2.Text = "Filtros";
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(textBoxDescuentos);
            panel4.Controls.Add(textBoxIVArecaudado);
            panel4.Controls.Add(textBoxTotalFacturado);
            panel4.Controls.Add(textBoxFacturasEmitidas);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(526, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(506, 245);
            panel4.TabIndex = 2;
            // 
            // label14
            // 
            label14.BackColor = Color.PowderBlue;
            label14.BorderStyle = BorderStyle.Fixed3D;
            label14.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.DarkSlateBlue;
            label14.Location = new Point(149, 14);
            label14.Name = "label14";
            label14.Size = new Size(207, 35);
            label14.TabIndex = 1;
            label14.Text = "Resumen General";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDescuentos
            // 
            textBoxDescuentos.Location = new Point(207, 192);
            textBoxDescuentos.Name = "textBoxDescuentos";
            textBoxDescuentos.Size = new Size(297, 31);
            textBoxDescuentos.TabIndex = 12;
            // 
            // textBoxIVArecaudado
            // 
            textBoxIVArecaudado.Location = new Point(207, 149);
            textBoxIVArecaudado.Name = "textBoxIVArecaudado";
            textBoxIVArecaudado.Size = new Size(297, 31);
            textBoxIVArecaudado.TabIndex = 13;
            // 
            // textBoxTotalFacturado
            // 
            textBoxTotalFacturado.Location = new Point(207, 102);
            textBoxTotalFacturado.Name = "textBoxTotalFacturado";
            textBoxTotalFacturado.ReadOnly = true;
            textBoxTotalFacturado.Size = new Size(297, 31);
            textBoxTotalFacturado.TabIndex = 12;
            // 
            // textBoxFacturasEmitidas
            // 
            textBoxFacturasEmitidas.Location = new Point(207, 57);
            textBoxFacturasEmitidas.Name = "textBoxFacturasEmitidas";
            textBoxFacturasEmitidas.ReadOnly = true;
            textBoxFacturasEmitidas.Size = new Size(297, 31);
            textBoxFacturasEmitidas.TabIndex = 11;
            // 
            // label13
            // 
            label13.BackColor = Color.DarkSlateGray;
            label13.BorderStyle = BorderStyle.Fixed3D;
            label13.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(3, 192);
            label13.Name = "label13";
            label13.Size = new Size(198, 33);
            label13.TabIndex = 10;
            label13.Text = "Descuentos";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.DarkSlateGray;
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(3, 147);
            label10.Name = "label10";
            label10.Size = new Size(198, 33);
            label10.TabIndex = 9;
            label10.Text = "IVA recaudado";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.DarkSlateGray;
            label12.BorderStyle = BorderStyle.Fixed3D;
            label12.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Window;
            label12.Location = new Point(3, 55);
            label12.Name = "label12";
            label12.Size = new Size(198, 33);
            label12.TabIndex = 7;
            label12.Text = "Facturas emitidas";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.DarkSlateGray;
            label11.BorderStyle = BorderStyle.Fixed3D;
            label11.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(3, 100);
            label11.Name = "label11";
            label11.Size = new Size(198, 33);
            label11.TabIndex = 8;
            label11.Text = "Total Facturado";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CadetBlue;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label15);
            panel5.Controls.Add(textBoxTotalrecaudado);
            panel5.Controls.Add(textBoxTarjeta);
            panel5.Controls.Add(textBoxTransferencia);
            panel5.Controls.Add(textBoxEfectivo);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(12, 263);
            panel5.Name = "panel5";
            panel5.Size = new Size(506, 245);
            panel5.TabIndex = 14;
            // 
            // label15
            // 
            label15.BackColor = Color.PowderBlue;
            label15.BorderStyle = BorderStyle.Fixed3D;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkSlateBlue;
            label15.Location = new Point(149, 14);
            label15.Name = "label15";
            label15.Size = new Size(207, 35);
            label15.TabIndex = 1;
            label15.Text = "Resumen General";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalrecaudado
            // 
            textBoxTotalrecaudado.Location = new Point(207, 192);
            textBoxTotalrecaudado.Name = "textBoxTotalrecaudado";
            textBoxTotalrecaudado.Size = new Size(292, 31);
            textBoxTotalrecaudado.TabIndex = 12;
            // 
            // textBoxTarjeta
            // 
            textBoxTarjeta.Location = new Point(207, 149);
            textBoxTarjeta.Name = "textBoxTarjeta";
            textBoxTarjeta.Size = new Size(292, 31);
            textBoxTarjeta.TabIndex = 13;
            // 
            // textBoxTransferencia
            // 
            textBoxTransferencia.Location = new Point(207, 102);
            textBoxTransferencia.Name = "textBoxTransferencia";
            textBoxTransferencia.ReadOnly = true;
            textBoxTransferencia.Size = new Size(292, 31);
            textBoxTransferencia.TabIndex = 12;
            // 
            // textBoxEfectivo
            // 
            textBoxEfectivo.Location = new Point(207, 57);
            textBoxEfectivo.Name = "textBoxEfectivo";
            textBoxEfectivo.ReadOnly = true;
            textBoxEfectivo.Size = new Size(292, 31);
            textBoxEfectivo.TabIndex = 11;
            // 
            // label16
            // 
            label16.BackColor = Color.DarkSlateGray;
            label16.BorderStyle = BorderStyle.Fixed3D;
            label16.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.Window;
            label16.Location = new Point(3, 192);
            label16.Name = "label16";
            label16.Size = new Size(198, 33);
            label16.TabIndex = 10;
            label16.Text = "Total recaudado";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = Color.DarkSlateGray;
            label17.BorderStyle = BorderStyle.Fixed3D;
            label17.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Window;
            label17.Location = new Point(3, 147);
            label17.Name = "label17";
            label17.Size = new Size(198, 33);
            label17.TabIndex = 9;
            label17.Text = "Tarjeta";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = Color.DarkSlateGray;
            label18.BorderStyle = BorderStyle.Fixed3D;
            label18.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.Window;
            label18.Location = new Point(3, 55);
            label18.Name = "label18";
            label18.Size = new Size(198, 33);
            label18.TabIndex = 7;
            label18.Text = "Efectivo";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = Color.DarkSlateGray;
            label19.BorderStyle = BorderStyle.Fixed3D;
            label19.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.Window;
            label19.Location = new Point(3, 100);
            label19.Name = "label19";
            label19.Size = new Size(198, 33);
            label19.TabIndex = 8;
            label19.Text = "Transferencia";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMovimientos
            // 
            dataGridViewMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovimientos.Location = new Point(526, 263);
            dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            dataGridViewMovimientos.RowHeadersWidth = 62;
            dataGridViewMovimientos.Size = new Size(506, 245);
            dataGridViewMovimientos.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.CadetBlue;
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(textBoxObservaciones);
            panel6.Controls.Add(label25);
            panel6.Controls.Add(label20);
            panel6.Controls.Add(textBoxResultado);
            panel6.Controls.Add(textBoxDiferencia);
            panel6.Controls.Add(textBoxEfectivoContado);
            panel6.Controls.Add(textBoxMontoEsperado);
            panel6.Controls.Add(label21);
            panel6.Controls.Add(label22);
            panel6.Controls.Add(label23);
            panel6.Controls.Add(label24);
            panel6.Location = new Point(12, 514);
            panel6.Name = "panel6";
            panel6.Size = new Size(506, 266);
            panel6.TabIndex = 15;
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.Location = new Point(207, 223);
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Size = new Size(292, 31);
            textBoxObservaciones.TabIndex = 15;
            // 
            // label25
            // 
            label25.BackColor = Color.DarkSlateGray;
            label25.BorderStyle = BorderStyle.Fixed3D;
            label25.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.Window;
            label25.Location = new Point(3, 223);
            label25.Name = "label25";
            label25.Size = new Size(198, 33);
            label25.TabIndex = 14;
            label25.Text = "Observaciones";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BackColor = Color.PowderBlue;
            label20.BorderStyle = BorderStyle.Fixed3D;
            label20.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.DarkSlateBlue;
            label20.Location = new Point(149, 0);
            label20.Name = "label20";
            label20.Size = new Size(207, 35);
            label20.TabIndex = 1;
            label20.Text = "Arqueo Fisico";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(207, 178);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new Size(292, 31);
            textBoxResultado.TabIndex = 12;
            // 
            // textBoxDiferencia
            // 
            textBoxDiferencia.Location = new Point(207, 135);
            textBoxDiferencia.Name = "textBoxDiferencia";
            textBoxDiferencia.Size = new Size(292, 31);
            textBoxDiferencia.TabIndex = 13;
            // 
            // textBoxEfectivoContado
            // 
            textBoxEfectivoContado.Location = new Point(207, 88);
            textBoxEfectivoContado.Name = "textBoxEfectivoContado";
            textBoxEfectivoContado.Size = new Size(292, 31);
            textBoxEfectivoContado.TabIndex = 12;
            // 
            // textBoxMontoEsperado
            // 
            textBoxMontoEsperado.Location = new Point(207, 43);
            textBoxMontoEsperado.Name = "textBoxMontoEsperado";
            textBoxMontoEsperado.ReadOnly = true;
            textBoxMontoEsperado.Size = new Size(292, 31);
            textBoxMontoEsperado.TabIndex = 11;
            // 
            // label21
            // 
            label21.BackColor = Color.DarkSlateGray;
            label21.BorderStyle = BorderStyle.Fixed3D;
            label21.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.Window;
            label21.Location = new Point(3, 178);
            label21.Name = "label21";
            label21.Size = new Size(198, 33);
            label21.TabIndex = 10;
            label21.Text = "Resultado";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.BackColor = Color.DarkSlateGray;
            label22.BorderStyle = BorderStyle.Fixed3D;
            label22.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.Window;
            label22.Location = new Point(3, 133);
            label22.Name = "label22";
            label22.Size = new Size(198, 33);
            label22.TabIndex = 9;
            label22.Text = "Diferencia";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.BackColor = Color.DarkSlateGray;
            label23.BorderStyle = BorderStyle.Fixed3D;
            label23.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.Window;
            label23.Location = new Point(3, 41);
            label23.Name = "label23";
            label23.Size = new Size(198, 33);
            label23.TabIndex = 7;
            label23.Text = "Monto esperado";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.BackColor = Color.DarkSlateGray;
            label24.BorderStyle = BorderStyle.Fixed3D;
            label24.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.Window;
            label24.Location = new Point(3, 86);
            label24.Name = "label24";
            label24.Size = new Size(198, 33);
            label24.TabIndex = 8;
            label24.Text = "Efectivo contado";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSteelBlue;
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(label26);
            panel7.Controls.Add(buttonSalir);
            panel7.Controls.Add(buttonLimpiarDatos);
            panel7.Controls.Add(buttonCerrarCaja);
            panel7.Controls.Add(buttonGuardar);
            panel7.Location = new Point(524, 514);
            panel7.Name = "panel7";
            panel7.Size = new Size(508, 266);
            panel7.TabIndex = 16;
            // 
            // label26
            // 
            label26.BackColor = Color.DarkSeaGreen;
            label26.BorderStyle = BorderStyle.Fixed3D;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.LavenderBlush;
            label26.Location = new Point(142, 11);
            label26.Name = "label26";
            label26.Size = new Size(207, 35);
            label26.TabIndex = 16;
            label26.Text = "Acciones";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.DarkRed;
            buttonSalir.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Location = new Point(64, 155);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(181, 77);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonLimpiarDatos
            // 
            buttonLimpiarDatos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpiarDatos.Location = new Point(251, 155);
            buttonLimpiarDatos.Name = "buttonLimpiarDatos";
            buttonLimpiarDatos.Size = new Size(181, 77);
            buttonLimpiarDatos.TabIndex = 2;
            buttonLimpiarDatos.Text = "Limpiar Datos";
            buttonLimpiarDatos.UseVisualStyleBackColor = true;
            // 
            // buttonCerrarCaja
            // 
            buttonCerrarCaja.BackColor = Color.HotPink;
            buttonCerrarCaja.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCerrarCaja.ForeColor = SystemColors.ButtonHighlight;
            buttonCerrarCaja.Location = new Point(251, 63);
            buttonCerrarCaja.Name = "buttonCerrarCaja";
            buttonCerrarCaja.Size = new Size(181, 79);
            buttonCerrarCaja.TabIndex = 1;
            buttonCerrarCaja.Text = "Cerrar Caja";
            buttonCerrarCaja.UseVisualStyleBackColor = false;
            buttonCerrarCaja.Click += buttonCerrarCaja_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.Turquoise;
            buttonGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = SystemColors.ButtonHighlight;
            buttonGuardar.Location = new Point(64, 63);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(181, 79);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // Arqueo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1046, 792);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(dataGridViewMovimientos);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Arqueo";
            Text = "Arqueo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovimientos).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private DateTimePicker dateTimePickerfinal;
        private DateTimePicker dateTimePickerinicio;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxcaja;
        private Label label8;
        private Label label9;
        private Panel panel4;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label13;
        private TextBox textBoxDescuentos;
        private TextBox textBoxIVArecaudado;
        private TextBox textBoxTotalFacturado;
        private TextBox textBoxFacturasEmitidas;
        private Label label14;
        private Panel panel5;
        private Label label15;
        private TextBox textBoxTotalrecaudado;
        private TextBox textBoxTarjeta;
        private TextBox textBoxTransferencia;
        private TextBox textBoxEfectivo;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView dataGridViewMovimientos;
        private Panel panel6;
        private Label label20;
        private TextBox textBoxResultado;
        private TextBox textBoxDiferencia;
        private TextBox textBoxEfectivoContado;
        private TextBox textBoxMontoEsperado;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private TextBox textBoxObservaciones;
        private Label label25;
        private Panel panel7;
        private Button buttonLimpiarDatos;
        private Button buttonCerrarCaja;
        private Button buttonGuardar;
        private Button buttonSalir;
        private Label label26;
    }
}