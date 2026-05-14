namespace AgendaPro.Formularios
{
    partial class FrmMenuPrincipal
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
            btnClientes = new Button();
            btnCitas = new Button();
            btnServicios = new Button();
            btnProfesionales = new Button();
            btnSalir = new Button();
            btnReportes = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(74, 89);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(135, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCitas
            // 
            btnCitas.Location = new Point(74, 251);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(135, 29);
            btnCitas.TabIndex = 1;
            btnCitas.Text = "Citas";
            btnCitas.UseVisualStyleBackColor = true;
            btnCitas.Click += btnCitas_Click;
            // 
            // btnServicios
            // 
            btnServicios.Location = new Point(74, 196);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(135, 29);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnProfesionales
            // 
            btnProfesionales.Location = new Point(74, 143);
            btnProfesionales.Name = "btnProfesionales";
            btnProfesionales.Size = new Size(135, 29);
            btnProfesionales.TabIndex = 3;
            btnProfesionales.Text = "Profesionales";
            btnProfesionales.UseVisualStyleBackColor = true;
            btnProfesionales.Click += btnProfesionales_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(74, 354);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(74, 304);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(135, 29);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 39);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 6;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReportes);
            Controls.Add(btnSalir);
            Controls.Add(btnProfesionales);
            Controls.Add(btnServicios);
            Controls.Add(btnCitas);
            Controls.Add(btnClientes);
            Name = "FrmMenuPrincipal";
            Text = "FrmMenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClientes;
        private Button btnCitas;
        private Button btnServicios;
        private Button btnProfesionales;
        private Button btnSalir;
        private Button btnReportes;
        private Label label1;
    }
}