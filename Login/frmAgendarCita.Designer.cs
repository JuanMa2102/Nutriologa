namespace Login
{
    partial class frmAgendarCita
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPaciente = new System.Windows.Forms.DataGridView();
            this.IDCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnConsultarCita = new System.Windows.Forms.Button();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaciente
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCita,
            this.Paciente,
            this.Fecha,
            this.Horario});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaciente.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPaciente.Location = new System.Drawing.Point(18, 22);
            this.dgvPaciente.Name = "dgvPaciente";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaciente.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPaciente.RowHeadersVisible = false;
            this.dgvPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaciente.Size = new System.Drawing.Size(973, 487);
            this.dgvPaciente.TabIndex = 0;
            // 
            // IDCita
            // 
            this.IDCita.DataPropertyName = "IDCita";
            this.IDCita.HeaderText = "IDCita";
            this.IDCita.Name = "IDCita";
            this.IDCita.ReadOnly = true;
            this.IDCita.Visible = false;
            this.IDCita.Width = 150;
            // 
            // Paciente
            // 
            this.Paciente.DataPropertyName = "Nombre";
            this.Paciente.HeaderText = "Paciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.ReadOnly = true;
            this.Paciente.Width = 400;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 300;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            this.Horario.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "AGENDAR CITA";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrid.Controls.Add(this.dgvPaciente);
            this.pnlGrid.Location = new System.Drawing.Point(231, 109);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1008, 529);
            this.pnlGrid.TabIndex = 14;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.btnEliminarCita.FlatAppearance.BorderSize = 0;
            this.btnEliminarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.btnEliminarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCita.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminarCita.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCita.Image = global::Login.Properties.Resources.ico_10;
            this.btnEliminarCita.Location = new System.Drawing.Point(32, 374);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(147, 112);
            this.btnEliminarCita.TabIndex = 12;
            this.btnEliminarCita.Text = "ELIMINAR CITA";
            this.btnEliminarCita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarCita.UseVisualStyleBackColor = false;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnConsultarCita
            // 
            this.btnConsultarCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.btnConsultarCita.FlatAppearance.BorderSize = 0;
            this.btnConsultarCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.btnConsultarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarCita.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultarCita.ForeColor = System.Drawing.Color.White;
            this.btnConsultarCita.Image = global::Login.Properties.Resources.ico_10;
            this.btnConsultarCita.Location = new System.Drawing.Point(32, 241);
            this.btnConsultarCita.Name = "btnConsultarCita";
            this.btnConsultarCita.Size = new System.Drawing.Size(147, 112);
            this.btnConsultarCita.TabIndex = 11;
            this.btnConsultarCita.Text = "CONSULTAR CITA";
            this.btnConsultarCita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultarCita.UseVisualStyleBackColor = false;
            this.btnConsultarCita.Click += new System.EventHandler(this.btnConsultarCita_Click);
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevaCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.btnNuevaCita.FlatAppearance.BorderSize = 0;
            this.btnNuevaCita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(81)))));
            this.btnNuevaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCita.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCita.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCita.Image = global::Login.Properties.Resources.ico_10;
            this.btnNuevaCita.Location = new System.Drawing.Point(32, 109);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(147, 112);
            this.btnNuevaCita.TabIndex = 10;
            this.btnNuevaCita.Text = "NUEVA CITA";
            this.btnNuevaCita.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevaCita.UseVisualStyleBackColor = false;
            this.btnNuevaCita.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Image = global::Login.Properties.Resources.flecha_blanca02;
            this.btnAtras.Location = new System.Drawing.Point(12, 592);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(136, 46);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Login.Properties.Resources.header_sistema;
            this.pictureBox1.InitialImage = global::Login.Properties.Resources.header_sistema;
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1207, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.btnConsultarCita);
            this.Controls.Add(this.btnNuevaCita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAgendarCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Agendar Citas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaciente)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Button btnConsultarCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
    }
}