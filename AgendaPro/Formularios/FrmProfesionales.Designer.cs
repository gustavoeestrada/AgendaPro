namespace AgendaPro.Formularios
{
    partial class FrmProfesionales
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
            lblNombre = new Label();
            lblEstado = new Label();
            lblEspecialidad = new Label();
            txtNombre = new TextBox();
            txtEstado = new TextBox();
            txtEspecialidad = new TextBox();
            dgvProfesionales = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnBuscar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(75, 119);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(75, 231);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "Estado";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(75, 178);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 2;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 119);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(188, 231);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(125, 27);
            txtEstado.TabIndex = 4;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(188, 178);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(125, 27);
            txtEspecialidad.TabIndex = 5;
            // 
            // dgvProfesionales
            // 
            dgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesionales.Location = new Point(430, 94);
            dgvProfesionales.Name = "dgvProfesionales";
            dgvProfesionales.RowHeadersWidth = 51;
            dgvProfesionales.Size = new Size(300, 188);
            dgvProfesionales.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(353, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(112, 342);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(480, 342);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(233, 342);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FrmProfesionales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvProfesionales);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtEstado);
            Controls.Add(txtNombre);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblEstado);
            Controls.Add(lblNombre);
            Name = "FrmProfesionales";
            Text = "FrmProfesionales";
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblEstado;
        private Label lblEspecialidad;
        private TextBox txtNombre;
        private TextBox txtEstado;
        private TextBox txtEspecialidad;
        private DataGridView dgvProfesionales;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnEditar;
    }
}