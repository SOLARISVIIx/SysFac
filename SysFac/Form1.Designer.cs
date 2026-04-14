namespace SysFac
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(397, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 31);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSteelBlue;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(278, 262);
            label1.Name = "label1";
            label1.Size = new Size(113, 31);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSteelBlue;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(278, 321);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(342, 379);
            button1.Name = "button1";
            button1.Size = new Size(164, 34);
            button1.TabIndex = 4;
            button1.Text = "Iniciar sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(278, 153);
            label4.Name = "label4";
            label4.Size = new Size(144, 70);
            label4.TabIndex = 6;
            label4.Text = "De";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(397, 153);
            label5.Name = "label5";
            label5.Size = new Size(193, 70);
            label5.TabIndex = 7;
            label5.Text = "Prisa";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(278, 83);
            label3.Name = "label3";
            label3.Size = new Size(312, 70);
            label3.TabIndex = 8;
            label3.Text = "Caminando";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(811, 450);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "loginForm";
            Text = "SYSFAC";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label3;
    }
}
