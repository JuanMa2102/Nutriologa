namespace Login
{
    partial class frmCitasporPeriodo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReportePeriodo = new System.Windows.Forms.DataGridView();
            this.dtmFechaIn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmFechaFi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.IDCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "CITAS POR PERIODO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvReportePeriodo
            // 
            this.dgvReportePeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportePeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCita,
            this.Nombre,
            this.Fecha,
            this.Horario});
            this.dgvReportePeriodo.Location = new System.Drawing.Point(288, 119);
            this.dgvReportePeriodo.Name = "dgvReportePeriodo";
            this.dgvReportePeriodo.Size = new System.Drawing.Size(542, 488);
            this.dgvReportePeriodo.TabIndex = 14;
            this.dgvReportePeriodo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportePeriodo_CellContentClick);
            // 
            // dtmFechaIn
            // 
            this.dtmFechaIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFechaIn.Location = new System.Drawing.Point(40, 211);
            this.dtmFechaIn.Name = "dtmFechaIn";
            this.dtmFechaIn.Size = new System.Drawing.Size(171, 20);
            this.dtmFechaIn.TabIndex = 16;
            this.dtmFechaIn.ValueChanged += new System.EventHandler(this.dtmFecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "FECHA INICIAL";
            // 
            // dtmFechaFi
            // 
            this.dtmFechaFi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFechaFi.Location = new System.Drawing.Point(40, 314);
            this.dtmFechaFi.Name = "dtmFechaFi";
            this.dtmFechaFi.Size = new System.Drawing.Size(171, 20);
            this.dtmFechaFi.TabIndex = 18;
            this.dtmFechaFi.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(101)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "FECHA FINAL";
            // 
            // IDCita
            // 
            this.IDCita.DataPropertyName = "IDCita";
            this.IDCita.HeaderText = "IDCita";
            this.IDCita.Name = "IDCita";
            this.IDCita.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 300;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(66)))), ((int)(((byte)(100)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Login.Properties.Resources.ico_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(40, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 80);
            this.button1.TabIndex = 19;
            this.button1.Text = "GENERAR REPORTE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Login.Properties.Resources.header_sistema;
            this.pictureBox1.InitialImage = global::Login.Properties.Resources.WhatsApp_Image_2019_04_07_at_11_22_25_PM;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmCitasporPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtmFechaFi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtmFechaIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReportePeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCitasporPeriodo";
            this.Text = "frmCitasporPeriodo";
            this.Load += new System.EventHandler(this.frmCitasporPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportePeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReportePeriodo;
        private System.Windows.Forms.DateTimePicker dtmFechaIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtmFechaFi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
    }
}