namespace AgendaPro.Formularios
{
    partial class FrmCitas
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
            cbCliente = new ComboBox();
            cbServicio = new ComboBox();
            cbProfesional = new ComboBox();
            dtpFecha = new DateTimePicker();
            cbHora = new ComboBox();
            lblHorarioDisponible = new Label();
            btnAgendar = new Button();
            dgvCitas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(94, 60);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(151, 28);
            cbCliente.TabIndex = 0;
            // 
            // cbServicio
            // 
            cbServicio.FormattingEnabled = true;
            cbServicio.Location = new Point(94, 177);
            cbServicio.Name = "cbServicio";
            cbServicio.Size = new Size(151, 28);
            cbServicio.TabIndex = 1;
            // 
            // cbProfesional
            // 
            cbProfesional.FormattingEnabled = true;
            cbProfesional.Location = new Point(94, 120);
            cbProfesional.Name = "cbProfesional";
            cbProfesional.Size = new Size(151, 28);
            cbProfesional.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(94, 238);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 3;
            // 
            // cbHora
            // 
            cbHora.FormattingEnabled = true;
            cbHora.Location = new Point(254, 297);
            cbHora.Name = "cbHora";
            cbHora.Size = new Size(151, 28);
            cbHora.TabIndex = 4;
            // 
            // lblHorarioDisponible
            // 
            lblHorarioDisponible.AutoSize = true;
            lblHorarioDisponible.Location = new Point(94, 297);
            lblHorarioDisponible.Name = "lblHorarioDisponible";
            lblHorarioDisponible.Size = new Size(136, 20);
            lblHorarioDisponible.TabIndex = 5;
            lblHorarioDisponible.Text = "Horario Disponible";
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(94, 366);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(94, 29);
            btnAgendar.TabIndex = 6;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(439, 100);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.RowHeadersWidth = 51;
            dgvCitas.Size = new Size(300, 188);
            dgvCitas.TabIndex = 7;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCitas);
            Controls.Add(btnAgendar);
            Controls.Add(lblHorarioDisponible);
            Controls.Add(cbHora);
            Controls.Add(dtpFecha);
            Controls.Add(cbProfesional);
            Controls.Add(cbServicio);
            Controls.Add(cbCliente);
            Name = "FrmCitas";
            Text = "FrmCitas";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCliente;
        private ComboBox cbServicio;
        private ComboBox cbProfesional;
        private DateTimePicker dtpFecha;
        private ComboBox cbHora;
        private Label lblHorarioDisponible;
        private Button btnAgendar;
        private DataGridView dgvCitas;
    }
}