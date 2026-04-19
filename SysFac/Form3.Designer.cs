namespace SysFac
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBoxNombreF3 = new TextBox();
            textBoxCorreoF3 = new TextBox();
            mtbRucF3 = new MaskedTextBox();
            mtbTelefonoF3 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNombreF3
            // 
            textBoxNombreF3.Location = new Point(214, 200);
            textBoxNombreF3.Name = "textBoxNombreF3";
            textBoxNombreF3.Size = new Size(319, 31);
            textBoxNombreF3.TabIndex = 0;
            // 
            // textBoxCorreoF3
            // 
            textBoxCorreoF3.Location = new Point(214, 270);
            textBoxCorreoF3.Name = "textBoxCorreoF3";
            textBoxCorreoF3.Size = new Size(319, 31);
            textBoxCorreoF3.TabIndex = 1;
            // 
            // mtbRucF3
            // 
            mtbRucF3.Location = new Point(214, 340);
            mtbRucF3.Name = "mtbRucF3";
            mtbRucF3.Size = new Size(319, 31);
            mtbRucF3.TabIndex = 2;
            // 
            // mtbTelefonoF3
            // 
            mtbTelefonoF3.Location = new Point(214, 410);
            mtbTelefonoF3.Name = "mtbTelefonoF3";
            mtbTelefonoF3.Size = new Size(319, 31);
            mtbTelefonoF3.TabIndex = 3;
            // 
            // label1
            // 
            label1.BackColor = Color.Indigo;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(25, 200);
            label1.Name = "label1";
            label1.Size = new Size(183, 31);
            label1.TabIndex = 4;
            label1.Text = "Nombre/Apellido:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Indigo;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(25, 270);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 5;
            label2.Text = "Correo Electronico:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Indigo;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(25, 340);
            label3.Name = "label3";
            label3.Size = new Size(183, 31);
            label3.TabIndex = 6;
            label3.Text = "Numero RUC:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Indigo;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(25, 410);
            label4.Name = "label4";
            label4.Size = new Size(183, 31);
            label4.TabIndex = 7;
            label4.Text = "Numero Telefonico:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(132, 467);
            button1.Name = "button1";
            button1.Size = new Size(144, 51);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.Location = new Point(282, 467);
            button2.Name = "button2";
            button2.Size = new Size(144, 51);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(556, 542);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtbTelefonoF3);
            Controls.Add(mtbRucF3);
            Controls.Add(textBoxCorreoF3);
            Controls.Add(textBoxNombreF3);
            Name = "Form3";
            Text = "Añadir Cliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombreF3;
        private TextBox textBoxCorreoF3;
        private MaskedTextBox mtbRucF3;
        private MaskedTextBox mtbTelefonoF3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}